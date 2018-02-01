using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiTrade
{
    public partial class FormMain : Form
    {
        IPlatform platform;
        public bool apiCheck = false;

        public FormMain()
        {
            InitializeComponent();
            SetPlatformBittrex();
            SetDashboardTab();
            CheckApi();
        }



        private void SetPlatformBittrex()
        {
            platform = new BittrexPlatform();
        }

        private void SetPlatformBinance()
        {
            /// Todo
        }


        #region Api

        private void SetApiFailTab()
        {
            tabControl1.SelectTab("apiFail");
            // Todo
        }

        private async Task<ApiStatus> CheckApi()
        {
            var res = await platform.CheckKeySecret();
            if (res != ApiStatus.CONNECTION_TIMEOUT)
            {
                apiCheck = (res == ApiStatus.TRUE) ? true : false;
            }
            return res;
        }

        #endregion

        #region Dashboard

        decimal oldPriceBtc = 0;
        decimal oldPriceEth = 0;

        private void SetDashboardTab()
        {
            tabControl1.SelectTab("dashboardPage");

            if (oldPriceBtc == 0)
            {
                dashBtcDOWN.Visible = false;
                dashBtcUP.Visible = false;
                dashBtcChangeUp.Visible = false;
                dashBtcChangeDown.Visible = false;
            }
            if (oldPriceEth == 0)
            {
                dashEthDown.Visible = false;
                dashEthUp.Visible = false;
                dashEthChangeUp.Visible = false;
                dashEthChangeDown.Visible = false;
            }
            UpdateBTCPriceAsync();
            UpdateETHPriceAsync();
            // Todo
        }

        private async void UpdateBTCPriceAsync()
        {
            decimal newPrice = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            try
            {
                var task = platform.GetPriceBtc();
                var res = await Task.WhenAny(task, Task.Delay(10000));
                if (res == task)
                {
                    // Task completed within time.
                    newPrice = task.GetAwaiter().GetResult();
                }
                else
                {
                    // Task timed out
                    watch.Stop();
                    SetConnectionQuality(-1);
                    return;
                    // LOG
                }
                watch.Stop();
                SetConnectionQuality(watch.ElapsedMilliseconds);
            }
            catch
            {
                watch.Stop();
                SetConnectionQuality(-1);
                return;
                // LOG
            }

            if (newPrice > 0)
            {
                dashLabelBtcPrice.Text = string.Format("{0:n0}", newPrice) + "$";
                if (oldPriceBtc != 0)
                {
                    if (newPrice > oldPriceBtc)
                    {
                        dashBtcDOWN.Visible = false;
                        dashBtcUP.Visible = true;
                    }
                    else if (newPrice < oldPriceBtc)
                    {
                        dashBtcDOWN.Visible = true;
                        dashBtcUP.Visible = false;
                    }
                }

                oldPriceBtc = newPrice;


                var market = await platform.GetMarketSummary("USDT-BTC");
                if (market != null)
                {
                    dashLabelBtcHigh.Text = string.Format("{0:n0}", market.High) + "$";
                    dashLabelBtcLow.Text = string.Format("{0:n0}", market.Low) + "$";
                    decimal profit = (newPrice / (market.PrevDay)) - 1;
                    dashLabelBtcChange.Text = String.Format("{0:P2}", profit);
                    if (profit > 0)
                    {
                        dashBtcChangeUp.Visible = true;
                        dashBtcChangeDown.Visible = false;
                    }
                    else
                    {
                        dashBtcChangeUp.Visible = false;
                        dashBtcChangeDown.Visible = true;
                    }

                }
            }


        }

        private async void UpdateETHPriceAsync()
        {
            decimal newPrice = 0;

            try
            {
                var task = await platform.GetPriceCurrencyUsd("ETH");
                if (task > 0)
                    newPrice = task;
            }
            catch
            {
                // LOG
            }

            if (newPrice > 0)
            {
                dashLabelEthPrice.Text = string.Format("{0:n0}", newPrice) + "$";
                if (oldPriceEth != 0)
                {
                    if (newPrice > oldPriceEth)
                    {
                        dashEthDown.Visible = false;
                        dashEthUp.Visible = true;
                    }
                    else if (newPrice < oldPriceEth)
                    {
                        dashEthDown.Visible = true;
                        dashEthUp.Visible = false;
                    }
                }

                oldPriceEth = newPrice;

                var market = await platform.GetMarketSummary("USDT-ETH");
                if (market != null)
                {
                    dashLabelEthHigh.Text = string.Format("{0:n0}", market.High) + "$";
                    dashLabelEthLow.Text = string.Format("{0:n0}", market.Low) + "$";
                    decimal profit = (newPrice / (market.PrevDay)) - 1;
                    dashLabelEthChange.Text = String.Format("{0:P2}", profit);
                    if (profit > 0)
                    {
                        dashEthChangeUp.Visible = true;
                        dashEthChangeDown.Visible = false;
                    }
                    else
                    {
                        dashEthChangeUp.Visible = false;
                        dashEthChangeDown.Visible = true;
                    }

                }
            }
        }



        private void timerBtcPrice_Tick(object sender, EventArgs e)
        {
            UpdateBTCPriceAsync();
        }

        #endregion

        #region Trade

        private void SetTradeTab()
        {
            tabControl1.SelectTab("tradePage");
            // Todo
        }

        #endregion

        #region Balance

        private async void SetBalanceTab()
        {
            tabControl1.SelectTab("balancePage");

            decimal btc = await platform.GetBalanceBtc();
            decimal usd = await platform.GetBalanceUsd();

            balanceLabelBtc.Text = Math.Round(btc, 6).ToString();
            balanceLabelUsd.Text = String.Format("{0:n}", usd);
        }

        #endregion

        #region Connection

        private void SetConnectionQuality(long miliseconds)
        {
            long seconds = miliseconds / 1000;
            if (miliseconds == -1)
            {
                ConnectionGood.Visible = false;
                ConnectionLow.Visible = false;
                ConnectionBad.Visible = true;
            }
            else if (seconds < 5)
            {
                ConnectionGood.Visible = true;
                ConnectionLow.Visible = false;
                ConnectionBad.Visible = false;
            }
            else
            {
                ConnectionGood.Visible = false;
                ConnectionLow.Visible = true;
                ConnectionBad.Visible = false;
            }
        }

        #endregion

        #region Menu buttons

        void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelMenuPicker.Height = buttonDashboard.Height;
            panelMenuPicker.Top = buttonDashboard.Top;

            SetDashboardTab();
        }

        async void buttonTrade_ClickAsync(object sender, EventArgs e)
        {
            panelMenuPicker.Height = buttonTrade.Height;
            panelMenuPicker.Top = buttonTrade.Top;

            if (!apiCheck)
            {
                SetApiFailTab();
                var task = CheckApi();
                var res = await Task.WhenAny(task, Task.Delay(1000));
                if (res == task)
                {
                    if (task.Result == ApiStatus.TRUE)
                    {
                        SetTradeTab();
                    }
                }
            }
            else
            {
                SetTradeTab();
            }
        }

        async void buttonBalance_ClickAsync(object sender, EventArgs e)
        {
            panelMenuPicker.Height = buttonBalance.Height;
            panelMenuPicker.Top = buttonBalance.Top;

            if (!apiCheck)
            {
                SetApiFailTab();
                var task = CheckApi();
                var res = await Task.WhenAny(task, Task.Delay(1000));
                if (res == task)
                {
                    if (task.Result == ApiStatus.TRUE)
                    {
                        SetTradeTab();
                    }
                }
            }
            else
            {
                SetBalanceTab();
            }
        }

        private void buttonBittrex_Click(object sender, EventArgs e)
        {
            buttonBittrex.FlatAppearance.BorderSize = 1;
            buttonBinance.FlatAppearance.BorderSize = 0;
            SetPlatformBittrex();
        }

        private void buttonBinance_Click(object sender, EventArgs e)
        {
            buttonBittrex.FlatAppearance.BorderSize = 0;
            buttonBinance.FlatAppearance.BorderSize = 1;
            SetPlatformBinance();
        }



        #endregion

        #region Move window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion

        #region Top menu

        private void CloseApp()
        {
            Application.Exit();
        }

        private void MinimizeApp()
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CloseApp();
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            MinimizeApp();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MinimizeApp();
        }

        private async void buttonSettings_ClickAsync(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            if (formSettings.ShowDialog(this) == DialogResult.OK)
            {
                apiCheck = false;
                await CheckApi();
            }
        }


        #endregion

        private void timerEthPrice_Tick(object sender, EventArgs e)
        {
            UpdateETHPriceAsync();
        }
    }


}

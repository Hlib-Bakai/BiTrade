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

        public FormMain()
        {
            InitializeComponent();
            SetPlatformBittrex();
            SetDashboardTab();
        }

        private void SetPlatformBittrex()
        {
            platform = new BittrexPlatform();
        }

        private void SetPlatformBinance()
        {
            /// Todo
        }

        #region Dashboard

        decimal oldPrice = 0;

        private void SetDashboardTab()
        {
            tabControl1.SelectTab("dashboardPage");

            if (oldPrice == 0)
            {
                dashBtcDOWN.Visible = false;
                dashBtcUP.Visible = false;
            }
            UpdateBTCPriceAsync();
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
            

            dashLabelBtcPrice.Text = string.Format("{0:n0}", newPrice) + "$";
            if (oldPrice != 0)
            {
                if (newPrice > oldPrice)
                {
                    dashBtcDOWN.Visible = false;
                    dashBtcUP.Visible = true;
                } else if (newPrice < oldPrice)
                {
                    dashBtcDOWN.Visible = true;
                    dashBtcUP.Visible = false;
                }
            }

            oldPrice = newPrice;
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

        private async void SetBalanceTabAsync()
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
            } else
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

        void buttonTrade_Click(object sender, EventArgs e)
        {
            panelMenuPicker.Height = buttonTrade.Height;
            panelMenuPicker.Top = buttonTrade.Top;

            SetTradeTab();
        }

        void buttonBalance_Click(object sender, EventArgs e)
        {
            panelMenuPicker.Height = buttonBalance.Height;
            panelMenuPicker.Top = buttonBalance.Top;

            SetBalanceTabAsync();
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

        #region Close and minimize

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




        #endregion

    }


}

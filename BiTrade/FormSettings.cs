using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiTrade
{
    public partial class FormSettings : Form
    {
        private bool bitKeyChanged = true;
        private bool bitSecretChanged = true;
        private bool binKeyChanged = true;
        private bool binSecretChanged = true;

        public FormSettings()
        {
            InitializeComponent();

            bittrexKey.Text = AppSetings.Default.BittrexApiKey;
            if (bittrexKey.Text != "")
            {
                bittrexSecret.Text = "Secret?";
            }

            binanceKey.Text = AppSetings.Default.BinanceApiKey;
            if (binanceKey.Text != "")
            {
                binanceSecret.Text = "Secret?";
            }

            bitKeyChanged = false;
            bitSecretChanged = false;
            binKeyChanged = false;
            binSecretChanged = false;

            button1.Visible = false;
            //button1.ForeColor = Color.FromArgb(45, 45, 48);
        }

        private void EnableButtonSave()
        {
            button1.Visible = true;
            //button1.ForeColor = Color.LimeGreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bittrex
            if (bitKeyChanged)
                AppSetings.Default.BittrexApiKey = bittrexKey.Text;

            if (bitSecretChanged)
            {
                AppSetings.Default.BittrexApiSecret = Security.EncryptString(Security.ToSecureString(bittrexSecret.Text));
            }
            
            //Binance
            if (binKeyChanged)
                AppSetings.Default.BinanceApiKey = binanceKey.Text;

            if (binSecretChanged)
            {
                AppSetings.Default.BinanceApiSecret = Security.EncryptString(Security.ToSecureString(binanceSecret.Text));
            }           

            AppSetings.Default.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bittrexSecret_TextChanged(object sender, EventArgs e)
        {
            if (!bitSecretChanged)
            {
                bittrexSecret.Text = "";
                bitSecretChanged = true;
                EnableButtonSave();
            }
        }

        private void bittrexKey_TextChanged(object sender, EventArgs e)
        {
            if (!bitKeyChanged)
            {
                bitKeyChanged = true;
                EnableButtonSave();
            }
        }

        private void binanceKey_TextChanged(object sender, EventArgs e)
        {
            if (!binKeyChanged)
            {
                binKeyChanged = true;
                EnableButtonSave();
            }
        }

        private void binanceSecret_TextChanged(object sender, EventArgs e)
        {
            if (!binSecretChanged)
            {
                binanceSecret.Text = "";
                binSecretChanged = true;
                EnableButtonSave();
            }
        }
    }
}

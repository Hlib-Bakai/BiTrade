namespace BiTrade
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBinance = new System.Windows.Forms.Button();
            this.buttonBittrex = new System.Windows.Forms.Button();
            this.buttonBalance = new System.Windows.Forms.Button();
            this.buttonTrade = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenuPicker = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1 = new BiTrade.TabControlWithoutHeader();
            this.dashboardPage = new System.Windows.Forms.TabPage();
            this.panelBtcUpDown = new System.Windows.Forms.Panel();
            this.dashBtcUP = new System.Windows.Forms.PictureBox();
            this.dashBtcDOWN = new System.Windows.Forms.PictureBox();
            this.dashLabelBtcPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tradePage = new System.Windows.Forms.TabPage();
            this.balancePage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.balanceLabelUsd = new System.Windows.Forms.Label();
            this.balanceLabelBtc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTabs = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.timerBtcPrice = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.ConnectionGood = new System.Windows.Forms.PictureBox();
            this.ConnectionLow = new System.Windows.Forms.PictureBox();
            this.ConnectionBad = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.dashboardPage.SuspendLayout();
            this.panelBtcUpDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashBtcUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashBtcDOWN)).BeginInit();
            this.balancePage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionBad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBinance);
            this.panel1.Controls.Add(this.buttonBittrex);
            this.panel1.Controls.Add(this.buttonBalance);
            this.panel1.Controls.Add(this.buttonTrade);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 526);
            this.panel1.TabIndex = 0;
            // 
            // buttonBinance
            // 
            this.buttonBinance.FlatAppearance.BorderSize = 0;
            this.buttonBinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBinance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBinance.Location = new System.Drawing.Point(108, 101);
            this.buttonBinance.Name = "buttonBinance";
            this.buttonBinance.Size = new System.Drawing.Size(80, 28);
            this.buttonBinance.TabIndex = 4;
            this.buttonBinance.Text = "Binance";
            this.buttonBinance.UseVisualStyleBackColor = true;
            this.buttonBinance.Click += new System.EventHandler(this.buttonBinance_Click);
            // 
            // buttonBittrex
            // 
            this.buttonBittrex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBittrex.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBittrex.Location = new System.Drawing.Point(23, 101);
            this.buttonBittrex.Name = "buttonBittrex";
            this.buttonBittrex.Size = new System.Drawing.Size(80, 28);
            this.buttonBittrex.TabIndex = 2;
            this.buttonBittrex.Text = "Bittrex";
            this.buttonBittrex.UseVisualStyleBackColor = true;
            this.buttonBittrex.Click += new System.EventHandler(this.buttonBittrex_Click);
            // 
            // buttonBalance
            // 
            this.buttonBalance.FlatAppearance.BorderSize = 0;
            this.buttonBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBalance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBalance.ForeColor = System.Drawing.Color.White;
            this.buttonBalance.Image = ((System.Drawing.Image)(resources.GetObject("buttonBalance.Image")));
            this.buttonBalance.Location = new System.Drawing.Point(3, 328);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(204, 95);
            this.buttonBalance.TabIndex = 3;
            this.buttonBalance.Text = "Balance";
            this.buttonBalance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBalance.UseVisualStyleBackColor = true;
            this.buttonBalance.Click += new System.EventHandler(this.buttonBalance_Click);
            // 
            // buttonTrade
            // 
            this.buttonTrade.FlatAppearance.BorderSize = 0;
            this.buttonTrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrade.ForeColor = System.Drawing.Color.White;
            this.buttonTrade.Image = ((System.Drawing.Image)(resources.GetObject("buttonTrade.Image")));
            this.buttonTrade.Location = new System.Drawing.Point(3, 227);
            this.buttonTrade.Name = "buttonTrade";
            this.buttonTrade.Size = new System.Drawing.Size(204, 95);
            this.buttonTrade.TabIndex = 2;
            this.buttonTrade.Text = "Trade";
            this.buttonTrade.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonTrade.UseVisualStyleBackColor = true;
            this.buttonTrade.Click += new System.EventHandler(this.buttonTrade_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.Location = new System.Drawing.Point(3, 135);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(204, 95);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 80);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "BiTrade";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenuPicker
            // 
            this.panelMenuPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
            this.panelMenuPicker.Location = new System.Drawing.Point(210, 135);
            this.panelMenuPicker.Name = "panelMenuPicker";
            this.panelMenuPicker.Size = new System.Drawing.Size(7, 95);
            this.panelMenuPicker.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(715, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(115)))), ((int)(((byte)(142)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 5);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(677, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 32);
            this.panel4.TabIndex = 6;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dashboardPage);
            this.tabControl1.Controls.Add(this.tradePage);
            this.tabControl1.Controls.Add(this.balancePage);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 445);
            this.tabControl1.TabIndex = 7;
            // 
            // dashboardPage
            // 
            this.dashboardPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dashboardPage.Controls.Add(this.panelBtcUpDown);
            this.dashboardPage.Controls.Add(this.dashLabelBtcPrice);
            this.dashboardPage.Controls.Add(this.label3);
            this.dashboardPage.Location = new System.Drawing.Point(4, 30);
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardPage.Size = new System.Drawing.Size(536, 411);
            this.dashboardPage.TabIndex = 0;
            this.dashboardPage.Text = "dashboard";
            // 
            // panelBtcUpDown
            // 
            this.panelBtcUpDown.Controls.Add(this.dashBtcUP);
            this.panelBtcUpDown.Controls.Add(this.dashBtcDOWN);
            this.panelBtcUpDown.Location = new System.Drawing.Point(377, 29);
            this.panelBtcUpDown.Name = "panelBtcUpDown";
            this.panelBtcUpDown.Size = new System.Drawing.Size(25, 25);
            this.panelBtcUpDown.TabIndex = 1;
            // 
            // dashBtcUP
            // 
            this.dashBtcUP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBtcUP.Image = ((System.Drawing.Image)(resources.GetObject("dashBtcUP.Image")));
            this.dashBtcUP.Location = new System.Drawing.Point(0, 0);
            this.dashBtcUP.Name = "dashBtcUP";
            this.dashBtcUP.Size = new System.Drawing.Size(25, 25);
            this.dashBtcUP.TabIndex = 2;
            this.dashBtcUP.TabStop = false;
            // 
            // dashBtcDOWN
            // 
            this.dashBtcDOWN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBtcDOWN.Image = ((System.Drawing.Image)(resources.GetObject("dashBtcDOWN.Image")));
            this.dashBtcDOWN.Location = new System.Drawing.Point(0, 0);
            this.dashBtcDOWN.Name = "dashBtcDOWN";
            this.dashBtcDOWN.Size = new System.Drawing.Size(25, 25);
            this.dashBtcDOWN.TabIndex = 3;
            this.dashBtcDOWN.TabStop = false;
            // 
            // dashLabelBtcPrice
            // 
            this.dashLabelBtcPrice.AutoSize = true;
            this.dashLabelBtcPrice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashLabelBtcPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dashLabelBtcPrice.Location = new System.Drawing.Point(273, 24);
            this.dashLabelBtcPrice.Name = "dashLabelBtcPrice";
            this.dashLabelBtcPrice.Size = new System.Drawing.Size(21, 30);
            this.dashLabelBtcPrice.TabIndex = 1;
            this.dashLabelBtcPrice.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "BTC Price:";
            // 
            // tradePage
            // 
            this.tradePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tradePage.Location = new System.Drawing.Point(4, 22);
            this.tradePage.Name = "tradePage";
            this.tradePage.Padding = new System.Windows.Forms.Padding(3);
            this.tradePage.Size = new System.Drawing.Size(536, 419);
            this.tradePage.TabIndex = 1;
            this.tradePage.Text = "trade";
            // 
            // balancePage
            // 
            this.balancePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.balancePage.Controls.Add(this.panel2);
            this.balancePage.Location = new System.Drawing.Point(4, 22);
            this.balancePage.Name = "balancePage";
            this.balancePage.Size = new System.Drawing.Size(536, 419);
            this.balancePage.TabIndex = 2;
            this.balancePage.Text = "balance";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.balanceLabelUsd);
            this.panel2.Controls.Add(this.balanceLabelBtc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(184, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 107);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "BTC:";
            // 
            // balanceLabelUsd
            // 
            this.balanceLabelUsd.AutoSize = true;
            this.balanceLabelUsd.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabelUsd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.balanceLabelUsd.Location = new System.Drawing.Point(83, 59);
            this.balanceLabelUsd.Name = "balanceLabelUsd";
            this.balanceLabelUsd.Size = new System.Drawing.Size(18, 23);
            this.balanceLabelUsd.TabIndex = 3;
            this.balanceLabelUsd.Text = "-";
            // 
            // balanceLabelBtc
            // 
            this.balanceLabelBtc.AutoSize = true;
            this.balanceLabelBtc.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabelBtc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.balanceLabelBtc.Location = new System.Drawing.Point(83, 17);
            this.balanceLabelBtc.Name = "balanceLabelBtc";
            this.balanceLabelBtc.Size = new System.Drawing.Size(18, 23);
            this.balanceLabelBtc.TabIndex = 1;
            this.balanceLabelBtc.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "USD:";
            // 
            // panelTabs
            // 
            this.panelTabs.Controls.Add(this.tabControl1);
            this.panelTabs.Location = new System.Drawing.Point(213, 79);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(550, 451);
            this.panelTabs.TabIndex = 8;
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.Location = new System.Drawing.Point(623, 12);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(37, 35);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // timerBtcPrice
            // 
            this.timerBtcPrice.Enabled = true;
            this.timerBtcPrice.Interval = 1000;
            this.timerBtcPrice.Tick += new System.EventHandler(this.timerBtcPrice_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(210, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(547, 10);
            this.panel5.TabIndex = 3;
            // 
            // ConnectionGood
            // 
            this.ConnectionGood.Image = ((System.Drawing.Image)(resources.GetObject("ConnectionGood.Image")));
            this.ConnectionGood.Location = new System.Drawing.Point(582, 20);
            this.ConnectionGood.Name = "ConnectionGood";
            this.ConnectionGood.Size = new System.Drawing.Size(24, 24);
            this.ConnectionGood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ConnectionGood.TabIndex = 10;
            this.ConnectionGood.TabStop = false;
            // 
            // ConnectionLow
            // 
            this.ConnectionLow.Image = ((System.Drawing.Image)(resources.GetObject("ConnectionLow.Image")));
            this.ConnectionLow.Location = new System.Drawing.Point(582, 20);
            this.ConnectionLow.Name = "ConnectionLow";
            this.ConnectionLow.Size = new System.Drawing.Size(24, 24);
            this.ConnectionLow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ConnectionLow.TabIndex = 11;
            this.ConnectionLow.TabStop = false;
            this.ConnectionLow.Visible = false;
            // 
            // ConnectionBad
            // 
            this.ConnectionBad.Image = ((System.Drawing.Image)(resources.GetObject("ConnectionBad.Image")));
            this.ConnectionBad.Location = new System.Drawing.Point(582, 20);
            this.ConnectionBad.Name = "ConnectionBad";
            this.ConnectionBad.Size = new System.Drawing.Size(24, 24);
            this.ConnectionBad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ConnectionBad.TabIndex = 12;
            this.ConnectionBad.TabStop = false;
            this.ConnectionBad.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(759, 526);
            this.Controls.Add(this.ConnectionBad);
            this.Controls.Add(this.ConnectionLow);
            this.Controls.Add(this.ConnectionGood);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMenuPicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTabs);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(115)))), ((int)(((byte)(142)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.dashboardPage.ResumeLayout(false);
            this.dashboardPage.PerformLayout();
            this.panelBtcUpDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dashBtcUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashBtcDOWN)).EndInit();
            this.balancePage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionBad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBalance;
        private System.Windows.Forms.Button buttonTrade;
        private System.Windows.Forms.Button buttonBinance;
        private System.Windows.Forms.Button buttonBittrex;
        private System.Windows.Forms.Panel panelMenuPicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private TabControlWithoutHeader tabControl1;
        private System.Windows.Forms.TabPage dashboardPage;
        private System.Windows.Forms.TabPage tradePage;
        private System.Windows.Forms.Panel panelTabs;
        private System.Windows.Forms.TabPage balancePage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label balanceLabelUsd;
        private System.Windows.Forms.Label balanceLabelBtc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label dashLabelBtcPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBtcUpDown;
        private System.Windows.Forms.PictureBox dashBtcUP;
        private System.Windows.Forms.PictureBox dashBtcDOWN;
        private System.Windows.Forms.Timer timerBtcPrice;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox ConnectionGood;
        private System.Windows.Forms.PictureBox ConnectionLow;
        private System.Windows.Forms.PictureBox ConnectionBad;
    }
}


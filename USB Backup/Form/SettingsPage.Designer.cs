namespace USB_Backup {
    partial class SettingsPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.Reset = new System.Windows.Forms.Button();
            this.SavingPanel = new System.Windows.Forms.Panel();
            this.Choose = new System.Windows.Forms.Button();
            this.Overwrite = new Bunifu.Framework.UI.BunifuSwitch();
            this.label11 = new System.Windows.Forms.Label();
            this.Path = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.CompressPanel = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.TextBox();
            this.Compress = new Bunifu.Framework.UI.BunifuSwitch();
            this.PasswordShow = new Bunifu.Framework.UI.BunifuSwitch();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LimitOn = new Bunifu.Framework.UI.BunifuSwitch();
            this.Limit = new System.Windows.Forms.NumericUpDown();
            this.Auto = new Bunifu.Framework.UI.BunifuSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Startup = new Bunifu.Framework.UI.BunifuSwitch();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.CloseApp = new System.Windows.Forms.Button();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SavingPanel.SuspendLayout();
            this.CompressPanel.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Limit)).BeginInit();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.Reset.Cursor = System.Windows.Forms.Cursors.Default;
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.White;
            this.Reset.Location = new System.Drawing.Point(12, 311);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(102, 31);
            this.Reset.TabIndex = 38;
            this.Reset.Text = "Reset To Default";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // SavingPanel
            // 
            this.SavingPanel.Controls.Add(this.Choose);
            this.SavingPanel.Controls.Add(this.Overwrite);
            this.SavingPanel.Controls.Add(this.label11);
            this.SavingPanel.Controls.Add(this.Path);
            this.SavingPanel.Controls.Add(this.label10);
            this.SavingPanel.Location = new System.Drawing.Point(12, 256);
            this.SavingPanel.Name = "SavingPanel";
            this.SavingPanel.Size = new System.Drawing.Size(300, 49);
            this.SavingPanel.TabIndex = 37;
            // 
            // Choose
            // 
            this.Choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.Choose.FlatAppearance.BorderSize = 0;
            this.Choose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.Choose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.Choose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choose.ForeColor = System.Drawing.Color.White;
            this.Choose.Location = new System.Drawing.Point(230, 28);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(62, 21);
            this.Choose.TabIndex = 28;
            this.Choose.Text = "Choose...";
            this.Choose.UseVisualStyleBackColor = false;
            // 
            // Overwrite
            // 
            this.Overwrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Overwrite.BorderRadius = 0;
            this.Overwrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Overwrite.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::USB_Backup.Properties.Settings.Default, "Overwrite", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Overwrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Overwrite.Location = new System.Drawing.Point(4, 28);
            this.Overwrite.Name = "Overwrite";
            this.Overwrite.Oncolor = System.Drawing.Color.SeaGreen;
            this.Overwrite.Onoffcolor = System.Drawing.Color.DarkGray;
            this.Overwrite.Size = new System.Drawing.Size(51, 19);
            this.Overwrite.TabIndex = 23;
            this.Overwrite.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Overwrite.Value = global::USB_Backup.Properties.Settings.Default.Overwrite;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.label11.Location = new System.Drawing.Point(61, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Overwrite Everytime";
            // 
            // Path
            // 
            this.Path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Path.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::USB_Backup.Properties.Settings.Default, "Path", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Path.Location = new System.Drawing.Point(79, 2);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(213, 20);
            this.Path.TabIndex = 22;
            this.Path.Text = global::USB_Backup.Properties.Settings.Default.Path;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.label10.Location = new System.Drawing.Point(3, 2);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Save Path";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.label13.Location = new System.Drawing.Point(12, 225);
            this.label13.Margin = new System.Windows.Forms.Padding(10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 21);
            this.label13.TabIndex = 36;
            this.label13.Text = "Saving";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.panel7.Location = new System.Drawing.Point(12, 249);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 1);
            this.panel7.TabIndex = 35;
            // 
            // CompressPanel
            // 
            this.CompressPanel.Controls.Add(this.Password);
            this.CompressPanel.Controls.Add(this.Compress);
            this.CompressPanel.Controls.Add(this.PasswordShow);
            this.CompressPanel.Controls.Add(this.label9);
            this.CompressPanel.Controls.Add(this.label8);
            this.CompressPanel.Controls.Add(this.label7);
            this.CompressPanel.Location = new System.Drawing.Point(12, 165);
            this.CompressPanel.Name = "CompressPanel";
            this.CompressPanel.Size = new System.Drawing.Size(300, 47);
            this.CompressPanel.TabIndex = 34;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Password.Location = new System.Drawing.Point(83, 27);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.Size = new System.Drawing.Size(209, 20);
            this.Password.TabIndex = 29;
            // 
            // Compress
            // 
            this.Compress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Compress.BorderRadius = 0;
            this.Compress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Compress.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::USB_Backup.Properties.Settings.Default, "Compress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Compress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Compress.Location = new System.Drawing.Point(6, 0);
            this.Compress.Name = "Compress";
            this.Compress.Oncolor = System.Drawing.Color.SeaGreen;
            this.Compress.Onoffcolor = System.Drawing.Color.DarkGray;
            this.Compress.Size = new System.Drawing.Size(51, 19);
            this.Compress.TabIndex = 17;
            this.Compress.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Compress.Value = global::USB_Backup.Properties.Settings.Default.Compress;
            // 
            // PasswordShow
            // 
            this.PasswordShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasswordShow.BorderRadius = 0;
            this.PasswordShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasswordShow.Location = new System.Drawing.Point(142, 0);
            this.PasswordShow.Name = "PasswordShow";
            this.PasswordShow.Oncolor = System.Drawing.Color.SeaGreen;
            this.PasswordShow.Onoffcolor = System.Drawing.Color.DarkGray;
            this.PasswordShow.Size = new System.Drawing.Size(51, 19);
            this.PasswordShow.TabIndex = 19;
            this.PasswordShow.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasswordShow.Value = false;
            this.PasswordShow.Click += new System.EventHandler(this.PasswordShow_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.label9.Location = new System.Drawing.Point(9, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.label8.Location = new System.Drawing.Point(195, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Show Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.label7.Location = new System.Drawing.Point(63, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Compress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.label6.Location = new System.Drawing.Point(12, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "Compress";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.panel4.Location = new System.Drawing.Point(12, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 1);
            this.panel4.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "General";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.panel3.Location = new System.Drawing.Point(12, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 1);
            this.panel3.TabIndex = 30;
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Controls.Add(this.panel1);
            this.GeneralPanel.Controls.Add(this.LimitOn);
            this.GeneralPanel.Controls.Add(this.Limit);
            this.GeneralPanel.Controls.Add(this.Auto);
            this.GeneralPanel.Controls.Add(this.label2);
            this.GeneralPanel.Controls.Add(this.label1);
            this.GeneralPanel.Controls.Add(this.label3);
            this.GeneralPanel.Controls.Add(this.Startup);
            this.GeneralPanel.Location = new System.Drawing.Point(12, 75);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(300, 46);
            this.GeneralPanel.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(190, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(31, 19);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.label4.Location = new System.Drawing.Point(3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "MB";
            // 
            // LimitOn
            // 
            this.LimitOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LimitOn.BorderRadius = 0;
            this.LimitOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LimitOn.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::USB_Backup.Properties.Settings.Default, "LimitOn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LimitOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LimitOn.Location = new System.Drawing.Point(6, 26);
            this.LimitOn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.LimitOn.Name = "LimitOn";
            this.LimitOn.Oncolor = System.Drawing.Color.SeaGreen;
            this.LimitOn.Onoffcolor = System.Drawing.Color.DarkGray;
            this.LimitOn.Size = new System.Drawing.Size(51, 19);
            this.LimitOn.TabIndex = 5;
            this.LimitOn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LimitOn.Value = global::USB_Backup.Properties.Settings.Default.LimitOn;
            this.LimitOn.Click += new System.EventHandler(this.LimitOn_Click);
            // 
            // Limit
            // 
            this.Limit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Limit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Limit.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::USB_Backup.Properties.Settings.Default, "Limit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Limit.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::USB_Backup.Properties.Settings.Default, "LimitOn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Limit.Enabled = global::USB_Backup.Properties.Settings.Default.LimitOn;
            this.Limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Limit.Location = new System.Drawing.Point(134, 26);
            this.Limit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Limit.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.Limit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Limit.Name = "Limit";
            this.Limit.Size = new System.Drawing.Size(73, 17);
            this.Limit.TabIndex = 9;
            this.Limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Limit.ThousandsSeparator = true;
            this.Limit.Value = global::USB_Backup.Properties.Settings.Default.Limit;
            // 
            // Auto
            // 
            this.Auto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Auto.BorderRadius = 0;
            this.Auto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Auto.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::USB_Backup.Properties.Settings.Default, "Auto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Auto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Auto.Location = new System.Drawing.Point(6, -1);
            this.Auto.Name = "Auto";
            this.Auto.Oncolor = System.Drawing.Color.SeaGreen;
            this.Auto.Onoffcolor = System.Drawing.Color.DarkGray;
            this.Auto.Size = new System.Drawing.Size(51, 19);
            this.Auto.TabIndex = 3;
            this.Auto.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Auto.Value = global::USB_Backup.Properties.Settings.Default.Auto;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.label2.Location = new System.Drawing.Point(64, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Size Limit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(63, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Auto Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.label3.Location = new System.Drawing.Point(195, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Run On Startup";
            // 
            // Startup
            // 
            this.Startup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Startup.BorderRadius = 0;
            this.Startup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Startup.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::USB_Backup.Properties.Settings.Default, "Startup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Startup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Startup.Location = new System.Drawing.Point(142, -1);
            this.Startup.Name = "Startup";
            this.Startup.Oncolor = System.Drawing.Color.SeaGreen;
            this.Startup.Onoffcolor = System.Drawing.Color.DarkGray;
            this.Startup.Size = new System.Drawing.Size(51, 19);
            this.Startup.TabIndex = 7;
            this.Startup.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Startup.Value = global::USB_Backup.Properties.Settings.Default.Startup;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.PanelTop.Controls.Add(this.Title);
            this.PanelTop.Controls.Add(this.CloseApp);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(325, 32);
            this.PanelTop.TabIndex = 28;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Title.Location = new System.Drawing.Point(9, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(57, 16);
            this.Title.TabIndex = 3;
            this.Title.Text = "Settings";
            // 
            // CloseApp
            // 
            this.CloseApp.FlatAppearance.BorderSize = 0;
            this.CloseApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.CloseApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApp.Font = new System.Drawing.Font("Microsoft JhengHei", 9.25F);
            this.CloseApp.ForeColor = System.Drawing.Color.White;
            this.CloseApp.Location = new System.Drawing.Point(274, 0);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(51, 32);
            this.CloseApp.TabIndex = 0;
            this.CloseApp.Text = "✕";
            this.CloseApp.UseVisualStyleBackColor = true;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.PanelTop;
            this.DragControl.Vertical = true;
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(325, 356);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.SavingPanel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.CompressPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.GeneralPanel);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsPage";
            this.Text = "SettingsPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsPage_FormClosing);
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.Click += new System.EventHandler(this.SettingsPage_Click);
            this.SavingPanel.ResumeLayout(false);
            this.SavingPanel.PerformLayout();
            this.CompressPanel.ResumeLayout(false);
            this.CompressPanel.PerformLayout();
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Limit)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Panel SavingPanel;
        private System.Windows.Forms.Button Choose;
        private Bunifu.Framework.UI.BunifuSwitch Overwrite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel CompressPanel;
        private System.Windows.Forms.TextBox Password;
        private Bunifu.Framework.UI.BunifuSwitch Compress;
        private Bunifu.Framework.UI.BunifuSwitch PasswordShow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuSwitch LimitOn;
        private System.Windows.Forms.NumericUpDown Limit;
        private Bunifu.Framework.UI.BunifuSwitch Auto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuSwitch Startup;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button CloseApp;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
    }
}
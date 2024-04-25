﻿namespace auto_brightness_and_vibrance
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.forceApplyButton = new System.Windows.Forms.Button();
            this.presetsBox = new System.Windows.Forms.GroupBox();
            this.profile2GammaText = new System.Windows.Forms.TextBox();
            this.profile2ContrastText = new System.Windows.Forms.TextBox();
            this.profile2BrightnessText = new System.Windows.Forms.TextBox();
            this.profile1GammaText = new System.Windows.Forms.TextBox();
            this.profile1ContrastText = new System.Windows.Forms.TextBox();
            this.profile1BrightnessText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.minimizeStartCheckBox = new System.Windows.Forms.CheckBox();
            this.DisplayCombo = new System.Windows.Forms.ComboBox();
            this.DVLGroupBox = new System.Windows.Forms.GroupBox();
            this.DVLPanel = new System.Windows.Forms.Panel();
            this.DVLLabel = new System.Windows.Forms.Label();
            this.DVLBar = new System.Windows.Forms.TrackBar();
            this.DVLText = new System.Windows.Forms.TextBox();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.colorTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.brightnessPanel = new System.Windows.Forms.Panel();
            this.BrightnessBar = new System.Windows.Forms.TrackBar();
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.BrightnessText = new System.Windows.Forms.TextBox();
            this.contrastPanel = new System.Windows.Forms.Panel();
            this.ContrastBar = new System.Windows.Forms.TrackBar();
            this.ContrastText = new System.Windows.Forms.TextBox();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.gammaPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GammaText = new System.Windows.Forms.TextBox();
            this.GammaBar = new System.Windows.Forms.TrackBar();
            this.GammaLabel = new System.Windows.Forms.Label();
            this.layoutTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.trayMenuStrip.SuspendLayout();
            this.ColorPanel.SuspendLayout();
            this.presetsBox.SuspendLayout();
            this.DVLGroupBox.SuspendLayout();
            this.DVLPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVLBar)).BeginInit();
            this.colorGroupBox.SuspendLayout();
            this.colorTablePanel.SuspendLayout();
            this.brightnessPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).BeginInit();
            this.contrastPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastBar)).BeginInit();
            this.gammaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GammaBar)).BeginInit();
            this.layoutTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenuStrip;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Auto Brightness and Vibrance";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.ShowForm);
            // 
            // trayMenuStrip
            // 
            this.trayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.trayMenuStrip.Name = "trayMenuStrip";
            this.trayMenuStrip.Size = new System.Drawing.Size(110, 70);
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Checked = true;
            this.enableToolStripMenuItem.CheckOnClick = true;
            this.enableToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.ShowForm);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitFormClicked);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.Color.White;
            this.ColorPanel.Controls.Add(this.forceApplyButton);
            this.ColorPanel.Controls.Add(this.presetsBox);
            this.ColorPanel.Controls.Add(this.minimizeStartCheckBox);
            this.ColorPanel.Controls.Add(this.DisplayCombo);
            this.ColorPanel.Controls.Add(this.DVLGroupBox);
            this.ColorPanel.Controls.Add(this.colorGroupBox);
            this.ColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorPanel.Location = new System.Drawing.Point(3, 3);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(824, 361);
            this.ColorPanel.TabIndex = 2;
            // 
            // forceApplyButton
            // 
            this.forceApplyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.forceApplyButton.Location = new System.Drawing.Point(3, 322);
            this.forceApplyButton.Name = "forceApplyButton";
            this.forceApplyButton.Size = new System.Drawing.Size(217, 33);
            this.forceApplyButton.TabIndex = 21;
            this.forceApplyButton.Text = "Manual Apply (ALT+Num0)";
            this.forceApplyButton.UseVisualStyleBackColor = true;
            this.forceApplyButton.Click += new System.EventHandler(this.forceApplyButton_Click);
            // 
            // presetsBox
            // 
            this.presetsBox.Controls.Add(this.profile2GammaText);
            this.presetsBox.Controls.Add(this.profile2ContrastText);
            this.presetsBox.Controls.Add(this.profile2BrightnessText);
            this.presetsBox.Controls.Add(this.profile1GammaText);
            this.presetsBox.Controls.Add(this.profile1ContrastText);
            this.presetsBox.Controls.Add(this.profile1BrightnessText);
            this.presetsBox.Controls.Add(this.button1);
            this.presetsBox.Controls.Add(this.button3);
            this.presetsBox.Controls.Add(this.button2);
            this.presetsBox.Location = new System.Drawing.Point(650, 9);
            this.presetsBox.Name = "presetsBox";
            this.presetsBox.Size = new System.Drawing.Size(172, 307);
            this.presetsBox.TabIndex = 20;
            this.presetsBox.TabStop = false;
            this.presetsBox.Text = "Presets";
            // 
            // profile2GammaText
            // 
            this.profile2GammaText.Location = new System.Drawing.Point(124, 173);
            this.profile2GammaText.Name = "profile2GammaText";
            this.profile2GammaText.Size = new System.Drawing.Size(33, 22);
            this.profile2GammaText.TabIndex = 25;
            this.profile2GammaText.Text = "130";
            // 
            // profile2ContrastText
            // 
            this.profile2ContrastText.Location = new System.Drawing.Point(124, 145);
            this.profile2ContrastText.Name = "profile2ContrastText";
            this.profile2ContrastText.Size = new System.Drawing.Size(33, 22);
            this.profile2ContrastText.TabIndex = 24;
            this.profile2ContrastText.Text = "80";
            // 
            // profile2BrightnessText
            // 
            this.profile2BrightnessText.Location = new System.Drawing.Point(124, 117);
            this.profile2BrightnessText.Name = "profile2BrightnessText";
            this.profile2BrightnessText.Size = new System.Drawing.Size(33, 22);
            this.profile2BrightnessText.TabIndex = 23;
            this.profile2BrightnessText.Text = "50";
            // 
            // profile1GammaText
            // 
            this.profile1GammaText.Location = new System.Drawing.Point(124, 78);
            this.profile1GammaText.Name = "profile1GammaText";
            this.profile1GammaText.Size = new System.Drawing.Size(33, 22);
            this.profile1GammaText.TabIndex = 22;
            this.profile1GammaText.Text = "130";
            // 
            // profile1ContrastText
            // 
            this.profile1ContrastText.Location = new System.Drawing.Point(124, 50);
            this.profile1ContrastText.Name = "profile1ContrastText";
            this.profile1ContrastText.Size = new System.Drawing.Size(33, 22);
            this.profile1ContrastText.TabIndex = 21;
            this.profile1ContrastText.Text = "65";
            // 
            // profile1BrightnessText
            // 
            this.profile1BrightnessText.Location = new System.Drawing.Point(124, 22);
            this.profile1BrightnessText.Name = "profile1BrightnessText";
            this.profile1BrightnessText.Size = new System.Drawing.Size(33, 22);
            this.profile1BrightnessText.TabIndex = 20;
            this.profile1BrightnessText.Text = "50";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(18, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 80);
            this.button1.TabIndex = 17;
            this.button1.Text = "Profile 1\r\nAlt+Num1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Profile1ButtonClick);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(18, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 80);
            this.button3.TabIndex = 19;
            this.button3.Text = "DEFAULT\r\nAlt+Num3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DefaultValuesButtonClick);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(18, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 80);
            this.button2.TabIndex = 18;
            this.button2.Text = "Profile 2\r\nAlt+Num2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Profile2ButtonClick);
            // 
            // minimizeStartCheckBox
            // 
            this.minimizeStartCheckBox.AutoSize = true;
            this.minimizeStartCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.minimizeStartCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minimizeStartCheckBox.Location = new System.Drawing.Point(443, 330);
            this.minimizeStartCheckBox.Name = "minimizeStartCheckBox";
            this.minimizeStartCheckBox.Size = new System.Drawing.Size(201, 18);
            this.minimizeStartCheckBox.TabIndex = 16;
            this.minimizeStartCheckBox.Text = "Minimize to Tray on Start";
            this.minimizeStartCheckBox.UseVisualStyleBackColor = false;
            this.minimizeStartCheckBox.CheckedChanged += new System.EventHandler(this.CheckOnMinimizeToTray);
            // 
            // DisplayCombo
            // 
            this.DisplayCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DisplayCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DisplayCombo.FormattingEnabled = true;
            this.DisplayCombo.Location = new System.Drawing.Point(650, 328);
            this.DisplayCombo.Name = "DisplayCombo";
            this.DisplayCombo.Size = new System.Drawing.Size(172, 22);
            this.DisplayCombo.TabIndex = 15;
            this.DisplayCombo.SelectedValueChanged += new System.EventHandler(this.DisplayCombo_SelectedValueChanged);
            // 
            // DVLGroupBox
            // 
            this.DVLGroupBox.Controls.Add(this.DVLPanel);
            this.DVLGroupBox.Location = new System.Drawing.Point(499, 9);
            this.DVLGroupBox.Name = "DVLGroupBox";
            this.DVLGroupBox.Size = new System.Drawing.Size(145, 307);
            this.DVLGroupBox.TabIndex = 13;
            this.DVLGroupBox.TabStop = false;
            this.DVLGroupBox.Text = "DVL";
            // 
            // DVLPanel
            // 
            this.DVLPanel.Controls.Add(this.DVLLabel);
            this.DVLPanel.Controls.Add(this.DVLBar);
            this.DVLPanel.Controls.Add(this.DVLText);
            this.DVLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVLPanel.Location = new System.Drawing.Point(3, 18);
            this.DVLPanel.Name = "DVLPanel";
            this.DVLPanel.Size = new System.Drawing.Size(139, 286);
            this.DVLPanel.TabIndex = 0;
            // 
            // DVLLabel
            // 
            this.DVLLabel.AutoSize = true;
            this.DVLLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DVLLabel.Location = new System.Drawing.Point(13, 11);
            this.DVLLabel.Name = "DVLLabel";
            this.DVLLabel.Size = new System.Drawing.Size(119, 28);
            this.DVLLabel.TabIndex = 10;
            this.DVLLabel.Text = "Digital Vibrance\r\n(Saturation)\r\n";
            this.DVLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DVLLabel.DoubleClick += new System.EventHandler(this.ColorLabel_DClick);
            // 
            // DVLBar
            // 
            this.DVLBar.Location = new System.Drawing.Point(56, 42);
            this.DVLBar.Maximum = 63;
            this.DVLBar.Name = "DVLBar";
            this.DVLBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.DVLBar.Size = new System.Drawing.Size(45, 184);
            this.DVLBar.TabIndex = 9;
            this.DVLBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.DVLBar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // DVLText
            // 
            this.DVLText.Location = new System.Drawing.Point(46, 232);
            this.DVLText.Name = "DVLText";
            this.DVLText.ReadOnly = true;
            this.DVLText.Size = new System.Drawing.Size(41, 22);
            this.DVLText.TabIndex = 11;
            this.DVLText.Text = "0";
            this.DVLText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.colorTablePanel);
            this.colorGroupBox.Location = new System.Drawing.Point(3, 9);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(490, 307);
            this.colorGroupBox.TabIndex = 12;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            // 
            // colorTablePanel
            // 
            this.colorTablePanel.ColumnCount = 1;
            this.colorTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.colorTablePanel.Controls.Add(this.brightnessPanel, 0, 0);
            this.colorTablePanel.Controls.Add(this.contrastPanel, 0, 1);
            this.colorTablePanel.Controls.Add(this.gammaPanel, 0, 2);
            this.colorTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorTablePanel.Location = new System.Drawing.Point(3, 18);
            this.colorTablePanel.Name = "colorTablePanel";
            this.colorTablePanel.RowCount = 3;
            this.colorTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.colorTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.colorTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.colorTablePanel.Size = new System.Drawing.Size(484, 286);
            this.colorTablePanel.TabIndex = 1;
            // 
            // brightnessPanel
            // 
            this.brightnessPanel.Controls.Add(this.BrightnessBar);
            this.brightnessPanel.Controls.Add(this.BrightnessLabel);
            this.brightnessPanel.Controls.Add(this.BrightnessText);
            this.brightnessPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brightnessPanel.Location = new System.Drawing.Point(3, 3);
            this.brightnessPanel.Name = "brightnessPanel";
            this.brightnessPanel.Size = new System.Drawing.Size(478, 89);
            this.brightnessPanel.TabIndex = 0;
            // 
            // BrightnessBar
            // 
            this.BrightnessBar.Location = new System.Drawing.Point(13, 27);
            this.BrightnessBar.Maximum = 100;
            this.BrightnessBar.Name = "BrightnessBar";
            this.BrightnessBar.Size = new System.Drawing.Size(397, 45);
            this.BrightnessBar.TabIndex = 18;
            this.BrightnessBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BrightnessBar.Value = 50;
            this.BrightnessBar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BrightnessLabel.Location = new System.Drawing.Point(20, 10);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(77, 14);
            this.BrightnessLabel.TabIndex = 21;
            this.BrightnessLabel.Text = "Brightness";
            this.BrightnessLabel.DoubleClick += new System.EventHandler(this.ColorLabel_DClick);
            // 
            // BrightnessText
            // 
            this.BrightnessText.Location = new System.Drawing.Point(424, 27);
            this.BrightnessText.Name = "BrightnessText";
            this.BrightnessText.ReadOnly = true;
            this.BrightnessText.Size = new System.Drawing.Size(41, 22);
            this.BrightnessText.TabIndex = 24;
            this.BrightnessText.Text = "0.50";
            this.BrightnessText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contrastPanel
            // 
            this.contrastPanel.Controls.Add(this.ContrastBar);
            this.contrastPanel.Controls.Add(this.ContrastText);
            this.contrastPanel.Controls.Add(this.ContrastLabel);
            this.contrastPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contrastPanel.Location = new System.Drawing.Point(3, 98);
            this.contrastPanel.Name = "contrastPanel";
            this.contrastPanel.Size = new System.Drawing.Size(478, 89);
            this.contrastPanel.TabIndex = 1;
            // 
            // ContrastBar
            // 
            this.ContrastBar.Location = new System.Drawing.Point(13, 39);
            this.ContrastBar.Maximum = 100;
            this.ContrastBar.Name = "ContrastBar";
            this.ContrastBar.Size = new System.Drawing.Size(397, 45);
            this.ContrastBar.TabIndex = 19;
            this.ContrastBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ContrastBar.Value = 50;
            this.ContrastBar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // ContrastText
            // 
            this.ContrastText.Location = new System.Drawing.Point(424, 39);
            this.ContrastText.Name = "ContrastText";
            this.ContrastText.ReadOnly = true;
            this.ContrastText.Size = new System.Drawing.Size(41, 22);
            this.ContrastText.TabIndex = 25;
            this.ContrastText.Text = "0.50";
            this.ContrastText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ContrastLabel.Location = new System.Drawing.Point(20, 22);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(63, 14);
            this.ContrastLabel.TabIndex = 22;
            this.ContrastLabel.Text = "Contrast";
            this.ContrastLabel.DoubleClick += new System.EventHandler(this.ColorLabel_DClick);
            // 
            // gammaPanel
            // 
            this.gammaPanel.Controls.Add(this.label3);
            this.gammaPanel.Controls.Add(this.label2);
            this.gammaPanel.Controls.Add(this.label1);
            this.gammaPanel.Controls.Add(this.GammaText);
            this.gammaPanel.Controls.Add(this.GammaBar);
            this.gammaPanel.Controls.Add(this.GammaLabel);
            this.gammaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gammaPanel.Location = new System.Drawing.Point(3, 193);
            this.gammaPanel.Name = "gammaPanel";
            this.gammaPanel.Size = new System.Drawing.Size(478, 90);
            this.gammaPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(329, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "+10 alt+up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 28;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "-10 alt+down";
            // 
            // GammaText
            // 
            this.GammaText.Location = new System.Drawing.Point(424, 40);
            this.GammaText.Name = "GammaText";
            this.GammaText.ReadOnly = true;
            this.GammaText.Size = new System.Drawing.Size(41, 22);
            this.GammaText.TabIndex = 26;
            this.GammaText.Text = "1.00";
            this.GammaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GammaBar
            // 
            this.GammaBar.Location = new System.Drawing.Point(13, 40);
            this.GammaBar.Maximum = 280;
            this.GammaBar.Minimum = 40;
            this.GammaBar.Name = "GammaBar";
            this.GammaBar.Size = new System.Drawing.Size(397, 45);
            this.GammaBar.TabIndex = 20;
            this.GammaBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GammaBar.Value = 100;
            this.GammaBar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // GammaLabel
            // 
            this.GammaLabel.AutoSize = true;
            this.GammaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GammaLabel.Location = new System.Drawing.Point(20, 23);
            this.GammaLabel.Name = "GammaLabel";
            this.GammaLabel.Size = new System.Drawing.Size(42, 14);
            this.GammaLabel.TabIndex = 23;
            this.GammaLabel.Text = "Gamma";
            this.GammaLabel.DoubleClick += new System.EventHandler(this.ColorLabel_DClick);
            // 
            // layoutTablePanel
            // 
            this.layoutTablePanel.ColumnCount = 1;
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTablePanel.Controls.Add(this.ColorPanel, 0, 0);
            this.layoutTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTablePanel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutTablePanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.layoutTablePanel.Location = new System.Drawing.Point(0, 0);
            this.layoutTablePanel.Name = "layoutTablePanel";
            this.layoutTablePanel.RowCount = 1;
            this.layoutTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTablePanel.Size = new System.Drawing.Size(830, 367);
            this.layoutTablePanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 367);
            this.Controls.Add(this.layoutTablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Auto Brightness and Vibrance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.trayMenuStrip.ResumeLayout(false);
            this.ColorPanel.ResumeLayout(false);
            this.ColorPanel.PerformLayout();
            this.presetsBox.ResumeLayout(false);
            this.presetsBox.PerformLayout();
            this.DVLGroupBox.ResumeLayout(false);
            this.DVLPanel.ResumeLayout(false);
            this.DVLPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVLBar)).EndInit();
            this.colorGroupBox.ResumeLayout(false);
            this.colorTablePanel.ResumeLayout(false);
            this.brightnessPanel.ResumeLayout(false);
            this.brightnessPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).EndInit();
            this.contrastPanel.ResumeLayout(false);
            this.contrastPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastBar)).EndInit();
            this.gammaPanel.ResumeLayout(false);
            this.gammaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GammaBar)).EndInit();
            this.layoutTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Button forceApplyButton;
        private System.Windows.Forms.GroupBox presetsBox;
        private System.Windows.Forms.TextBox profile2GammaText;
        private System.Windows.Forms.TextBox profile2ContrastText;
        private System.Windows.Forms.TextBox profile2BrightnessText;
        private System.Windows.Forms.TextBox profile1GammaText;
        private System.Windows.Forms.TextBox profile1ContrastText;
        private System.Windows.Forms.TextBox profile1BrightnessText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox minimizeStartCheckBox;
        private System.Windows.Forms.ComboBox DisplayCombo;
        private System.Windows.Forms.GroupBox DVLGroupBox;
        private System.Windows.Forms.Panel DVLPanel;
        private System.Windows.Forms.Label DVLLabel;
        private System.Windows.Forms.TrackBar DVLBar;
        private System.Windows.Forms.TextBox DVLText;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.TableLayoutPanel colorTablePanel;
        private System.Windows.Forms.Panel brightnessPanel;
        private System.Windows.Forms.TrackBar BrightnessBar;
        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.TextBox BrightnessText;
        private System.Windows.Forms.Panel contrastPanel;
        private System.Windows.Forms.TrackBar ContrastBar;
        private System.Windows.Forms.TextBox ContrastText;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.Panel gammaPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GammaText;
        private System.Windows.Forms.TrackBar GammaBar;
        private System.Windows.Forms.Label GammaLabel;
        private System.Windows.Forms.TableLayoutPanel layoutTablePanel;
    }
}

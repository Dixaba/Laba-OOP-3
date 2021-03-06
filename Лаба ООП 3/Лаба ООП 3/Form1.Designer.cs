﻿namespace Лаба_ООП_3
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ExportStat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Modeling = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_ModelSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_AllStat = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_RealTimeModel = new System.Windows.Forms.GroupBox();
            this.listBox_ModelStations = new System.Windows.Forms.ListBox();
            this.toolStrip_MainTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_pause = new System.Windows.Forms.ToolStripButton();
            this.groupBox_ModelingProperties = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton_Slow = new System.Windows.Forms.RadioButton();
            this.radioButton_Fast = new System.Windows.Forms.RadioButton();
            this.Settings = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModelTimer = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip_Main.SuspendLayout();
            this.statusStrip_AllStat.SuspendLayout();
            this.groupBox_RealTimeModel.SuspendLayout();
            this.toolStrip_MainTools.SuspendLayout();
            this.groupBox_ModelingProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_File,
            this.toolStripMenuItem_Modeling});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip_Main.Size = new System.Drawing.Size(746, 28);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "Главное меню";
            // 
            // toolStripMenuItem_File
            // 
            this.toolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_ExportStat});
            this.toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            this.toolStripMenuItem_File.Size = new System.Drawing.Size(57, 24);
            this.toolStripMenuItem_File.Text = "Файл";
            // 
            // toolStripMenuItem_ExportStat
            // 
            this.toolStripMenuItem_ExportStat.Enabled = false;
            this.toolStripMenuItem_ExportStat.Name = "toolStripMenuItem_ExportStat";
            this.toolStripMenuItem_ExportStat.Size = new System.Drawing.Size(228, 24);
            this.toolStripMenuItem_ExportStat.Text = "Сохранить статистику";
            this.toolStripMenuItem_ExportStat.Click += new System.EventHandler(this.toolStripMenuItem_ExportStat_Click);
            // 
            // toolStripMenuItem_Modeling
            // 
            this.toolStripMenuItem_Modeling.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Start,
            this.toolStripMenuItem_Stop,
            this.toolStripSeparator2,
            this.toolStripMenuItem_ModelSettings});
            this.toolStripMenuItem_Modeling.Name = "toolStripMenuItem_Modeling";
            this.toolStripMenuItem_Modeling.Size = new System.Drawing.Size(136, 24);
            this.toolStripMenuItem_Modeling.Text = "Моделирование";
            // 
            // toolStripMenuItem_Start
            // 
            this.toolStripMenuItem_Start.Enabled = false;
            this.toolStripMenuItem_Start.Name = "toolStripMenuItem_Start";
            this.toolStripMenuItem_Start.Size = new System.Drawing.Size(268, 24);
            this.toolStripMenuItem_Start.Text = "Начать";
            this.toolStripMenuItem_Start.Click += new System.EventHandler(this.toolStripButton_Start_Click);
            // 
            // toolStripMenuItem_Stop
            // 
            this.toolStripMenuItem_Stop.Enabled = false;
            this.toolStripMenuItem_Stop.Name = "toolStripMenuItem_Stop";
            this.toolStripMenuItem_Stop.Size = new System.Drawing.Size(268, 24);
            this.toolStripMenuItem_Stop.Text = "Остановить";
            this.toolStripMenuItem_Stop.Click += new System.EventHandler(this.toolStripButton_Stop_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(265, 6);
            // 
            // toolStripMenuItem_ModelSettings
            // 
            this.toolStripMenuItem_ModelSettings.Name = "toolStripMenuItem_ModelSettings";
            this.toolStripMenuItem_ModelSettings.Size = new System.Drawing.Size(268, 24);
            this.toolStripMenuItem_ModelSettings.Text = "Настроить моделирование";
            this.toolStripMenuItem_ModelSettings.Click += new System.EventHandler(this.toolStripMenuItem_ModelSettings_Click);
            // 
            // statusStrip_AllStat
            // 
            this.statusStrip_AllStat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip_AllStat.Location = new System.Drawing.Point(0, 531);
            this.statusStrip_AllStat.Name = "statusStrip_AllStat";
            this.statusStrip_AllStat.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.statusStrip_AllStat.Size = new System.Drawing.Size(746, 35);
            this.statusStrip_AllStat.TabIndex = 1;
            this.statusStrip_AllStat.Text = "Статус исполнения";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Maximum = 1439;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(166, 29);
            this.toolStripProgressBar1.Step = 1;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 30);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 30);
            // 
            // groupBox_RealTimeModel
            // 
            this.groupBox_RealTimeModel.Controls.Add(this.listBox_ModelStations);
            this.groupBox_RealTimeModel.Location = new System.Drawing.Point(15, 71);
            this.groupBox_RealTimeModel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox_RealTimeModel.Name = "groupBox_RealTimeModel";
            this.groupBox_RealTimeModel.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox_RealTimeModel.Size = new System.Drawing.Size(395, 458);
            this.groupBox_RealTimeModel.TabIndex = 2;
            this.groupBox_RealTimeModel.TabStop = false;
            this.groupBox_RealTimeModel.Text = "Модель в реальном времени";
            // 
            // listBox_ModelStations
            // 
            this.listBox_ModelStations.FormattingEnabled = true;
            this.listBox_ModelStations.ItemHeight = 16;
            this.listBox_ModelStations.Location = new System.Drawing.Point(6, 21);
            this.listBox_ModelStations.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.listBox_ModelStations.Name = "listBox_ModelStations";
            this.listBox_ModelStations.Size = new System.Drawing.Size(382, 388);
            this.listBox_ModelStations.TabIndex = 0;
            // 
            // toolStrip_MainTools
            // 
            this.toolStrip_MainTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Start,
            this.toolStripButton_Stop,
            this.toolStripSeparator1,
            this.toolStripButton_pause});
            this.toolStrip_MainTools.Location = new System.Drawing.Point(0, 28);
            this.toolStrip_MainTools.Name = "toolStrip_MainTools";
            this.toolStrip_MainTools.Size = new System.Drawing.Size(746, 25);
            this.toolStrip_MainTools.TabIndex = 3;
            this.toolStrip_MainTools.Text = "Инструменты";
            // 
            // toolStripButton_Start
            // 
            this.toolStripButton_Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Start.Enabled = false;
            this.toolStripButton_Start.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Start.Image")));
            this.toolStripButton_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Start.Name = "toolStripButton_Start";
            this.toolStripButton_Start.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Start.Text = "Начать моделирование";
            this.toolStripButton_Start.Click += new System.EventHandler(this.toolStripButton_Start_Click);
            // 
            // toolStripButton_Stop
            // 
            this.toolStripButton_Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Stop.Enabled = false;
            this.toolStripButton_Stop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Stop.Image")));
            this.toolStripButton_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Stop.Name = "toolStripButton_Stop";
            this.toolStripButton_Stop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Stop.Text = "Остановить моделирование";
            this.toolStripButton_Stop.Click += new System.EventHandler(this.toolStripButton_Stop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_pause
            // 
            this.toolStripButton_pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_pause.Enabled = false;
            this.toolStripButton_pause.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_pause.Image")));
            this.toolStripButton_pause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_pause.Name = "toolStripButton_pause";
            this.toolStripButton_pause.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_pause.Text = "Пауза";
            this.toolStripButton_pause.Click += new System.EventHandler(this.toolStripButton_pause_Click);
            // 
            // groupBox_ModelingProperties
            // 
            this.groupBox_ModelingProperties.Controls.Add(this.label1);
            this.groupBox_ModelingProperties.Controls.Add(this.pictureBox1);
            this.groupBox_ModelingProperties.Controls.Add(this.radioButton_Slow);
            this.groupBox_ModelingProperties.Controls.Add(this.radioButton_Fast);
            this.groupBox_ModelingProperties.Controls.Add(this.Settings);
            this.groupBox_ModelingProperties.Location = new System.Drawing.Point(419, 71);
            this.groupBox_ModelingProperties.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.groupBox_ModelingProperties.Name = "groupBox_ModelingProperties";
            this.groupBox_ModelingProperties.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.groupBox_ModelingProperties.Size = new System.Drawing.Size(322, 458);
            this.groupBox_ModelingProperties.TabIndex = 4;
            this.groupBox_ModelingProperties.TabStop = false;
            this.groupBox_ModelingProperties.Text = "Настройки данного моделирования";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 301);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 125);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton_Slow
            // 
            this.radioButton_Slow.AutoSize = true;
            this.radioButton_Slow.Location = new System.Drawing.Point(9, 274);
            this.radioButton_Slow.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_Slow.Name = "radioButton_Slow";
            this.radioButton_Slow.Size = new System.Drawing.Size(260, 21);
            this.radioButton_Slow.TabIndex = 2;
            this.radioButton_Slow.Text = "Моделирование в течении 6 минут";
            this.radioButton_Slow.UseVisualStyleBackColor = true;
            this.radioButton_Slow.CheckedChanged += new System.EventHandler(this.radioButton_Fast_CheckedChanged);
            // 
            // radioButton_Fast
            // 
            this.radioButton_Fast.AutoSize = true;
            this.radioButton_Fast.Checked = true;
            this.radioButton_Fast.Location = new System.Drawing.Point(9, 248);
            this.radioButton_Fast.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_Fast.Name = "radioButton_Fast";
            this.radioButton_Fast.Size = new System.Drawing.Size(194, 21);
            this.radioButton_Fast.TabIndex = 1;
            this.radioButton_Fast.TabStop = true;
            this.radioButton_Fast.Text = "Быстрое моделирование";
            this.radioButton_Fast.UseVisualStyleBackColor = true;
            this.radioButton_Fast.CheckedChanged += new System.EventHandler(this.radioButton_Fast_CheckedChanged);
            // 
            // Settings
            // 
            this.Settings.AutoArrange = false;
            this.Settings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.Settings.FullRowSelect = true;
            this.Settings.GridLines = true;
            this.Settings.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Settings.Location = new System.Drawing.Point(9, 21);
            this.Settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(304, 221);
            this.Settings.TabIndex = 0;
            this.Settings.UseCompatibleStateImageBehavior = false;
            this.Settings.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            this.columnHeader2.Width = 64;
            // 
            // ModelTimer
            // 
            this.ModelTimer.Interval = 1;
            this.ModelTimer.Tag = "";
            this.ModelTimer.Tick += new System.EventHandler(this.ModelTimer_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Stats";
            this.saveFileDialog1.Filter = "Text files|*.txt";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Pause.gif");
            this.imageList1.Images.SetKeyName(1, "Play.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "График распределения пассажиров";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(746, 566);
            this.Controls.Add(this.groupBox_ModelingProperties);
            this.Controls.Add(this.toolStrip_MainTools);
            this.Controls.Add(this.groupBox_RealTimeModel);
            this.Controls.Add(this.statusStrip_AllStat);
            this.Controls.Add(this.menuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Моделирование Маршрутного такси";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.statusStrip_AllStat.ResumeLayout(false);
            this.statusStrip_AllStat.PerformLayout();
            this.groupBox_RealTimeModel.ResumeLayout(false);
            this.toolStrip_MainTools.ResumeLayout(false);
            this.toolStrip_MainTools.PerformLayout();
            this.groupBox_ModelingProperties.ResumeLayout(false);
            this.groupBox_ModelingProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Modeling;
        private System.Windows.Forms.StatusStrip statusStrip_AllStat;
        private System.Windows.Forms.GroupBox groupBox_RealTimeModel;
        private System.Windows.Forms.ListBox listBox_ModelStations;
        private System.Windows.Forms.ToolStrip toolStrip_MainTools;
        private System.Windows.Forms.ToolStripButton toolStripButton_Start;
        private System.Windows.Forms.ToolStripButton toolStripButton_Stop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ExportStat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ModelSettings;
        private System.Windows.Forms.GroupBox groupBox_ModelingProperties;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer ModelTimer;
        private System.Windows.Forms.ListView Settings;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.RadioButton radioButton_Slow;
        private System.Windows.Forms.RadioButton radioButton_Fast;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Start;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Stop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton_pause;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;

    }
}


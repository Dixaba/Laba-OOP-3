namespace Лаба_ООП_3
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
            this.toolStripMenuItem_Service = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_AllStat = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox_RealTimeModel = new System.Windows.Forms.GroupBox();
            this.listBox_ModelStations = new System.Windows.Forms.ListBox();
            this.toolStrip_MainTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox_ModelingProperties = new System.Windows.Forms.GroupBox();
            this.radioButton_Slow = new System.Windows.Forms.RadioButton();
            this.radioButton_Fast = new System.Windows.Forms.RadioButton();
            this.Settings = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModelTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.toolStripMenuItem_Modeling,
            this.toolStripMenuItem_Service});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip_Main.Size = new System.Drawing.Size(634, 24);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "Главное меню";
            // 
            // toolStripMenuItem_File
            // 
            this.toolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_ExportStat});
            this.toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            this.toolStripMenuItem_File.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem_File.Text = "Файл";
            // 
            // toolStripMenuItem_ExportStat
            // 
            this.toolStripMenuItem_ExportStat.Name = "toolStripMenuItem_ExportStat";
            this.toolStripMenuItem_ExportStat.Size = new System.Drawing.Size(194, 22);
            this.toolStripMenuItem_ExportStat.Text = "Сохранить статистику";
            // 
            // toolStripMenuItem_Modeling
            // 
            this.toolStripMenuItem_Modeling.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Start,
            this.toolStripMenuItem_Stop,
            this.toolStripSeparator2,
            this.toolStripMenuItem_ModelSettings});
            this.toolStripMenuItem_Modeling.Name = "toolStripMenuItem_Modeling";
            this.toolStripMenuItem_Modeling.Size = new System.Drawing.Size(109, 20);
            this.toolStripMenuItem_Modeling.Text = "Моделирование";
            // 
            // toolStripMenuItem_Start
            // 
            this.toolStripMenuItem_Start.Name = "toolStripMenuItem_Start";
            this.toolStripMenuItem_Start.Size = new System.Drawing.Size(223, 22);
            this.toolStripMenuItem_Start.Text = "Начать";
            // 
            // toolStripMenuItem_Stop
            // 
            this.toolStripMenuItem_Stop.Name = "toolStripMenuItem_Stop";
            this.toolStripMenuItem_Stop.Size = new System.Drawing.Size(223, 22);
            this.toolStripMenuItem_Stop.Text = "Остановить";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
            // 
            // toolStripMenuItem_ModelSettings
            // 
            this.toolStripMenuItem_ModelSettings.Name = "toolStripMenuItem_ModelSettings";
            this.toolStripMenuItem_ModelSettings.Size = new System.Drawing.Size(223, 22);
            this.toolStripMenuItem_ModelSettings.Text = "Настроить моделирование";
            this.toolStripMenuItem_ModelSettings.Click += new System.EventHandler(this.toolStripMenuItem_ModelSettings_Click);
            // 
            // toolStripMenuItem_Service
            // 
            this.toolStripMenuItem_Service.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Help});
            this.toolStripMenuItem_Service.Name = "toolStripMenuItem_Service";
            this.toolStripMenuItem_Service.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem_Service.Text = "Сервис";
            // 
            // toolStripMenuItem_Help
            // 
            this.toolStripMenuItem_Help.Name = "toolStripMenuItem_Help";
            this.toolStripMenuItem_Help.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem_Help.Text = "Справка";
            // 
            // statusStrip_AllStat
            // 
            this.statusStrip_AllStat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip_AllStat.Location = new System.Drawing.Point(0, 465);
            this.statusStrip_AllStat.Name = "statusStrip_AllStat";
            this.statusStrip_AllStat.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStrip_AllStat.Size = new System.Drawing.Size(634, 29);
            this.statusStrip_AllStat.TabIndex = 1;
            this.statusStrip_AllStat.Text = "Статус исполнения";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(154, 24);
            this.toolStripStatusLabel1.Text = "Моделирование не начато";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Maximum = 1439;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(133, 23);
            this.toolStripProgressBar1.Step = 1;
            // 
            // groupBox_RealTimeModel
            // 
            this.groupBox_RealTimeModel.Controls.Add(this.listBox_ModelStations);
            this.groupBox_RealTimeModel.Location = new System.Drawing.Point(12, 57);
            this.groupBox_RealTimeModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_RealTimeModel.Name = "groupBox_RealTimeModel";
            this.groupBox_RealTimeModel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_RealTimeModel.Size = new System.Drawing.Size(347, 401);
            this.groupBox_RealTimeModel.TabIndex = 2;
            this.groupBox_RealTimeModel.TabStop = false;
            this.groupBox_RealTimeModel.Text = "Модель в реальном времени";
            // 
            // listBox_ModelStations
            // 
            this.listBox_ModelStations.FormattingEnabled = true;
            this.listBox_ModelStations.Location = new System.Drawing.Point(5, 17);
            this.listBox_ModelStations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_ModelStations.Name = "listBox_ModelStations";
            this.listBox_ModelStations.Size = new System.Drawing.Size(335, 355);
            this.listBox_ModelStations.TabIndex = 0;
            // 
            // toolStrip_MainTools
            // 
            this.toolStrip_MainTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Start,
            this.toolStripButton_Stop,
            this.toolStripSeparator1});
            this.toolStrip_MainTools.Location = new System.Drawing.Point(0, 24);
            this.toolStrip_MainTools.Name = "toolStrip_MainTools";
            this.toolStrip_MainTools.Size = new System.Drawing.Size(634, 25);
            this.toolStrip_MainTools.TabIndex = 3;
            this.toolStrip_MainTools.Text = "Инструменты";
            // 
            // toolStripButton_Start
            // 
            this.toolStripButton_Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.toolStripButton_Stop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Stop.Image")));
            this.toolStripButton_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Stop.Name = "toolStripButton_Stop";
            this.toolStripButton_Stop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Stop.Text = "Остановить моделирование";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox_ModelingProperties
            // 
            this.groupBox_ModelingProperties.Controls.Add(this.pictureBox1);
            this.groupBox_ModelingProperties.Controls.Add(this.radioButton_Slow);
            this.groupBox_ModelingProperties.Controls.Add(this.radioButton_Fast);
            this.groupBox_ModelingProperties.Controls.Add(this.Settings);
            this.groupBox_ModelingProperties.Location = new System.Drawing.Point(366, 57);
            this.groupBox_ModelingProperties.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox_ModelingProperties.Name = "groupBox_ModelingProperties";
            this.groupBox_ModelingProperties.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox_ModelingProperties.Size = new System.Drawing.Size(258, 401);
            this.groupBox_ModelingProperties.TabIndex = 4;
            this.groupBox_ModelingProperties.TabStop = false;
            this.groupBox_ModelingProperties.Text = "Настройки данного моделирования";
            // 
            // radioButton_Slow
            // 
            this.radioButton_Slow.AutoSize = true;
            this.radioButton_Slow.Location = new System.Drawing.Point(7, 235);
            this.radioButton_Slow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_Slow.Name = "radioButton_Slow";
            this.radioButton_Slow.Size = new System.Drawing.Size(200, 17);
            this.radioButton_Slow.TabIndex = 2;
            this.radioButton_Slow.TabStop = true;
            this.radioButton_Slow.Text = "Моделирование в течении 6 минут";
            this.radioButton_Slow.UseVisualStyleBackColor = true;
            // 
            // radioButton_Fast
            // 
            this.radioButton_Fast.AutoSize = true;
            this.radioButton_Fast.Location = new System.Drawing.Point(7, 214);
            this.radioButton_Fast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_Fast.Name = "radioButton_Fast";
            this.radioButton_Fast.Size = new System.Drawing.Size(152, 17);
            this.radioButton_Fast.TabIndex = 1;
            this.radioButton_Fast.TabStop = true;
            this.radioButton_Fast.Text = "Быстрое моделирование";
            this.radioButton_Fast.UseVisualStyleBackColor = true;
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
            this.Settings.Location = new System.Drawing.Point(7, 18);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(244, 191);
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
            this.ModelTimer.Tick += new System.EventHandler(this.ModelTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(634, 494);
            this.Controls.Add(this.groupBox_ModelingProperties);
            this.Controls.Add(this.toolStrip_MainTools);
            this.Controls.Add(this.groupBox_RealTimeModel);
            this.Controls.Add(this.statusStrip_AllStat);
            this.Controls.Add(this.menuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Service;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Help;
        private System.Windows.Forms.GroupBox groupBox_ModelingProperties;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
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

    }
}


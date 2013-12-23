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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip_Main.SuspendLayout();
            this.statusStrip_AllStat.SuspendLayout();
            this.groupBox_RealTimeModel.SuspendLayout();
            this.toolStrip_MainTools.SuspendLayout();
            this.groupBox_ModelingProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip_Main.Size = new System.Drawing.Size(634, 28);
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
            this.toolStripMenuItem_ExportStat.Name = "toolStripMenuItem_ExportStat";
            this.toolStripMenuItem_ExportStat.Size = new System.Drawing.Size(228, 24);
            this.toolStripMenuItem_ExportStat.Text = "Сохранить статистику";
            // 
            // toolStripMenuItem_Modeling
            // 
            this.toolStripMenuItem_Modeling.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_ModelSettings});
            this.toolStripMenuItem_Modeling.Name = "toolStripMenuItem_Modeling";
            this.toolStripMenuItem_Modeling.Size = new System.Drawing.Size(136, 24);
            this.toolStripMenuItem_Modeling.Text = "Моделирование";
            // 
            // toolStripMenuItem_ModelSettings
            // 
            this.toolStripMenuItem_ModelSettings.Name = "toolStripMenuItem_ModelSettings";
            this.toolStripMenuItem_ModelSettings.Size = new System.Drawing.Size(268, 24);
            this.toolStripMenuItem_ModelSettings.Text = "Настроить моделирование";
            this.toolStripMenuItem_ModelSettings.Click += new System.EventHandler(this.toolStripMenuItem_ModelSettings_Click);
            // 
            // toolStripMenuItem_Service
            // 
            this.toolStripMenuItem_Service.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Help});
            this.toolStripMenuItem_Service.Name = "toolStripMenuItem_Service";
            this.toolStripMenuItem_Service.Size = new System.Drawing.Size(71, 24);
            this.toolStripMenuItem_Service.Text = "Сервис";
            // 
            // toolStripMenuItem_Help
            // 
            this.toolStripMenuItem_Help.Name = "toolStripMenuItem_Help";
            this.toolStripMenuItem_Help.Size = new System.Drawing.Size(136, 24);
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(197, 24);
            this.toolStripStatusLabel1.Text = "Моделирование не начато";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(133, 23);
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
            this.listBox_ModelStations.ItemHeight = 16;
            this.listBox_ModelStations.Location = new System.Drawing.Point(5, 17);
            this.listBox_ModelStations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_ModelStations.Name = "listBox_ModelStations";
            this.listBox_ModelStations.Size = new System.Drawing.Size(335, 372);
            this.listBox_ModelStations.TabIndex = 0;
            // 
            // toolStrip_MainTools
            // 
            this.toolStrip_MainTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Start,
            this.toolStripButton_Stop,
            this.toolStripSeparator1});
            this.toolStrip_MainTools.Location = new System.Drawing.Point(0, 28);
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
            this.groupBox_ModelingProperties.Controls.Add(this.dataGridView1);
            this.groupBox_ModelingProperties.Location = new System.Drawing.Point(366, 57);
            this.groupBox_ModelingProperties.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox_ModelingProperties.Name = "groupBox_ModelingProperties";
            this.groupBox_ModelingProperties.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox_ModelingProperties.Size = new System.Drawing.Size(258, 401);
            this.groupBox_ModelingProperties.TabIndex = 4;
            this.groupBox_ModelingProperties.TabStop = false;
            this.groupBox_ModelingProperties.Text = "Настройки данного моделирования";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column1_Value});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(8, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(243, 364);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column_Name
            // 
            this.Column_Name.Frozen = true;
            this.Column_Name.HeaderText = "Имя";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            // 
            // Column1_Value
            // 
            this.Column1_Value.Frozen = true;
            this.Column1_Value.HeaderText = "Значение";
            this.Column1_Value.Name = "Column1_Value";
            this.Column1_Value.ReadOnly = true;
            // 
            // ModelTimer
            // 
            this.ModelTimer.Interval = 250;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_Value;
        private System.Windows.Forms.Timer ModelTimer;

    }
}


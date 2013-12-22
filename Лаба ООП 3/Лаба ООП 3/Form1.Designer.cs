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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ExportStat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Modeling = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ModelSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Service = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_AllStat = new System.Windows.Forms.StatusStrip();
            this.groupBox_RealTimeModel = new System.Windows.Forms.GroupBox();
            this.listBox_ModelStations = new System.Windows.Forms.ListBox();
            this.toolStrip_MainTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox_ModelingProperties = new System.Windows.Forms.GroupBox();
            this.listView_Properties = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Main.SuspendLayout();
            this.groupBox_RealTimeModel.SuspendLayout();
            this.toolStrip_MainTools.SuspendLayout();
            this.groupBox_ModelingProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_File,
            this.toolStripMenuItem_Modeling,
            this.toolStripMenuItem_Service,
            this.toolStripMenuItem1});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip_Main.Size = new System.Drawing.Size(550, 24);
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
            this.toolStripMenuItem_ModelSettings});
            this.toolStripMenuItem_Modeling.Name = "toolStripMenuItem_Modeling";
            this.toolStripMenuItem_Modeling.Size = new System.Drawing.Size(109, 20);
            this.toolStripMenuItem_Modeling.Text = "Моделирование";
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
            this.statusStrip_AllStat.Location = new System.Drawing.Point(0, 370);
            this.statusStrip_AllStat.Name = "statusStrip_AllStat";
            this.statusStrip_AllStat.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip_AllStat.Size = new System.Drawing.Size(550, 22);
            this.statusStrip_AllStat.TabIndex = 1;
            this.statusStrip_AllStat.Text = "Статус исполнения";
            // 
            // groupBox_RealTimeModel
            // 
            this.groupBox_RealTimeModel.Controls.Add(this.listBox_ModelStations);
            this.groupBox_RealTimeModel.Location = new System.Drawing.Point(9, 46);
            this.groupBox_RealTimeModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_RealTimeModel.Name = "groupBox_RealTimeModel";
            this.groupBox_RealTimeModel.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_RealTimeModel.Size = new System.Drawing.Size(260, 326);
            this.groupBox_RealTimeModel.TabIndex = 2;
            this.groupBox_RealTimeModel.TabStop = false;
            this.groupBox_RealTimeModel.Text = "Модель в реальном времени";
            // 
            // listBox_ModelStations
            // 
            this.listBox_ModelStations.FormattingEnabled = true;
            this.listBox_ModelStations.Location = new System.Drawing.Point(4, 14);
            this.listBox_ModelStations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_ModelStations.Name = "listBox_ModelStations";
            this.listBox_ModelStations.Size = new System.Drawing.Size(252, 303);
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
            this.toolStrip_MainTools.Size = new System.Drawing.Size(550, 25);
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
            this.groupBox_ModelingProperties.Controls.Add(this.listView_Properties);
            this.groupBox_ModelingProperties.Location = new System.Drawing.Point(274, 46);
            this.groupBox_ModelingProperties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_ModelingProperties.Name = "groupBox_ModelingProperties";
            this.groupBox_ModelingProperties.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_ModelingProperties.Size = new System.Drawing.Size(266, 326);
            this.groupBox_ModelingProperties.TabIndex = 4;
            this.groupBox_ModelingProperties.TabStop = false;
            this.groupBox_ModelingProperties.Text = "Настройки данного моделирования";
            // 
            // listView_Properties
            // 
            this.listView_Properties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Properties.Location = new System.Drawing.Point(4, 17);
            this.listView_Properties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView_Properties.Name = "listView_Properties";
            this.listView_Properties.Size = new System.Drawing.Size(258, 300);
            this.listView_Properties.TabIndex = 0;
            this.listView_Properties.UseCompatibleStateImageBehavior = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "!";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 392);
            this.Controls.Add(this.groupBox_ModelingProperties);
            this.Controls.Add(this.toolStrip_MainTools);
            this.Controls.Add(this.groupBox_RealTimeModel);
            this.Controls.Add(this.statusStrip_AllStat);
            this.Controls.Add(this.menuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip_Main;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Моделирование Маршрутного такси";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.groupBox_RealTimeModel.ResumeLayout(false);
            this.toolStrip_MainTools.ResumeLayout(false);
            this.toolStrip_MainTools.PerformLayout();
            this.groupBox_ModelingProperties.ResumeLayout(false);
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
        private System.Windows.Forms.ListView listView_Properties;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    }
}


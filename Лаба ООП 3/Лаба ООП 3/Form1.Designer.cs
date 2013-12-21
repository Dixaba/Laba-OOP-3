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
            this.statusStrip_AllStat = new System.Windows.Forms.StatusStrip();
            this.toolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1_RealTimeModel = new System.Windows.Forms.GroupBox();
            this.listBox_ModelStations = new System.Windows.Forms.ListBox();
            this.toolStrip_MainTools = new System.Windows.Forms.ToolStrip();
            this.toolStripMenuItem_Modeling = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Service = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemModelSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ExportStat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Main.SuspendLayout();
            this.groupBox1_RealTimeModel.SuspendLayout();
            this.toolStrip_MainTools.SuspendLayout();
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
            this.menuStrip_Main.Size = new System.Drawing.Size(733, 28);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "Главное меню";
            // 
            // statusStrip_AllStat
            // 
            this.statusStrip_AllStat.Location = new System.Drawing.Point(0, 460);
            this.statusStrip_AllStat.Name = "statusStrip_AllStat";
            this.statusStrip_AllStat.Size = new System.Drawing.Size(733, 22);
            this.statusStrip_AllStat.TabIndex = 1;
            this.statusStrip_AllStat.Text = "Статус исполнения";
            // 
            // toolStripMenuItem_File
            // 
            this.toolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_ExportStat});
            this.toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            this.toolStripMenuItem_File.Size = new System.Drawing.Size(57, 24);
            this.toolStripMenuItem_File.Text = "Файл";
            // 
            // groupBox1_RealTimeModel
            // 
            this.groupBox1_RealTimeModel.Controls.Add(this.listBox_ModelStations);
            this.groupBox1_RealTimeModel.Location = new System.Drawing.Point(12, 56);
            this.groupBox1_RealTimeModel.Name = "groupBox1_RealTimeModel";
            this.groupBox1_RealTimeModel.Size = new System.Drawing.Size(347, 401);
            this.groupBox1_RealTimeModel.TabIndex = 2;
            this.groupBox1_RealTimeModel.TabStop = false;
            this.groupBox1_RealTimeModel.Text = "Модель в реальном времени";
            // 
            // listBox_ModelStations
            // 
            this.listBox_ModelStations.FormattingEnabled = true;
            this.listBox_ModelStations.ItemHeight = 16;
            this.listBox_ModelStations.Location = new System.Drawing.Point(6, 17);
            this.listBox_ModelStations.Name = "listBox_ModelStations";
            this.listBox_ModelStations.Size = new System.Drawing.Size(335, 372);
            this.listBox_ModelStations.TabIndex = 0;
            // 
            // toolStrip_MainTools
            // 
            this.toolStrip_MainTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Start,
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.toolStrip_MainTools.Location = new System.Drawing.Point(0, 28);
            this.toolStrip_MainTools.Name = "toolStrip_MainTools";
            this.toolStrip_MainTools.Size = new System.Drawing.Size(733, 25);
            this.toolStrip_MainTools.TabIndex = 3;
            this.toolStrip_MainTools.Text = "Инструменты";
            // 
            // toolStripMenuItem_Modeling
            // 
            this.toolStripMenuItem_Modeling.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemModelSettings});
            this.toolStripMenuItem_Modeling.Name = "toolStripMenuItem_Modeling";
            this.toolStripMenuItem_Modeling.Size = new System.Drawing.Size(136, 24);
            this.toolStripMenuItem_Modeling.Text = "Моделирование";
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Остановить моделирование";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.toolStripMenuItem_Help.Size = new System.Drawing.Size(175, 24);
            this.toolStripMenuItem_Help.Text = "Справка";
            // 
            // toolStripMenuItemModelSettings
            // 
            this.toolStripMenuItemModelSettings.Name = "toolStripMenuItemModelSettings";
            this.toolStripMenuItemModelSettings.Size = new System.Drawing.Size(268, 24);
            this.toolStripMenuItemModelSettings.Text = "Настроить моделирование";
            // 
            // toolStripMenuItem_ExportStat
            // 
            this.toolStripMenuItem_ExportStat.Name = "toolStripMenuItem_ExportStat";
            this.toolStripMenuItem_ExportStat.Size = new System.Drawing.Size(228, 24);
            this.toolStripMenuItem_ExportStat.Text = "Сохранить статистику";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 482);
            this.Controls.Add(this.toolStrip_MainTools);
            this.Controls.Add(this.groupBox1_RealTimeModel);
            this.Controls.Add(this.statusStrip_AllStat);
            this.Controls.Add(this.menuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip_Main;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Моделирование Маршрутного такси";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.groupBox1_RealTimeModel.ResumeLayout(false);
            this.toolStrip_MainTools.ResumeLayout(false);
            this.toolStrip_MainTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Modeling;
        private System.Windows.Forms.StatusStrip statusStrip_AllStat;
        private System.Windows.Forms.GroupBox groupBox1_RealTimeModel;
        private System.Windows.Forms.ListBox listBox_ModelStations;
        private System.Windows.Forms.ToolStrip toolStrip_MainTools;
        private System.Windows.Forms.ToolStripButton toolStripButton_Start;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ExportStat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModelSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Service;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Help;

    }
}


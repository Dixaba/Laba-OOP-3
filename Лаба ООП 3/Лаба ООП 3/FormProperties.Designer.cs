namespace Лаба_ООП_3
{
    partial class FormProperties
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Accept = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox_Properties = new System.Windows.Forms.GroupBox();
            this.numericUpDown_Stations = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Passangers = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Time = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Capacity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Hour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_Min = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_Properties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Stations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Passangers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Accept
            // 
            this.button_Accept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Accept.Location = new System.Drawing.Point(314, 215);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(95, 23);
            this.button_Accept.TabIndex = 0;
            this.button_Accept.Text = "Применить";
            this.button_Accept.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(227, 215);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(81, 23);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Отменить";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // groupBox_Properties
            // 
            this.groupBox_Properties.Controls.Add(this.label7);
            this.groupBox_Properties.Controls.Add(this.label6);
            this.groupBox_Properties.Controls.Add(this.label5);
            this.groupBox_Properties.Controls.Add(this.numericUpDown_Min);
            this.groupBox_Properties.Controls.Add(this.label4);
            this.groupBox_Properties.Controls.Add(this.label3);
            this.groupBox_Properties.Controls.Add(this.label2);
            this.groupBox_Properties.Controls.Add(this.label1);
            this.groupBox_Properties.Controls.Add(this.numericUpDown_Hour);
            this.groupBox_Properties.Controls.Add(this.numericUpDown_Capacity);
            this.groupBox_Properties.Controls.Add(this.numericUpDown_Time);
            this.groupBox_Properties.Controls.Add(this.numericUpDown_Passangers);
            this.groupBox_Properties.Controls.Add(this.numericUpDown_Stations);
            this.groupBox_Properties.Location = new System.Drawing.Point(13, 13);
            this.groupBox_Properties.Name = "groupBox_Properties";
            this.groupBox_Properties.Size = new System.Drawing.Size(396, 196);
            this.groupBox_Properties.TabIndex = 2;
            this.groupBox_Properties.TabStop = false;
            this.groupBox_Properties.Text = "Настройки";
            // 
            // numericUpDown_Stations
            // 
            this.numericUpDown_Stations.Location = new System.Drawing.Point(265, 18);
            this.numericUpDown_Stations.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_Stations.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_Stations.Name = "numericUpDown_Stations";
            this.numericUpDown_Stations.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_Stations.TabIndex = 0;
            this.numericUpDown_Stations.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_Passangers
            // 
            this.numericUpDown_Passangers.Location = new System.Drawing.Point(265, 47);
            this.numericUpDown_Passangers.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_Passangers.Name = "numericUpDown_Passangers";
            this.numericUpDown_Passangers.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_Passangers.TabIndex = 1;
            this.numericUpDown_Passangers.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDown_Time
            // 
            this.numericUpDown_Time.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Time.Location = new System.Drawing.Point(265, 75);
            this.numericUpDown_Time.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_Time.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Time.Name = "numericUpDown_Time";
            this.numericUpDown_Time.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_Time.TabIndex = 2;
            this.numericUpDown_Time.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_Capacity
            // 
            this.numericUpDown_Capacity.Location = new System.Drawing.Point(265, 104);
            this.numericUpDown_Capacity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Capacity.Name = "numericUpDown_Capacity";
            this.numericUpDown_Capacity.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_Capacity.TabIndex = 3;
            this.numericUpDown_Capacity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_Hour
            // 
            this.numericUpDown_Hour.Location = new System.Drawing.Point(265, 133);
            this.numericUpDown_Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown_Hour.Name = "numericUpDown_Hour";
            this.numericUpDown_Hour.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_Hour.TabIndex = 4;
            this.numericUpDown_Hour.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество остановок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество пассажиров в сутки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Время движения между остановками";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вместимость маршрутного ТС";
            // 
            // numericUpDown_Min
            // 
            this.numericUpDown_Min.Location = new System.Drawing.Point(264, 162);
            this.numericUpDown_Min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_Min.Name = "numericUpDown_Min";
            this.numericUpDown_Min.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_Min.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Час пик:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Часы";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Минуты";
            // 
            // FormProperties
            // 
            this.AcceptButton = this.button_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(418, 246);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox_Properties);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Accept);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProperties";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки моделирования";
            this.TopMost = true;
            this.groupBox_Properties.ResumeLayout(false);
            this.groupBox_Properties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Stations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Passangers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox groupBox_Properties;
        private System.Windows.Forms.NumericUpDown numericUpDown_Min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Hour;
        private System.Windows.Forms.NumericUpDown numericUpDown_Capacity;
        private System.Windows.Forms.NumericUpDown numericUpDown_Time;
        private System.Windows.Forms.NumericUpDown numericUpDown_Passangers;
        private System.Windows.Forms.NumericUpDown numericUpDown_Stations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
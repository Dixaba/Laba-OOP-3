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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProperties));
            this.button_Accept = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox_Properties = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_Min2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Hour2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_Min1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Hour1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Capacity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Time = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Passangers = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Stations = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Properties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Passangers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Stations)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Accept
            // 
            this.button_Accept.AutoSize = true;
            this.button_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Accept.Location = new System.Drawing.Point(212, 267);
            this.button_Accept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(99, 28);
            this.button_Accept.TabIndex = 0;
            this.button_Accept.Text = "Применить";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.AutoSize = true;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(117, 267);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(89, 28);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Отменить";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // groupBox_Properties
            // 
            this.groupBox_Properties.Controls.Add(this.label10);
            this.groupBox_Properties.Controls.Add(this.label9);
            this.groupBox_Properties.Controls.Add(this.label8);
            this.groupBox_Properties.Controls.Add(this.numericUpDown_Min2);
            this.groupBox_Properties.Controls.Add(this.numericUpDown_Hour2);
            this.groupBox_Properties.Controls.Add(this.label7);
            this.groupBox_Properties.Controls.Add(this.label6);
            this.groupBox_Properties.Controls.Add(this.label5);
            this.groupBox_Properties.Controls.Add(this.numericUpDown_Min1);
            this.groupBox_Properties.Controls.Add(this.label4);
            this.groupBox_Properties.Controls.Add(this.label3);
            this.groupBox_Properties.Controls.Add(this.label2);
            this.groupBox_Properties.Controls.Add(this.label1);
            this.groupBox_Properties.Controls.Add(this.numericUpDown_Hour1);
            this.groupBox_Properties.Controls.Add(this.numericUpDown_Capacity);
            this.groupBox_Properties.Controls.Add(this.numericUpDown_Time);
            this.groupBox_Properties.Controls.Add(this.numericUpDown_Passangers);
            this.groupBox_Properties.Controls.Add(this.numericUpDown_Stations);
            this.groupBox_Properties.Location = new System.Drawing.Point(13, 14);
            this.groupBox_Properties.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Properties.Name = "groupBox_Properties";
            this.groupBox_Properties.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Properties.Size = new System.Drawing.Size(308, 249);
            this.groupBox_Properties.TabIndex = 2;
            this.groupBox_Properties.TabStop = false;
            this.groupBox_Properties.Text = "Настройки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(178, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Час";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Минута";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Час пик №2:";
            // 
            // numericUpDown_Min2
            // 
            this.numericUpDown_Min2.Location = new System.Drawing.Point(210, 215);
            this.numericUpDown_Min2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_Min2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_Min2.Name = "numericUpDown_Min2";
            this.numericUpDown_Min2.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown_Min2.TabIndex = 15;
            // 
            // numericUpDown_Hour2
            // 
            this.numericUpDown_Hour2.Location = new System.Drawing.Point(210, 188);
            this.numericUpDown_Hour2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_Hour2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown_Hour2.Name = "numericUpDown_Hour2";
            this.numericUpDown_Hour2.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown_Hour2.TabIndex = 14;
            this.numericUpDown_Hour2.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Минута";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Час";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Час пик №1:";
            // 
            // numericUpDown_Min1
            // 
            this.numericUpDown_Min1.Location = new System.Drawing.Point(210, 161);
            this.numericUpDown_Min1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_Min1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_Min1.Name = "numericUpDown_Min1";
            this.numericUpDown_Min1.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown_Min1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вместимость маршрутного ТС";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Время движения между остановками";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество пассажиров в сутки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество остановок";
            // 
            // numericUpDown_Hour1
            // 
            this.numericUpDown_Hour1.Location = new System.Drawing.Point(210, 131);
            this.numericUpDown_Hour1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_Hour1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown_Hour1.Name = "numericUpDown_Hour1";
            this.numericUpDown_Hour1.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown_Hour1.TabIndex = 4;
            this.numericUpDown_Hour1.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numericUpDown_Capacity
            // 
            this.numericUpDown_Capacity.Location = new System.Drawing.Point(210, 102);
            this.numericUpDown_Capacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_Capacity.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown_Capacity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Capacity.Name = "numericUpDown_Capacity";
            this.numericUpDown_Capacity.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown_Capacity.TabIndex = 3;
            this.numericUpDown_Capacity.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // numericUpDown_Time
            // 
            this.numericUpDown_Time.Location = new System.Drawing.Point(210, 74);
            this.numericUpDown_Time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_Time.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Time.Name = "numericUpDown_Time";
            this.numericUpDown_Time.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown_Time.TabIndex = 2;
            this.numericUpDown_Time.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown_Passangers
            // 
            this.numericUpDown_Passangers.Location = new System.Drawing.Point(210, 45);
            this.numericUpDown_Passangers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_Passangers.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown_Passangers.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Passangers.Name = "numericUpDown_Passangers";
            this.numericUpDown_Passangers.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown_Passangers.TabIndex = 1;
            this.numericUpDown_Passangers.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numericUpDown_Stations
            // 
            this.numericUpDown_Stations.Location = new System.Drawing.Point(210, 17);
            this.numericUpDown_Stations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numericUpDown_Stations.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown_Stations.TabIndex = 0;
            this.numericUpDown_Stations.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // FormProperties
            // 
            this.AcceptButton = this.button_Accept;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(327, 302);
            this.Controls.Add(this.groupBox_Properties);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Accept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProperties";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки моделирования";
            this.TopMost = true;
            this.groupBox_Properties.ResumeLayout(false);
            this.groupBox_Properties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hour1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Passangers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Stations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox groupBox_Properties;
        private System.Windows.Forms.NumericUpDown numericUpDown_Min1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Hour1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Capacity;
        private System.Windows.Forms.NumericUpDown numericUpDown_Time;
        private System.Windows.Forms.NumericUpDown numericUpDown_Passangers;
        private System.Windows.Forms.NumericUpDown numericUpDown_Stations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_Min2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Hour2;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_ООП_3
{
    public partial class FormProperties : Form
    {
        public int StationCount { get; set; }
        public int PassengerCount { get; set; }
        public int RideTime { get; set; }
        public int Capacity { get; set; }
        public int Peak1 { get; set; }
        public int Peak2 { get; set; }

        public FormProperties()
        {
            InitializeComponent();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            StationCount = (int)numericUpDown_Stations.Value;
            PassengerCount = (int)numericUpDown_Passangers.Value;
            RideTime = (int)numericUpDown_Time.Value;
            Capacity = (int)numericUpDown_Capacity.Value;
            Peak1 = (int)(numericUpDown_Hour1.Value * 60 + numericUpDown_Min1.Value);
            Peak2 = (int)(numericUpDown_Hour2.Value * 60 + numericUpDown_Min2.Value);
        }
    }
}

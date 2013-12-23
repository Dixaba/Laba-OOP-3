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
        public uint StationCount { get; set; }
        public uint PassengerCount { get; set; }
        public uint RideTime { get; set; }
        public uint Capacity { get; set; }
        public uint Peak1 { get; set; }
        public uint Peak2 { get; set; }

        public FormProperties()
        {
            InitializeComponent();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            StationCount = (uint)numericUpDown_Stations.Value;
            PassengerCount = (uint)numericUpDown_Passangers.Value;
            RideTime = (uint)numericUpDown_Time.Value;
            Capacity = (uint)numericUpDown_Capacity.Value;
            Peak1 = (uint)(numericUpDown_Hour1.Value * 60 + numericUpDown_Min1.Value);
            Peak2 = (uint)(numericUpDown_Hour2.Value * 60 + numericUpDown_Min2.Value);
        }
    }
}

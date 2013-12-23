using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Meta.Numerics.Statistics.Distributions;
namespace Лаба_ООП_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        FormProperties aba = new FormProperties();

        private void toolStripMenuItem_ModelSettings_Click(object sender, EventArgs e)
        {
            aba.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton_Start_Click(object sender, EventArgs e)
        {
            uint AvgCount = 25000; // Среднее за сутки
            uint Count = 0; // Кол-во людей на 1-й остановке за сутки
            uint LCount = 0; // Кол-во людей на 1-й остановке за минуту

            for (uint i = 0; i < 1440; i++)
            {
                LCount = Distrib.Get(AvgCount, 720, 20, i, 10);

                listBox_ModelStations.Items.Add(i + ": " + LCount);
                Count += LCount;
            }
            listBox_ModelStations.Items.Add(Count);
        }
    }
}
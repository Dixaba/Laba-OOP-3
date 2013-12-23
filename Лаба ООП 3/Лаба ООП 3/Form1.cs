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
            double d = 0;
            LogisticDistribution logis = new LogisticDistribution(420, 20);
            LogisticDistribution logis2 = new LogisticDistribution(1020, 25);
            LogisticDistribution logis3 = new LogisticDistribution(720, 120);
            for (int i = 0; i <= 1380; i++)
            {
                listBox_ModelStations.Items.Add(i + ": " + (Math.Round(2500 * logis.ProbabilityDensity(i)) 
                    + Math.Round(2500 * logis2.ProbabilityDensity(i))
                    + Math.Round(2500 * logis3.ProbabilityDensity(i))));
                d += Math.Round(2500 * logis.ProbabilityDensity(i)) 
                    + Math.Round(2500 * logis2.ProbabilityDensity(i)) 
                    + Math.Round(2500 * logis3.ProbabilityDensity(i));
            }
            listBox_ModelStations.Items.Add(d);
        }
    }
}
using System;
using System.Windows.Forms;
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
            if (aba.ShowDialog() == DialogResult.OK)
            {
                Settings.Items.Clear();

                ListViewItem StationCount = Settings.Items.Add("Количество остановок");
                StationCount.SubItems.Add(aba.StationCount.ToString());

                ListViewItem PassengerCount = Settings.Items.Add("Количество пассажиров");
                PassengerCount.SubItems.Add(aba.PassengerCount.ToString());

                ListViewItem RideTime = Settings.Items.Add("Время поездки");
                RideTime.SubItems.Add(aba.RideTime.ToString()+" мин.");

                ListViewItem Capacity = Settings.Items.Add("Вместимость ТС");
                Capacity.SubItems.Add(aba.Capacity.ToString());

                ListViewItem Peak1 = Settings.Items.Add("Премя первого пика");
                Peak1.SubItems.Add((aba.Peak1 / 60).ToString() + ":" + (aba.Peak1 % 60).ToString());

                ListViewItem Peak2 = Settings.Items.Add("Время второго пика");
                Peak2.SubItems.Add((aba.Peak2 / 60).ToString() + ":" + (aba.Peak2 % 60).ToString());


            }
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
                LCount = Distrib.Get(AvgCount, 780, 20, i, 10);
                //LCount += Distrib.Get(AvgCount, 490, 20, i, 10);
                //LCount += Distrib.Get(AvgCount, 1050, 25, i, 10);
                listBox_ModelStations.Items.Add(i + ": " + LCount);
                Count += LCount;
            }
            listBox_ModelStations.Items.Add(Count + "    " + LCount);
        }
    }
}
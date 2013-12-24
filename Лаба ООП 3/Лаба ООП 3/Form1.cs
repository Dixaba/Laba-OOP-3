using System;
using System.Windows.Forms;
using System.Drawing;
namespace Лаба_ООП_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        FormProperties aba = new FormProperties();

        CircularRoute route = new CircularRoute();

        Bus bus = new Bus();

        uint AvgCount = 25000; // Среднее за сутки
        uint Count = 0; // Кол-во людей на 1-й остановке за сутки
        uint LCount = 0; // Кол-во людей на 1-й остановке за минуту
        uint TPeak1, TPeak2;
        double divider;
        uint ccc = 0;
        uint i = 0;




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
                RideTime.SubItems.Add(aba.RideTime.ToString() + " мин.");

                ListViewItem Capacity = Settings.Items.Add("Вместимость ТС");
                Capacity.SubItems.Add(aba.Capacity.ToString());

                ListViewItem Peak1 = Settings.Items.Add("Премя первого пика");
                Peak1.SubItems.Add((aba.Peak1 / 60).ToString() + ":" + (aba.Peak1 % 60).ToString());

                ListViewItem Peak2 = Settings.Items.Add("Время второго пика");
                Peak2.SubItems.Add((aba.Peak2 / 60).ToString() + ":" + (aba.Peak2 % 60).ToString());

                AvgCount = aba.PassengerCount;
                TPeak1 = aba.Peak1;
                TPeak2 = aba.Peak2;

                route.SetQueues(aba.StationCount);
                bus.SetBus(aba.Capacity, aba.RideTime);

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton_Start_Click(object sender, EventArgs e)
        {
            ModelTimer.Enabled = true;

            uint p1, p2;

            p1 = Distrib.GetAvg(AvgCount / 3, 720, 275, TPeak1, 10) +
                Distrib.GetAvg(AvgCount / 3, TPeak1, 35, TPeak1, 10) +
                Distrib.GetAvg(AvgCount / 3, TPeak2, 35, TPeak1, 10);

            p2 = Distrib.GetAvg(AvgCount / 3, 720, 275, TPeak2, 10) +
                Distrib.GetAvg(AvgCount / 3, TPeak1, 35, TPeak2, 10) +
                Distrib.GetAvg(AvgCount / 3, TPeak2, 35, TPeak2, 10);

            divider = Math.Max(p1,p2) * 1.3;

            pictureBox1.Image = null;
            listBox_ModelStations.Items.Clear();

            i = 0;
            Count = 0;
            LCount = 0;

            pictureBox1.Image = new Bitmap(180, 100);

        }

        private void ModelTimer_Tick(object sender, EventArgs e)
        {
            if (i == 1440)
            {
                ModelTimer.Enabled = false;
                listBox_ModelStations.Items.Add(Count + "    " + LCount);
                return;
            }

            if (i % 8 == 7)
            {
                int h = 99 - (int)(ccc / divider);
                for (int y = 99; y >= h; y--)
                    (pictureBox1.Image as Bitmap).SetPixel((int)(i / 8), y, Color.DarkGreen);
                pictureBox1.Invalidate();
                ccc = 0;
            }

            LCount = 0;

            for (int k = 0; k < 10; k++)
            {
                LCount += Distrib.Get(AvgCount, 900, 150, i, 10);
                //LCount += Distrib.Get(AvgCount / 3, TPeak1, 35, i, 10);
                //LCount += Distrib.Get(AvgCount / 3, TPeak2, 35, i, 10);
            }
            listBox_ModelStations.Items.Add(i + ": " + LCount);
            Count += LCount;

            ccc += LCount;

            toolStripProgressBar1.Value = (int)i;

            i++;

        }
    }
}
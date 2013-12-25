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

        int AvgCount = 25000; // Среднее за сутки
        int Count = 0; // Кол-во людей на 1-й остановке за сутки
        int LCount = 0; // Кол-во людей на 1-й остановке за минуту
        int TPeak1, TPeak2;
        double divider;
        int ccc = 0;
        int i = 0;




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

                toolStripButton_Start.Enabled = true;

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton_Start_Click(object sender, EventArgs e)
        {

            double p1, p2;

            p1 = Distrib.GetAvg(AvgCount / 3, 780, 175, TPeak1, route.StationsCount) +
                Distrib.GetAvg(AvgCount / 3, TPeak1, 35, TPeak1, route.StationsCount) +
                Distrib.GetAvg(AvgCount / 3, TPeak2, 35, TPeak1, route.StationsCount);

            p2 = Distrib.GetAvg(AvgCount / 3, 780, 175, TPeak2, route.StationsCount) +
                Distrib.GetAvg(AvgCount / 3, TPeak1, 35, TPeak2, route.StationsCount) +
                Distrib.GetAvg(AvgCount / 3, TPeak2, 35, TPeak2, route.StationsCount);

            divider = Math.Max(p1, p2) * 1.3;

            pictureBox1.Image = null;
            // listBox_ModelStations.Items.Clear();

            pictureBox1.Image = new Bitmap(180, 100);

            i = 0;
            Count = 0;
            LCount = 0;

            ModelTimer.Enabled = true;
        }

        private void ModelTimer_Tick(object sender, EventArgs e)
        {
            if (i == 1440)
            {
                ModelTimer.Enabled = false;
                listBox_ModelStations.Items.Add("Пришло: " + Count + "    Обслуженно: " + Statistics.ServedCount);
                Statistics.Clear();
                return;
            }

            if (i % 8 == 7)
            {
                int h = 99 - (int)(ccc / divider);
                for (int y = 99; y >= h; y--)
                    (pictureBox1.Image as Bitmap).SetPixel((int)(i / 8), y, Color.Green);
                pictureBox1.Invalidate();
                ccc = 0;
            }

            LCount = 0;

            for (int k = 0; k < route.StationsCount; k++)
            {
                LCount += Distrib.Get(AvgCount / 3, 780, 175, i, route.StationsCount);
                LCount += Distrib.Get(AvgCount / 3, TPeak1, 35, i, route.StationsCount);
                LCount += Distrib.Get(AvgCount / 3, TPeak2, 35, i, route.StationsCount);
            }
            //listBox_ModelStations.Items.Add(i + ": " + LCount);
            Count += LCount;
            ccc += LCount;

            for (int k = 0; k < LCount; k++)
            {
                route.SetPassenger(Distrib.SetPassengerToStation(route.StationsCount), i, Distrib.OutStation(route.StationsCount));
            }

            if (i != 0 && i % bus.RidingTime == 0)
            {
                Statistics.AddStatistics(bus.ThrowPassengers(i));
                for (int j = 0; j < bus.FreeSeat; j++)
                    bus.SetPassenger(route.DequeuePassenger(bus.CurrentStation));
                bus.Ride(route.StationsCount);
            }

            toolStripProgressBar1.Value = i++;
        }

        private void toolStripButton_Stop_Click(object sender, EventArgs e)
        {
            ModelTimer.Enabled = false;
            listBox_ModelStations.Items.Add(Count + "    " + LCount);
        }
    }
}
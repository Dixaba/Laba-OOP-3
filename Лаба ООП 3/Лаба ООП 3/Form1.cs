﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Лаба_ООП_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ModelTimer.Tag = 0;
        }

        FormProperties aba = new FormProperties();

        CircularRoute route = new CircularRoute();

        Bus bus = new Bus();

        int AvgCount = 0; // Среднее за сутки
        int Count = 0; // Кол-во людей на 1-й остановке за сутки
        int LCount = 0; // Кол-во людей на 1-й остановке за минуту
        int TPeak1, TPeak2; // Время первого и второго пиков
        double divider; // Надобно
        int ccc = 0; // Сумма пассажиров за 8 минут
        int i = 0;
        decimal Cost; // Выручка

        // Вывод статистики
        private void PrintStatistics()
        {
            Statistics.AvgTime(aba.RideTime, route.StationsCount);
            listBox_ModelStations.Items.Add("");
            listBox_ModelStations.Items.Add("Статистика:");
            listBox_ModelStations.Items.Add("Пришло: " + Count + "    Обслуженно: " + Statistics.ServedCount);
            listBox_ModelStations.Items.Add("Самая длинная очередь: " + Statistics.MaxQueueLenght);
            listBox_ModelStations.Items.Add("Остановка с самой длинной очередью: " + Statistics.MaxQueueStation);
            listBox_ModelStations.Items.Add("Когда образовалась самая длинная очередь: " + ((Statistics.MaxQueueTime / 60).ToString() + " : " + (Statistics.MaxQueueTime % 60).ToString()));
            listBox_ModelStations.Items.Add("Среднее время ожидания ТС пассажиром: " + Math.Floor(Statistics.AvgWaitingTime) + " минут");
            listBox_ModelStations.Items.Add("Вырученная сумма:" + Statistics.Cost(Cost) + " руб.");
            toolStripMenuItem_ExportStat.Enabled = true;
        }

        // Работа с настройками моделирования
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

                ListViewItem SCost = Settings.Items.Add("Стоимость проезда");
                SCost.SubItems.Add(aba.Cost.ToString() + " руб.");

                AvgCount = aba.PassengerCount;
                TPeak1 = aba.Peak1;
                TPeak2 = aba.Peak2;
                Cost = aba.Cost;

                route.SetQueues(aba.StationCount);
                bus.FreeSeat = aba.Capacity;
                bus.CurrentStation = 0;
                bus.SetBus(aba.Capacity, aba.RideTime);

                toolStripButton_Start.Enabled = true;
                toolStripMenuItem_Start.Enabled = true;

            }
        }


        private void toolStripButton_Start_Click(object sender, EventArgs e)
        {
            double p1, p2;

            p1 = Distrib.GetAvg(AvgCount / 3, 780, 175, TPeak1, 1) +
                Distrib.GetAvg(AvgCount / 3, TPeak1, 35, TPeak1, 1) +
                Distrib.GetAvg(AvgCount / 3, TPeak2, 35, TPeak1, 1);

            p2 = Distrib.GetAvg(AvgCount / 3, 780, 175, TPeak2, 1) +
                Distrib.GetAvg(AvgCount / 3, TPeak1, 35, TPeak2, 1) +
                Distrib.GetAvg(AvgCount / 3, TPeak2, 35, TPeak2, 1);

            divider = Math.Max(p1, p2) * 0.15;

            pictureBox1.Image = null;

            pictureBox1.Image = new Bitmap(180, 100);

            i = 0;
            Count = 0;
            LCount = 0;
            ccc = 0;

            toolStripMenuItem_Stop.Enabled = true;
            toolStripButton_Stop.Enabled = true;
            toolStripButton_Start.Enabled = false;
            toolStripMenuItem_Start.Enabled = false;
            toolStripButton_pause.Enabled = true;

            toolStripMenuItem_ModelSettings.Enabled = false;
            toolStripMenuItem_ExportStat.Enabled = false;

            route.Reset();
            bus.Reset();

            ModelTimer.Enabled = true;
        }

        private void ModelTimer_Tick(object sender, EventArgs e)
        {
            if (i == 0)
            {
                Statistics.Clear();
                Statistics.Reset();
            }

            if (i == 1440)
            {
                ModelTimer.Enabled = false;
                Statistics.Count = Count;
                PrintStatistics();

                toolStripMenuItem_ModelSettings.Enabled = true;
                toolStripMenuItem_Stop.Enabled = false;
                toolStripButton_Stop.Enabled = false;
                toolStripButton_Start.Enabled = true;
                toolStripMenuItem_Start.Enabled = true;

                toolStripButton_pause.Enabled = false;
                ModelTimer.Tag = 0;
                toolStripButton_pause.Image = imageList1.Images[0];

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
            Count += LCount;
            ccc += LCount;

            for (int k = 0; k < LCount; k++)
            {
                route.SetPassenger(Distrib.SetPassengerToStation(route.StationsCount), i, Distrib.OutStation(route.StationsCount));
            }

            for (int k = 0; k < route.StationsCount; k++)
            {
                if (route.QueueSize(k) > Statistics.MaxQueueLenght)
                {
                    Statistics.MaxQueueLenght = route.QueueSize(k);
                    Statistics.MaxQueueStation = k;
                    Statistics.MaxQueueTime = i;
                }
            }

            if (i != 0 && i % bus.RidingTime == 0)
            {
                bus.ThrowPassenger(i);
                int n = bus.FreeSeat;
                for (int j = 0; j < n; j++)
                    bus.SetPassenger(route.DequeuePassenger(bus.CurrentStation));
                bus.Ride(route.StationsCount);
            }

            listBox_ModelStations.Items.Clear();

            for (int k = 0; k < route.StationsCount; k++)
            {
                listBox_ModelStations.Items.Add("Остановка №: " + (k + 1) + "\t" + route.QueueSize(k) + " человек на остановке");
            }

            toolStripStatusLabel2.Text = ((i / 60).ToString() + ":" + (i % 60).ToString());

            toolStripStatusLabel1.Text = "Количество людей в ТС: " + (bus.BusCapacity - bus.FreeSeat);
            listBox_ModelStations.SetSelected(bus.CurrentStation, true);

            toolStripProgressBar1.Value = i++;
        }

        // Стоп
        private void toolStripButton_Stop_Click(object sender, EventArgs e)
        {
            ModelTimer.Enabled = false;

            Statistics.Count = Count;
            PrintStatistics();
            Statistics.Reset();

            toolStripMenuItem_Start.Enabled = true;
            toolStripButton_Start.Enabled = true;

            toolStripButton_Stop.Enabled = false;
            toolStripMenuItem_Stop.Enabled = false;
            toolStripButton_pause.Enabled = false;
            ModelTimer.Tag = 0;
            toolStripButton_pause.Image = imageList1.Images[0];

            toolStripMenuItem_ModelSettings.Enabled = true;
        }

        // Изменение скорости моделирования
        private void radioButton_Fast_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Fast.Checked)
            {
                ModelTimer.Interval = 1;
            }
            else
                ModelTimer.Interval = 250;
        }

        // Вывод в файл
        private void toolStripMenuItem_ExportStat_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine("Количество остановок: " + aba.StationCount.ToString());
                    sw.WriteLine("Количество пассажиров: " + aba.PassengerCount.ToString());
                    sw.WriteLine("Время поездки: " + aba.RideTime.ToString() + " мин.");
                    sw.WriteLine("Вместимость ТС: " + aba.Capacity.ToString());
                    sw.WriteLine("Премя первого пика: " + (aba.Peak1 / 60).ToString() + ":" + (aba.Peak1 % 60).ToString());
                    sw.WriteLine("Время второго пика: " + (aba.Peak2 / 60).ToString() + ":" + (aba.Peak2 % 60).ToString());
                    sw.WriteLine("Стоимость проезда: " + aba.Cost.ToString() + " руб.");
                    sw.WriteLine("");
                    sw.WriteLine("Статистика:");
                    sw.WriteLine("Пришло: " + Count + "    Обслуженно: " + Statistics.ServedCount);
                    sw.WriteLine("Самая длинная очередь: " + Statistics.MaxQueueLenght);
                    sw.WriteLine("Остановка с самой длинной очередью: " + (Statistics.MaxQueueStation + 1));
                    sw.WriteLine("Когда образовалась самая длинная очередь: " + ((Statistics.MaxQueueTime / 60).ToString() + " : " + (Statistics.MaxQueueTime % 60).ToString()));
                    sw.WriteLine("Среднее время ожидания ТС пассажиром: " + Math.Floor(Statistics.AvgWaitingTime) + " минут");
                    sw.WriteLine("Вырученная сумма:" + Statistics.Cost(Cost) + " руб.");
                    sw.Flush();
                    sw.Close();
                }
            }
        }

        // Пауза
        private void toolStripButton_pause_Click(object sender, EventArgs e)
        {
            ModelTimer.Enabled = !ModelTimer.Enabled;
            toolStripButton_pause.Image = imageList1.Images[1 - (int)ModelTimer.Tag];
            ModelTimer.Tag = 1 - (int)ModelTimer.Tag;
        }
    }
}
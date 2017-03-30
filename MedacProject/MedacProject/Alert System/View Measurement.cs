﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alert_System.ServiceReference1;

namespace Alert_System
{
    public partial class View_Measurement : Form
    {
        int fk_sns = 0;
        ServiceReference1.Service1Client web = new Service1Client();

        public View_Measurement()
        {
            InitializeComponent();
        }

        private void View_Measurement_Load(object sender, EventArgs e)
        {
            
            /*
            ServiceReference1.Service1Client web = new Service1Client();

            MeasurementDC mt = web.ViewMeasurement(fk_sns);

            textBox1.Text = mt.Bloodpressuremax.ToString();
            textBox2.Text = mt.Bloodpressuremin.ToString();
            textBox3.Text = mt.Heartrate.ToString();
            textBox4.Text = mt.Oxygensaturation.ToString();
            textBox5.Text = mt.Date.ToString();
            textBox6.Text = mt.Time.ToString();
            textBox7.Text = mt.Fk_sns.ToString();

            chart1.Titles.Add("Blood Pressure");
            chart1.Series.Add("Blood Pressure Min");
            chart1.Series.Add("Blood Pressure Max");

            chart1.Series["Blood Pressure Min"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Blood Pressure Max"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            int[] bloodpressureMax = {Convert.ToInt32(textBox1.Text), 100 , 200, 300};
            int[] bloodpressureMin = {Convert.ToInt32(textBox2.Text), 90, 100, 150};

            chart1.Series[1].Points.DataBindXY(bloodpressureMin,bloodpressureMax);
            chart1.Series[2].Points.DataBindXY(bloodpressureMax,bloodpressureMin);
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fk_sns = Convert.ToInt32(textBox8.Text);

            PatientDC p = web.ValidadePatient(Convert.ToInt32(textBox8.Text));

            MessageBox.Show("Bem vindo Sr.(a)" + p.Firstname);
        }

        private void pressuregraph_Click(object sender, EventArgs e)
        {
            //BloodPressureMax

            int[] mtmax = web.ViewBloodPressureMax(fk_sns);

            chart1.Series.Add("Blood Pressure Max");

            chart1.Series["Blood Pressure Max"].ChartArea = "ChartArea1";

            chart1.Titles.Add("Blood Pressure");

            chart1.Series["Blood Pressure Max"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 1; i <= mtmax.Length; i++)
            {
                chart1.Series[1].Points.AddY(Convert.ToInt32(mtmax[i - 1]));
            }
            //BloodPressureMin

            int[] mtmin = web.ViewBloodPressureMin(fk_sns);

            chart1.Series.Add("Blood Pressure Min");

            chart1.Series["Blood Pressure Max"].ChartArea = "ChartArea1";


            chart1.Series["Blood Pressure Min"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 1; i <= mtmin.Length; i++)
            {
                chart1.Series[2].Points.AddY(Convert.ToInt32(mtmin[i - 1]));
            }
        }

        private void heartrategraph_Click(object sender, EventArgs e)
        {
            //Heart Rate
            int[] hr = web.ViewHearRate(fk_sns);

            chart1.Series.Add("Heart Rate");

            chart1.Series["Heart Rate"].ChartArea = "ChartArea1";

            chart1.Titles.Add("Heart Rate");



            chart1.Series["Heart Rate"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 1; i <= hr.Length; i++)
            {
                chart1.Series[1].Points.AddY(Convert.ToInt32(hr[i - 1]));
            }
        }

        private void oxygengraph_Click(object sender, EventArgs e)
        {
            //Oxygen Saturation
            int[] os = web.ViewHearRate(fk_sns);

            chart1.Series.Add("Oxygen Saturation");

            chart1.Series["Oxygen Saturation"].ChartArea = "ChartArea1";

            chart1.Titles.Add("Oxygen Saturation");

            chart1.Series["Oxygen Saturation"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int i = 1; i <= os.Length; i++)
            {
                chart1.Series[1].Points.AddY(Convert.ToInt32(os[i - 1]));
            }
        }
    }
}

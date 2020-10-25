using DbUtils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SQLGraphs
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            chart1.Hide();
        }

        void drawChart()
        {
            /*
            List<double> xAxis = new List<double>();
            List<double> yAxis = new List<double>();

            chart1.Series.Add("Vf2");
            chart1.Series["Vf2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            foreach (Value v in Bf1_Values["Vf2"].Values)
            {
                xAxis.Add(v.d_val);
            }

            foreach (Value v in Bf2_Values["Vf2"].Values)
            {
                yAxis.Add(v.d_val);
            }

            chart1.Series["Vf2"].Points.DataBindXY(xAxis.ToArray(), yAxis.ToArray());
            */        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Show();
            DatabaseAccessor dba = new DatabaseAccessor();
            List<SubjectEntry> subjects = dba.BuildSubjectEntryList();

            List<double> xAxis = new List<double>();
            List<double> yAxis = new List<double>();

            for (int i = 0; i < subjects.Count; i++)
            {
                xAxis.Add(double.Parse(subjects[i].density));
                yAxis.Add(double.Parse(subjects[i].quality));
            }

            chart1.Series.Remove(chart1.Series[0]);
            chart1.Series.Add(new Series());
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            chart1.Series[0].Name = "Density";
            chart1.Series[0].Points.DataBindXY(xAxis.ToArray(), yAxis.ToArray());

            /*
            chart1.Show();
            DatabaseAccessor dba = new DatabaseAccessor();
            List<SubjectEntry> subjects = dba.BuildSubjectEntryList();

            chart1.Series.Remove(chart1.Series[0]);
            chart1.Series.Add(new Series());
            for (int i = 0; i < subjects.Count; i++)
            {
                chart1.Series[0].Points.Add(float.Parse(subjects[i].density));
            }

            chart1.Series[0].XValueMember = "ID";
            chart1.Series[0].YValueMembers = "Density";
            chart1.Series[0].Name = "Density";

            chart1.ChartAreas[0].RecalculateAxesScale();
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Show();
            DatabaseAccessor dba = new DatabaseAccessor();
            List<SubjectEntry> subjects = dba.BuildSubjectEntryList();

            List<double> xAxis = new List<double>();
            List<double> yAxis = new List<double>();

            for (int i = 0; i < subjects.Count; i++)
            {
                xAxis.Add(double.Parse(subjects[i].citricAcid));
                yAxis.Add(double.Parse(subjects[i].quality));
            }

            chart1.Series.Remove(chart1.Series[0]);
            chart1.Series.Add(new Series());
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            chart1.Series[0].Name = "Citric Acid";
            chart1.Series[0].Points.DataBindXY(xAxis.ToArray(), yAxis.ToArray());

            /*
            chart1.Show();
            DatabaseAccessor dba = new DatabaseAccessor();
            List<SubjectEntry> subjects = dba.BuildSubjectEntryList();

            chart1.Series.Remove(chart1.Series[0]);
            chart1.Series.Add(new Series());
            for (int i = 0; i < subjects.Count; i++)
            {
                chart1.Series[0].Points.Add(float.Parse(subjects[i].citricAcid));
            }

            chart1.Series[0].XValueMember = "ID";
            chart1.Series[0].YValueMembers = "Citric Acid";
            chart1.Series[0].Name = "Citric Acid";
            
            chart1.ChartAreas[0].RecalculateAxesScale();
        */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Show();
            DatabaseAccessor dba = new DatabaseAccessor();
            List<SubjectEntry> subjects = dba.BuildSubjectEntryList();

            List<double> xAxis = new List<double>();
            List<double> yAxis = new List<double>();

            for (int i = 0; i < subjects.Count; i++)
            {
                xAxis.Add(double.Parse(subjects[i].sugar));
                yAxis.Add(double.Parse(subjects[i].quality));
            }

            chart1.Series.Remove(chart1.Series[0]);
            chart1.Series.Add(new Series());
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            chart1.Series[0].Name = "Sugar";
            chart1.Series[0].Points.DataBindXY(xAxis.ToArray(), yAxis.ToArray());

            //chart1.Show();
            //DatabaseAccessor dba = new DatabaseAccessor();
            //List<SubjectEntry> subjects = dba.BuildSubjectEntryList();

            //chart1.Series.Remove(chart1.Series[0]);
            //chart1.Series.Add(new Series());
            //for (int i = 0; i < subjects.Count; i++)
            //{
            //    chart1.Series[0].Points.Add(float.Parse(subjects[i].sugar));
            //}

            //chart1.Series[0].XValueMember = "ID";
            //chart1.Series[0].YValueMembers = "Sugar";
            //chart1.Series[0].Name = "Sugar";

            //chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Show();
            DatabaseAccessor dba = new DatabaseAccessor();
            List<SubjectEntry> subjects = dba.BuildSubjectEntryList();

            List<double> xAxis = new List<double>();
            List<double> yAxis = new List<double>();

            for (int i = 0; i < subjects.Count; i++)
            {
                xAxis.Add(double.Parse(subjects[i].chlorides));
                yAxis.Add(double.Parse(subjects[i].quality));
            }

            chart1.Series.Remove(chart1.Series[0]);
            chart1.Series.Add(new Series());
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            chart1.Series[0].Name = "Chlorides";
            chart1.Series[0].Points.DataBindXY(xAxis.ToArray(), yAxis.ToArray());

            //chart1.Show();
            //DatabaseAccessor dba = new DatabaseAccessor();
            //List<SubjectEntry> subjects = dba.BuildSubjectEntryList();

            //chart1.Series.Remove(chart1.Series[0]);
            //chart1.Series.Add(new Series());
            //for (int i = 0; i < subjects.Count; i++)
            //{
            //    chart1.Series[0].Points.Add(float.Parse(subjects[i].chlorides));
            //}

            //chart1.Series[0].XValueMember = "ID";
            //chart1.Series[0].YValueMembers = "Chlorides";
            //chart1.Series[0].Name = "Chlorides";

            //chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Show();
            DatabaseAccessor dba = new DatabaseAccessor();
            List<SubjectEntry> subjects = dba.BuildSubjectEntryList();

            List<double> xAxis = new List<double>();
            List<double> yAxis = new List<double>();

            for (int i = 0; i < subjects.Count; i++)
            {
                xAxis.Add(double.Parse(subjects[i].ph));
                yAxis.Add(double.Parse(subjects[i].quality));
            }

            chart1.Series.Remove(chart1.Series[0]);
            chart1.Series.Add(new Series());
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            chart1.Series[0].Name = "pH";
            chart1.Series[0].Points.DataBindXY(xAxis.ToArray(), yAxis.ToArray());

            //chart1.Show();
            //DatabaseAccessor dba = new DatabaseAccessor();
            //List<SubjectEntry> subjects = dba.BuildSubjectEntryList();

            //chart1.Series.Remove(chart1.Series[0]);
            //chart1.Series.Add(new Series());
            //for (int i = 0; i < subjects.Count; i++)
            //{
            //    chart1.Series[0].Points.Add(float.Parse(subjects[i].ph));
            //}

            //chart1.Series[0].XValueMember = "ID";
            //chart1.Series[0].YValueMembers = "pH";
            //chart1.Series[0].Name = "pH";

            //chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chart1.Show();
            DatabaseAccessor dba = new DatabaseAccessor();
            List<SubjectEntry> subjects = dba.BuildSubjectEntryList();

            List<double> xAxis = new List<double>();
            List<double> yAxis = new List<double>();

            for (int i = 0; i < subjects.Count; i++)
            {
                xAxis.Add(double.Parse(subjects[i].sulphates));
                yAxis.Add(double.Parse(subjects[i].quality));
            }

            chart1.Series.Remove(chart1.Series[0]);
            chart1.Series.Add(new Series());
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            chart1.Series[0].Name = "Sulphates";
            chart1.Series[0].Points.DataBindXY(xAxis.ToArray(), yAxis.ToArray());

            //chart1.Show();
            //DatabaseAccessor dba = new DatabaseAccessor();
            //List<SubjectEntry> subjects = dba.BuildSubjectEntryList();

            //chart1.Series.Remove(chart1.Series[0]);
            //chart1.Series.Add(new Series());
            //for (int i = 0; i < subjects.Count; i++)
            //{
            //    chart1.Series[0].Points.Add(float.Parse(subjects[i].sulphates));
            //}

            //chart1.Series[0].XValueMember = "ID";
            //chart1.Series[0].YValueMembers = "Sulphates";
            //chart1.Series[0].Name = "Sulphates";

            //chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chart1.Show();
            DatabaseAccessor dba = new DatabaseAccessor();
            List<SubjectEntry> subjects = dba.BuildSubjectEntryList();

            List<double> xAxis = new List<double>();
            List<double> yAxis = new List<double>();

            for (int i = 0; i < subjects.Count; i++)
            {
                xAxis.Add(double.Parse(subjects[i].alcohol));
                yAxis.Add(double.Parse(subjects[i].quality));
            }

            chart1.Series.Remove(chart1.Series[0]);
            chart1.Series.Add(new Series());
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            chart1.Series[0].Name = "Alcohol";
            chart1.Series[0].Points.DataBindXY(xAxis.ToArray(), yAxis.ToArray());

            //chart1.Show();
            //DatabaseAccessor dba = new DatabaseAccessor();
            //List<SubjectEntry> subjects = dba.BuildSubjectEntryList();

            //chart1.Series.Remove(chart1.Series[0]);
            //chart1.Series.Add(new Series());
            //for (int i = 0; i < subjects.Count; i++)
            //{
            //    chart1.Series[0].Points.Add(float.Parse(subjects[i].alcohol));
            //}

            //chart1.Series[0].XValueMember = "ID";
            //chart1.Series[0].YValueMembers = "Alcohol %";
            //chart1.Series[0].Name = "Alcohol %";

            //chart1.ChartAreas[0].RecalculateAxesScale();
        }
    }
}

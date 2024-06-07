using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ServiceAuto_Client.Language;

namespace ServiceAuto_Client.View
{
    public partial class StatisticsGUI : Form, Observable
    {
        private int index;

        public StatisticsGUI(int index)
        {
            InitializeComponent();
            this.comboBoxChangeLanguage.SelectedIndex = index;
        }

        public Button GetBackButton()
        {
            return this.buttonBack;
        }

        public ComboBox GetCriterion()
        {
            return this.comboBoxCriterion;
        }

        public ComboBox GetLanguageBox()
        {
            return this.comboBoxChangeLanguage;
        }

        public Chart GetChart()
        {
            return this.chartCarStatistics;
        }

        public void ClearChart()
        {
            this.chartCarStatistics.Series.Clear();
            this.chartCarStatistics.Legends.Clear();
        }

        public void SetLegendsChart(string seriesName)
        {
            this.chartCarStatistics.Legends.Add(seriesName);
            this.chartCarStatistics.Legends[0].LegendStyle = LegendStyle.Table;
            this.chartCarStatistics.Legends[0].Docking = Docking.Right;
            this.chartCarStatistics.Legends[0].Alignment = StringAlignment.Center;
            this.chartCarStatistics.Legends[0].Title = seriesName;
            this.chartCarStatistics.Legends[0].BorderColor = Color.Black;
        }

        public void SetSeriesChart(Dictionary<string, uint> list, string seriesName)
        {
            this.chartCarStatistics.Series.Add(seriesName);
            this.chartCarStatistics.Series[seriesName].ChartType = SeriesChartType.Pie;
            foreach (KeyValuePair<string, uint> pair in list)
                this.chartCarStatistics.Series[seriesName].Points.AddXY(pair.Key, pair.Value);
            foreach (DataPoint p in this.chartCarStatistics.Series[seriesName].Points)
                p.Label = "#PERCENT";
            this.chartCarStatistics.Series[seriesName].LegendText = "#VALX";
        }

        public void SetTitleChart(string title)
        {
            this.chartCarStatistics.Titles.Clear();
            this.chartCarStatistics.Titles.Add(title);
            this.chartCarStatistics.Titles[0].Docking = Docking.Top;
            this.chartCarStatistics.Titles[0].Alignment = ContentAlignment.MiddleRight;
            this.chartCarStatistics.Titles[0].Font = new Font("Times New Roman", 15, FontStyle.Bold);
        }

        public void Update(Subject obs)
        {
            LangHelper lang = (LangHelper)obs;
            this.labelSelectCriterion.Text = lang.GetString("labelCriterion");
            this.labelChangeLanguage.Text = lang.GetString("labelChangeLanguage");
            this.buttonBack.Text = lang.GetString("buttonBack");
        }
    }
}

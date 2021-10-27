using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week06.MnbServiceReference;
using week06.Entities;
using System.Xml;
using System.Windows.Forms.DataVisualization.Charting;

namespace week06
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<string> Currencies = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            GetCurrencies();
            RefreshData();
        }
        private void GetCurrencies()
        {
            MNBArfolyamServiceSoapClient mnbService = new MNBArfolyamServiceSoapClient();
            GetCurrenciesRequestBody request = new GetCurrenciesRequestBody();
            var response = mnbService.GetCurrencies(request);
            var result = response.GetCurrenciesResult;
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);
            foreach (XmlElement item in xml.DocumentElement.ChildNodes[0])
            {
                string newItem = item.InnerText;
                Currencies.Add(newItem);
            }
            comboBox1.DataSource = Currencies;
        }
        private void RefreshData()
        {
            string currency = (string)comboBox1.SelectedItem;
            string startDate = dateTimeFrom.Value.ToString();
            string endDate = dateTimeTo.Value.ToString();
            Rates.Clear();
            string result = GetData(currency, startDate, endDate);
            ProcessData(result);
            CreateChart();
        }
        private string GetData(string currency, string startDate, string endDate)
        {
            MNBArfolyamServiceSoapClient mnbService = new MNBArfolyamServiceSoapClient();
            GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody();
            request.currencyNames = currency;
            request.startDate = startDate;
            request.endDate = endDate;
            var response = mnbService.GetExchangeRates(request);
            string result = response.GetExchangeRatesResult;
            return result;
        }

        private void ProcessData(string result)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);
            foreach (XmlElement item in xml.DocumentElement)
            {
                RateData newData = new RateData();
                newData.Date = Convert.ToDateTime(item.GetAttribute("date"));
                var child = (XmlElement)item.ChildNodes[0];
                if(child == null)
                {
                    continue;
                }
                newData.Currency = child.GetAttribute("curr");
                decimal unit = decimal.Parse(child.GetAttribute("unit"));
                var value = decimal.Parse(child.InnerText) * unit;
                if(unit != 0)
                {
                    newData.Value = value / unit;
                }
                Rates.Add(newData);
            }
            dataGridView1.DataSource = Rates;
        }
        private void CreateChart()
        {
            chartRateData.DataSource = Rates;
            var firstLine = chartRateData.Series[0];
            firstLine.ChartType = SeriesChartType.Line;
            firstLine.XValueMember = "Date";
            firstLine.YValueMembers = "Value";
            firstLine.BorderWidth = 2;
            chartRateData.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartRateData.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartRateData.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chartRateData.Legends[0].Enabled = false;

        }

        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }

}

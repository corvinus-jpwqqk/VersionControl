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

namespace week06
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();


        public Form1()
        {
            InitializeComponent();
            string result = GetData();
            ProcessData(result);
            dataGridView1.DataSource = Rates;
            
        }
        private string GetData()
        {
            MNBArfolyamServiceSoapClient mnbService = new MNBArfolyamServiceSoapClient();
            GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody();
            request.currencyNames = "EUR";
            request.startDate = "2020-01-01";
            request.endDate = "2020-06-30";
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
                newData.Currency = child.GetAttribute("curr");
                decimal unit = decimal.Parse(child.GetAttribute("unit"));
                var value = decimal.Parse(child.InnerText) * unit;
                if(unit != 0)
                {
                    newData.Value = value / unit;
                }
                Rates.Add(newData);
            }
        }
    }

}

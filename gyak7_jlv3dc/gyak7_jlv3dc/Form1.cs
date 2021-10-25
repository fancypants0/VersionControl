using gyak7_jlv3dc.mnb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace gyak7_jlv3dc
{
    public partial class Form1 : Form
    {
        MNBArfolyamServiceSoapClient mnb_service = new MNBArfolyamServiceSoapClient();
        GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody();

        GetExchangeRatesResponseBody response;
        string result;

        BindingList<rate> rates = new BindingList<rate>();

        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = rates;
            chart1.DataSource = rates;

            get_rates();
            egy_a_form1_konstruktorabol_meghivott_kulon_fuggveny();
        }

        void get_rates()
        {
            request.currencyNames = "EUR";
            request.startDate = "2020-01-01";
            request.endDate = "2020-06-30";

            response = mnb_service.GetExchangeRates(request);
            result = response.GetExchangeRatesResult;
        }

        void egy_a_form1_konstruktorabol_meghivott_kulon_fuggveny()
        {
            XmlDocument xd = new XmlDocument();
            xd.LoadXml(result);

            foreach (XmlElement n in xd.DocumentElement)
            {
                rate r = new rate();
                r.date = DateTime.Parse(n.GetAttribute("date"));
                rates.Add(r);

                XmlElement child = (XmlElement)n.ChildNodes[0];
                r.currency = child.GetAttribute("curr");

                decimal unit = decimal.Parse(child.GetAttribute("unit"));
                decimal value = decimal.Parse(child.InnerText);
                if (unit != 0) r.value = value / unit;
            }

            //chart1.SeriesChartType = SeriesChartType.Line;

            Series s = chart1.Series[0];
            s.ChartType = SeriesChartType.Line;
            s.XValueMember = "Date";
            s.YValueMembers = "Value";
            s.BorderWidth = 2;

            chart1.Legends[0].Enabled = false;

            ChartArea a = chart1.ChartAreas[0];
            a.AxisX.MajorGrid.Enabled = false;
            a.AxisY.MajorGrid.Enabled = false;
            a.AxisY.IsStartedFromZero = false;
        }
    }
}
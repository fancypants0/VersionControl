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

namespace gyak7_jlv3dc
{
    public partial class Form1 : Form
    {
        MNBArfolyamServiceSoapClient mnb_service = new MNBArfolyamServiceSoapClient();
        GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody();

        BindingList<rate> rates = new BindingList<rate>();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = rates;
            get_rates();
        }

        void get_rates()
        {
            request.currencyNames = "EUR";
            request.startDate = "2020-01-01";
            request.endDate = "2020-06-30";

            var response = mnb_service.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;
        }
    }
}
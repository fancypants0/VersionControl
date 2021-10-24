using gyak06_jlv3dc.mappa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyak06_jlv3dc
{
    public partial class Form1 : Form
    {
        List<decimal> earnings = new List<decimal>();
        List<item> portfolio = new List<item>();
        List<Tick> ticks;

        public Form1()
        {
            InitializeComponent();

            PortfolioEntities context = new PortfolioEntities();
            context.Ticks.Load();
            ticks = context.Ticks.ToList();
            dataGridView1.DataSource = ticks;

            create();
            //komplex();
        }

        void create()
        {
            portfolio.Add(new item() { index = "OTP",   volume = 10 });
            portfolio.Add(new item() { index = "ZWACK", volume = 10 });
            portfolio.Add(new item() { index = "ELMU",  volume = 10 });

            dataGridView2.DataSource = portfolio;
        }

        private decimal get_value(DateTime date)
        {
            decimal d = 0;
            foreach (var n in portfolio)
            {
                var last = (from x in ticks where n.index == x.Index.Trim() && date <= x.TradingDay select x).First();

                d += last.Price * n.volume;
            }
            return d;
        }

        void komplex()
        {
            DateTime begin = (from x in ticks select x.TradingDay).Min();
            DateTime end = new DateTime(2016, 12, 30);

            for (int i = 0; i < (end - begin).Days - 30; i++)
            {
                decimal ny = get_value(begin.AddDays(i + 30)) - get_value(begin.AddDays(i));
                earnings.Add(ny);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            komplex();

            earnings = (from x in earnings orderby x select x).ToList();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter ="Text File | *.txt";
            sfd.FileName = "Kimutatás1";
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine("Időszak,Nyereség");
                for (int i = 0; i < earnings.Count; i++) sw.WriteLine((i + 1).ToString() + "," + earnings[i].ToString());
                sw.Close();
                MessageBox.Show("Nyereség elmentve!");
            }
        }
    }
}
using gyak06_jlv3dc.mappa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyak06_jlv3dc
{
    public partial class Form1 : Form
    {
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
            komplex();
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
            List<decimal> Nyereségek = new List<decimal>();
            int intervalum = 30;
            DateTime kezdőDátum = (from x in ticks select x.TradingDay).Min();
            DateTime záróDátum = new DateTime(2016, 12, 30);
            TimeSpan z = záróDátum - kezdőDátum;
            for (int i = 0; i < z.Days - intervalum; i++)
            {
                decimal ny = get_value(kezdőDátum.AddDays(i + intervalum))
                           - get_value(kezdőDátum.AddDays(i));
                Nyereségek.Add(ny);
                Console.WriteLine(i + " " + ny);
            }

            var nyereségekRendezve = (from x in Nyereségek
                                      orderby x
                                      select x)
                                        .ToList();
            MessageBox.Show(nyereségekRendezve[nyereségekRendezve.Count() / 5].ToString());
        }
    }
}
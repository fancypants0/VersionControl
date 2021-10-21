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
        }

        void create()
        {
            portfolio.Add(new item() { index = "OTP",   volume = 10 });
            portfolio.Add(new item() { index = "ZWACK", volume = 10 });
            portfolio.Add(new item() { index = "ELMU",  volume = 10 });

            dataGridView2.DataSource = portfolio;
        }
    }
}

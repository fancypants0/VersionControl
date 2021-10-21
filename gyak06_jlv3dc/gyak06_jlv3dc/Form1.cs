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
        List<Tick> ticks; 

        public Form1()
        {
            InitializeComponent();
            PortfolioEntities context = new PortfolioEntities();
            context.Ticks.Load();
            ticks = context.Ticks.ToList();
            dataGridView1.DataSource = ticks;
        }
    }
}

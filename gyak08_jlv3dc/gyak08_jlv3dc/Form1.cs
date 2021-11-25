using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyak08_jlv3dc
{
    public partial class Form1 : Form
    {
        List<toy> toys = new List<toy>();

        private interface_factory I;
        public interface_factory factory { get { return I; } set { I = value; } }

        public Form1()
        {
            InitializeComponent();
            factory = new factory_ball();
        }

        private void t_create_Tick(object sender, EventArgs e)
        {
            toy t;
            if (b_product.Text == "Ball") t = new ball();
            else t = new car();

            t.Left = -t.Width;
            t.Top = 150;
            toys.Add(t);
            p_main.Controls.Add(t);
        }

        private void t_conveyor_Tick(object sender, EventArgs e)
        {
            foreach (toy n in toys) n.moving();

            if (toys.Count == 0) return;
            if (toys[0].Left>1000) { p_main.Controls.Remove(toys[0]); toys.RemoveAt(0); }
        }

        private void b_product_Click(object sender, EventArgs e)
        {
            if (b_product.Text == "Ball") b_product.Text = "Car";
            else b_product.Text = "Ball";
        }
    }
}
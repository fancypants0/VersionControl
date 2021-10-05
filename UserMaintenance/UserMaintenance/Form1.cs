using System;
using System.ComponentModel;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<user> users = new BindingList<user>();

        public Form1()
        {
            InitializeComponent();

            l_fist.Text = label_txt.first;
            l_last.Text = label_txt.last;
            b_save.Text = label_txt.save;

            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "full_name";
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            user u = new user();
            u.first_name = tb_first.Text;
            u.last_name = tb_last.Text;
            users.Add(u);
        }
    }
}

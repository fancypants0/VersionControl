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

            b_save.Text = txt.save;
            b_write.Text = txt.write_to_file;

            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "full_name";
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            user u = new user();
            u.full_name = tb_first.Text + " " + tb_last.Text;
            users.Add(u);
        }

        private void b_write_Click(object sender, EventArgs e)
        {
            //what
        }
    }
}
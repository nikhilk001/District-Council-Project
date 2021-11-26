using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;
                if (user == "abc" && pass == "abc") 
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
                else
            {
                MessageBox.Show("Please Enter valid credentials");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This service is currently not available");
        }
    }
}

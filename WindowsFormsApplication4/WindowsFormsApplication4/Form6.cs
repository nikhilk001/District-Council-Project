using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class Form6 : Form
    {
        string connectionString = @"Data Source=.;Initial Catalog=mgnrga;Integrated Security=True;";
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'mgnrgaDataSet.labour' table. You can move, or remove it, as needed.
            


        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM LABOUR", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                this.labourTableAdapter.Fill(this.mgnrgaDataSet.labour);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

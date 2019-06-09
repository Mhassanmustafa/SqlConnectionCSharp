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

namespace SqlConnectionCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            SqlConnection connection = new SqlConnection(config.connection);
            connection.Open();
            if(connection != null)
            {
                MessageBox.Show("Connection with sql is successfull");

            }
            else
            {
                MessageBox.Show("Connection with sql is not successfull");
            }
        }
    }
}

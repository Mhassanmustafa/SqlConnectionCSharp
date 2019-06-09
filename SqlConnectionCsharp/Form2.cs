using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SqlConnectionCsharp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
          
            InitializeComponent();
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            Hashtable param = new Hashtable();
            Config config = new Config();
            SqlConnection connection = new SqlConnection(config.connection);
            connection.Open();
            if (connection != null)
            {
                String query = "insert into table_1 (id,name,rollno) values ( "+idField.Text+",'"+nameField.Text+"',"+amountField.Text+")";
                

                SqlCommand cmd = new SqlCommand(query, connection);
               
                cmd.ExecuteNonQuery();
               
                MessageBox.Show("Inserted successfully");
                idField.Clear();
                nameField.Clear();
                amountField.Clear();
            }
        }

        private void showData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            SqlConnection connection = new SqlConnection(config.connection);
            connection.Open();
            string quuery = "select * from table_1";

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(quuery, connection);
            sqlData.Fill(dataTable);

            showData.DataSource = dataTable;
        }
    }
}

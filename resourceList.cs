using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class resourceList : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=MRP;Integrated Security=True;TrustServerCertificate=True");

        public resourceList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedProductName = comboBox1.Text;
            string query = @"
    SELECT m.MName, s.AmountStock
    FROM Material m
    INNER JOIN Product p ON m.PID = p.PID
    INNER JOIN Stock s ON m.MID = s.MID

    WHERE p.PName = @ProductName;
";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductName", selectedProductName);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
           




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resourceList_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT PName,PID from Product", connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);          
            }
            connection.Close();
        }
    }
}

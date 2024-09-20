using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class depo : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=MRP;Integrated Security=True;TrustServerCertificate=True");

        public depo()
        {
            InitializeComponent();
        }

        private void depo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mRPDataSet.Stock' table. You can move, or remove it, as needed.
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Visible = true;
            prost.Enabled = false;
            mstockbttn.Enabled = true;
            


            string query = @"
    SELECT s.StockNo, s.PID, p.PName  ,s.AmountStock, s.StockDate
    FROM Stock s
    INNER JOIN Product p ON s.PID = p.PID
    WHERE s.PID IS NOT NULL;
    "; 
            SqlCommand command = new SqlCommand(query, connection);
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

            private void mstockbttn_Click(object sender, EventArgs e)
        {
            prost.Enabled = true;
            mstockbttn.Enabled = false;
            dataGridView1.DataSource = null;
            dataGridView1.Visible = true;

            string query = @"
    SELECT s.StockNo, s.MID, p.MName ,s.AmountStock, s.StockDate
    FROM Stock s
    INNER JOIN Material p ON s.MID = p.MID
    WHERE s.MID IS NOT NULL;
    ";
            SqlCommand command = new SqlCommand(query, connection);
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
            HashSet<string> uniqueRows = new HashSet<string>();

            
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                string rowKey = "";

                
                foreach (DataGridViewCell cell in row.Cells)
                {
                    rowKey += cell.Value?.ToString() ?? ""; 
                }

                
                if (uniqueRows.Contains(rowKey))
                {
                    
                    dataGridView1.Rows.RemoveAt(i);
                }
                else
                {
                    
                    uniqueRows.Add(rowKey);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

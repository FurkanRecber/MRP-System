using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static WindowsFormsApp1.MRPDataSet;

namespace WindowsFormsApp1
{
    public partial class Order : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=MRP;Integrated Security=True;TrustServerCertificate=True");
        public string connectionString = "Data Source=Furkan\\SQLEXPRESS;Initial Catalog=MRP;Integrated Security=True;TrustServerCertificate=True";
        public Order()
        {
            InitializeComponent();
        }
        private void Order_Load(object sender, EventArgs e)
        {
            refresh();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT PName from Product", connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                product.Items.Add(dr[0]);
            }
            connection.Close();


        }
        public int AmountStock;
        public int saleNo;
        void sold(string PName)
        {
            
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT AmountStock from Stock where PID=(Select PID from Product where PName=@p1)", connection);
            command.Parameters.AddWithValue("@p1", PName); 
            SqlDataReader dr = command.ExecuteReader();
        
            while (dr.Read())
            {
                Debug.WriteLine("Sold Product: "+ dr[0]);
                AmountStock = Convert.ToInt32(dr[0]);                
            }
            connection.Close();
            connection.Open();
            if (AmountStock - ammount.Value > 0)
            {
                SqlCommand command2 = new SqlCommand("Update Stock set AmountStock=AmountStock-@p1 where PID=(Select PID from Product where PName=@p2)", connection);
                command2.Parameters.AddWithValue("@p1", ammount.Value);
                command2.Parameters.AddWithValue("@p2", PName);
                command2.ExecuteNonQuery();
            }
            else
            {
                SqlCommand command2 = new SqlCommand("Update Sale set isOK=0 where SaleNo=@p1",connection);
                command2.Parameters.AddWithValue("@p1", saleNo);
                command2.ExecuteNonQuery();
                Debug.WriteLine("Satış Alınamadı.");
                MessageBox.Show("Not Enough Stock","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            connection.Close();
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            
            if (result == DialogResult.OK)
            {
                string saleQuery = @"
            INSERT INTO Sale (SaleDate, AmountSale, PName, PType, isOk) 
            OUTPUT INSERTED.SaleNo
            VALUES (@SaleDate, @AmountSale, @PName, 
            (SELECT PType FROM Product WHERE PName = @PName), @isOk)";

               
                string purchaseQuery = @"
            INSERT INTO Purchase (SaleNo, PID, PersonName, PersonAddr) 
            VALUES (@SaleNo,(SELECT PID FROM Product WHERE PName = @PName), @PersonName, @PersonAddr)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            
                            
                            using (SqlCommand saleCommand = new SqlCommand(saleQuery, connection, transaction))
                            {
                                saleCommand.Parameters.AddWithValue("@SaleDate", DateTime.Now);
                                saleCommand.Parameters.AddWithValue("@AmountSale", ammount.Value);
                                saleCommand.Parameters.AddWithValue("@PName", product.Text);
                                if (checkBox1.Checked)
                                    saleCommand.Parameters.AddWithValue("@isOk", 1);
                                else
                                    saleCommand.Parameters.AddWithValue("@isOk", 0);
                                
                                saleNo = (int)saleCommand.ExecuteScalar();
                            }

                            
                            using (SqlCommand purchaseCommand = new SqlCommand(purchaseQuery, connection, transaction))
                            {
                                purchaseCommand.Parameters.AddWithValue("@SaleNo", saleNo);
                                purchaseCommand.Parameters.AddWithValue("@PName", product.Text);
                                purchaseCommand.Parameters.AddWithValue("@PersonName", name.Text);
                                purchaseCommand.Parameters.AddWithValue("@PersonAddr", adress.Text);

                                purchaseCommand.ExecuteNonQuery();
                            }

                            
                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

                if (checkBox1.Checked)
                    sold(product.Text);

                refresh();
        }
        }

        private void refresh()
        {
            string query = @"
            SELECT        
            Purchase.SaleNo, Sale.PName, Sale.AmountSale, Purchase.PersonName, Purchase.PersonAddr, Sale.SaleDate, Sale.isOK 
            FROM Purchase 
            INNER JOIN Sale ON Purchase.SaleNo = Sale.SaleNo";

            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            dataGridView1.DataSource = dataTable;
        }
        public int Sale_no;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            Sale_no = Convert.ToInt32(dataGridView1.Rows[choosen].Cells[0].Value.ToString());
            adress.Text = dataGridView1.Rows[choosen].Cells[4].Value.ToString();
            name.Text = dataGridView1.Rows[choosen].Cells[3].Value.ToString();
            product.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            ammount.Value = Convert.ToInt32(dataGridView1.Rows[choosen].Cells[2].Value.ToString());
            adress.Text= dataGridView1.Rows[choosen].Cells[4].Value.ToString();
            if (Convert.ToInt32(dataGridView1.Rows[choosen].Cells[6].Value) == 1)
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {   
                    
               
                connection.Open();
                SqlCommand command = new SqlCommand("update Sale set isOK=@p1 where SaleNo=@p2", connection);
                command.Parameters.AddWithValue("@P1", 1);
                command.Parameters.AddWithValue("@P2", Sale_no);
                command.ExecuteNonQuery();
                connection.Close();
                refresh();
            }
            sold(product.Text);
        }   
    }
}
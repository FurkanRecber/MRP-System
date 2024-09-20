using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace WindowsFormsApp1
{
    public partial class production : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=MRP;Integrated Security=True;TrustServerCertificate=True");

        public production()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void production_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("test");
            probut.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;

            productionCount.Enabled = false;
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT PName from Product", connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productionCount.Enabled = true;
            probut.Enabled = false;
            button2.Enabled = true;

            refresh();

            


        }
        void refresh()
        {
            string selectedProductName = comboBox1.Text;
            string query = @"
    SELECT m.MID, m.MName, s.AmountStock
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
            query = @"
    SELECT pc.producttime, pc.capacity, s.AmountStock
    FROM product_capacity pc
    JOIN product p ON pc.PID = p.PID
    LEFT JOIN Stock s ON p.PID = s.PID
    WHERE p.PName = @ProductName;
";
            connection.Open();
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductName", selectedProductName);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                capa.Text = reader[2].ToString() + "/" + reader[1].ToString();
                time.Text = reader[0].ToString() + " Hours";

            }

            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            button1.Enabled = true;
            button2.Enabled = false;
            probut.Enabled = false;
        }

        private void probut_Click(object sender, EventArgs e)
        {
            List<string> columnValues = new List<string>();
            int columnIndex = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCell cell = row.Cells[columnIndex];
                string cellValue = cell.Value?.ToString();
                columnValues.Add(cellValue);
            }
            foreach (var i in columnValues)
            { 
                Debug.WriteLine(i);
                connection.Open();
                SqlCommand commands = new SqlCommand("UPDATE Stock set AmountStock=AmountStock - @p1 where MID=@P2 ", connection);
                commands.Parameters.AddWithValue("@p1", productionCount.Text);
                commands.Parameters.AddWithValue("@p2", Convert.ToInt16(i));
                commands.ExecuteNonQuery();
                connection.Close();


            }
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE Stock set AmountStock=AmountStock + @p1 where PID=(SELECT PID from Product where PName=@p2) ", connection);
            command.Parameters.AddWithValue("@p1", productionCount.Text);
            command.Parameters.AddWithValue("@p2", comboBox1.Text);
            command.ExecuteNonQuery();
            connection.Close();

            refresh();











            }

        private void button2_Click(object sender, EventArgs e)
        { 
            List<string> columnValues = new List<string>();
            int columnIndex = 1;
            Boolean canBe = true;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCell cell = row.Cells[columnIndex];
                string cellValue = cell.Value?.ToString(); 
                columnValues.Add(cellValue);
            }
            foreach (var i in columnValues)
            {
                if (i != null)
                {
                    
                    string queryy = @"
       SELECT AmountStock
FROM Stock
WHERE MID IN (
    SELECT MID
    FROM Material
    WHERE MName = @MaterialName)
";             
                    connection.Open();
                    SqlCommand commands = new SqlCommand(queryy, connection);
                    commands.Parameters.AddWithValue("@MaterialName", i.ToString());
                    SqlDataReader reader = commands.ExecuteReader(); 
                    
                    while (reader.Read())
                    {
                        Debug.WriteLine(i.ToString()+" Material Stock : "+reader[0].ToString());
                        if (productionCount.Value > Convert.ToInt32(reader[0]))
                        {
                            probut.Enabled = false;
                            canBe = false;
                            MessageBox.Show(productionCount.Value-Convert.ToInt32(reader[0]) +" set "+i+" is/are missing", "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            break;
                        }
                    }
                    connection.Close();
                }
            }
            string query = @"
       SELECT s.AmountStock, pc.Capacity
FROM Stock s
INNER JOIN Product p ON s.PID = p.PID
INNER JOIN Product_Capacity pc ON p.PID = pc.PID
WHERE p.PName = @ProductName;
";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductName", comboBox1.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Debug.WriteLine(comboBox1.Text+" Product Amount Stock : "+dr[0].ToString());
                Debug.WriteLine(comboBox1.Text + " Product Capacity Stock : " + dr[1].ToString());
                if (Convert.ToInt16(dr[0]) + productionCount.Value > Convert.ToInt16(dr[1]))
                {
                    MessageBox.Show("Stock Capacity is not enough for this production.","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    probut.Enabled = false;
                    canBe = false;
                    break;
                }
            }
            connection.Close();

            if (canBe)
                probut.Enabled = true;
        }
    }
}

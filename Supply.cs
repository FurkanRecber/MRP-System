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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Supply : Form
    {


        SqlConnection connection = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=MRP;Integrated Security=True;TrustServerCertificate=True");

        public Supply()
        {
            InitializeComponent();
        }

        private void Supply_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mRPDataSet.Supply' table. You can move, or remove it, as needed.
            this.supplyTableAdapter.Fill(this.mRPDataSet.Supply);
            connection.Open();
            SqlCommand command = new SqlCommand("Select SName from Supplier", connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            connection.Close();
            connection.Open();

            command = new SqlCommand("Select MName,MID from Material", connection);
            dr = command.ExecuteReader();
            while (dr.Read())
            {           
                 comboBox2.Items.Add(dr[0]);
            }
            for (int i = 0; i < comboBox2.Items.Count; i++)
            {
                for (int j = i + 1; j < comboBox2.Items.Count; j++)
                {
                    if (comboBox2.Items[i].Equals(comboBox2.Items[j]))
                    {
                        comboBox2.Items.RemoveAt(j);
                        j--;
                    }
                }
            }
            connection.Close();
        }

        private void saleBut_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string dates = currentDate.ToString("dd/MM/yyyy");
            date.Text = dates;
            connection.Open();
            SqlCommand command = new SqlCommand("Select SID from Supplier where SName=@p1", connection);
            command.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                SID.Text = dr[0].ToString();
            }
            connection.Close();

            connection.Open();
            command = new SqlCommand("Select MID from Material where MName=@p1", connection);
            command.Parameters.AddWithValue("@p1", comboBox2.Text);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                MID.Text = dr[0].ToString(); 
            }
            connection.Close();


            connection.Open();
            command = new SqlCommand("INSERT INTO Supply (SID, MID, AmountSupply, SName, SupplyDate) VALUES (@p1, @p2, @p3, @p4, @p5)", connection);
            command.Parameters.AddWithValue("@p1", SID.Text);
            command.Parameters.AddWithValue("@p2", MID.Text);
            command.Parameters.AddWithValue("@p3", amount.Text);
            command.Parameters.AddWithValue("@p4", comboBox1.Text);
            command.Parameters.AddWithValue("@p5", currentDate);
            command.ExecuteNonQuery();
            connection.Close();
            

            connection.Open();
            command = new SqlCommand("UPDATE Stock set AmountStock=AmountStock +@p1 where MID=@P2", connection);
            command.Parameters.AddWithValue("@p1", amount.Text);
            command.Parameters.AddWithValue("@p2", MID.Text);
            command.ExecuteNonQuery();
            connection.Close();

            this.supplyTableAdapter.Fill(this.mRPDataSet.Supply);













        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
               
        }
    }
}


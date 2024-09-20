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
namespace WindowsFormsApp1
{
    public partial class supplier : Form
    {



        public supplier()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=MRP;Integrated Security=True;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into Supplier (SNAME,Contact) values (@P1,@P2)", connection);
            command.Parameters.AddWithValue("@P1",nameSupText.Text);
            command.Parameters.AddWithValue("@P2", numberSupText.Text);
            command.ExecuteNonQuery();
            connection.Close();
            this.supplierTableAdapter.Fill(this.mRPDataSet.Supplier);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SID.Text != null)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from Supplier where SID=@p1", connection);
                command.Parameters.AddWithValue("@P1", SID.Text);
                command.ExecuteNonQuery();
                connection.Close();
                this.supplierTableAdapter.Fill(this.mRPDataSet.Supplier);
            }
        }


        private void supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mRPDataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.mRPDataSet.Material);
            // TODO: This line of code loads data into the 'mRPDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.mRPDataSet.Supplier);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;

            nameSupText.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            numberSupText.Text = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            SID.Text= dataGridView1.Rows[choosen].Cells[0].Value.ToString();
        }
        private void UpdSupp_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update Supplier set SNAME = @p1,Contact= @p2 WHERE SID=@p3", connection);
            command.Parameters.AddWithValue("@P1" ,nameSupText.Text);
            command.Parameters.AddWithValue("@P2" ,numberSupText.Text);
            command.Parameters.AddWithValue("@P3", SID.Text);
            command.ExecuteNonQuery();
            connection.Close();
            this.supplierTableAdapter.Fill(this.mRPDataSet.Supplier);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mRPDataSet.Material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.mRPDataSet.Material);

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            supplier form = new supplier();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Supply form = new Supply();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            depo form = new depo();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void resourseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            resourceList form = new resourceList();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void buyingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            production form = new production();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Order form = new Order();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void oRDERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }
    }
}

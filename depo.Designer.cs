namespace WindowsFormsApp1
{
    partial class depo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mRPDataSet = new WindowsFormsApp1.MRPDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new WindowsFormsApp1.MRPDataSetTableAdapters.StockTableAdapter();
            this.prost = new System.Windows.Forms.Button();
            this.mstockbttn = new System.Windows.Forms.Button();
            this.depopanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mRPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.depopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mRPDataSet
            // 
            this.mRPDataSet.DataSetName = "MRPDataSet";
            this.mRPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.mRPDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // prost
            // 
            this.prost.Location = new System.Drawing.Point(105, 30);
            this.prost.Name = "prost";
            this.prost.Size = new System.Drawing.Size(161, 47);
            this.prost.TabIndex = 1;
            this.prost.Text = "Show Product Stock";
            this.prost.UseVisualStyleBackColor = true;
            this.prost.Click += new System.EventHandler(this.button1_Click);
            // 
            // mstockbttn
            // 
            this.mstockbttn.Location = new System.Drawing.Point(475, 30);
            this.mstockbttn.Name = "mstockbttn";
            this.mstockbttn.Size = new System.Drawing.Size(183, 47);
            this.mstockbttn.TabIndex = 2;
            this.mstockbttn.Text = "Show Material Stock";
            this.mstockbttn.UseVisualStyleBackColor = true;
            this.mstockbttn.Click += new System.EventHandler(this.mstockbttn_Click);
            // 
            // depopanel
            // 
            this.depopanel.Controls.Add(this.dataGridView1);
            this.depopanel.Location = new System.Drawing.Point(1, 115);
            this.depopanel.Name = "depopanel";
            this.depopanel.Size = new System.Drawing.Size(800, 335);
            this.depopanel.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // depo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.depopanel);
            this.Controls.Add(this.mstockbttn);
            this.Controls.Add(this.prost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "depo";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.depo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mRPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.depopanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MRPDataSet mRPDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private MRPDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.Button prost;
        private System.Windows.Forms.Button mstockbttn;
        private System.Windows.Forms.Panel depopanel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
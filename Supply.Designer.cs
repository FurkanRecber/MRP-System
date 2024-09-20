namespace WindowsFormsApp1
{
    partial class Supply
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountSupplyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mRPDataSet = new WindowsFormsApp1.MRPDataSet();
            this.supplyTableAdapter = new WindowsFormsApp1.MRPDataSetTableAdapters.SupplyTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saleBut = new System.Windows.Forms.Button();
            this.SID = new System.Windows.Forms.Label();
            this.MID = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.mIDDataGridViewTextBoxColumn,
            this.amountSupplyDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.supplyDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 390);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "SID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "SID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            // 
            // mIDDataGridViewTextBoxColumn
            // 
            this.mIDDataGridViewTextBoxColumn.DataPropertyName = "MID";
            this.mIDDataGridViewTextBoxColumn.HeaderText = "MID";
            this.mIDDataGridViewTextBoxColumn.Name = "mIDDataGridViewTextBoxColumn";
            // 
            // amountSupplyDataGridViewTextBoxColumn
            // 
            this.amountSupplyDataGridViewTextBoxColumn.DataPropertyName = "AmountSupply";
            this.amountSupplyDataGridViewTextBoxColumn.HeaderText = "AmountSupply";
            this.amountSupplyDataGridViewTextBoxColumn.Name = "amountSupplyDataGridViewTextBoxColumn";
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "SName";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "SName";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            // 
            // supplyDateDataGridViewTextBoxColumn
            // 
            this.supplyDateDataGridViewTextBoxColumn.DataPropertyName = "SupplyDate";
            this.supplyDateDataGridViewTextBoxColumn.HeaderText = "SupplyDate";
            this.supplyDateDataGridViewTextBoxColumn.Name = "supplyDateDataGridViewTextBoxColumn";
            // 
            // supplyBindingSource
            // 
            this.supplyBindingSource.DataMember = "Supply";
            this.supplyBindingSource.DataSource = this.mRPDataSet;
            // 
            // mRPDataSet
            // 
            this.mRPDataSet.DataSetName = "MRPDataSet";
            this.mRPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplyTableAdapter
            // 
            this.supplyTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplier Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Material Name: ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(316, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(139, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Supply Amount:";
            // 
            // saleBut
            // 
            this.saleBut.Location = new System.Drawing.Point(669, 20);
            this.saleBut.Name = "saleBut";
            this.saleBut.Size = new System.Drawing.Size(124, 25);
            this.saleBut.TabIndex = 7;
            this.saleBut.Text = "Supply";
            this.saleBut.UseVisualStyleBackColor = true;
            this.saleBut.Click += new System.EventHandler(this.saleBut_Click);
            // 
            // SID
            // 
            this.SID.AutoSize = true;
            this.SID.Location = new System.Drawing.Point(11, 143);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(0, 13);
            this.SID.TabIndex = 8;
            this.SID.Visible = false;
            // 
            // MID
            // 
            this.MID.AutoSize = true;
            this.MID.Location = new System.Drawing.Point(12, 169);
            this.MID.Name = "MID";
            this.MID.Size = new System.Drawing.Size(0, 13);
            this.MID.TabIndex = 9;
            this.MID.Visible = false;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(72, 226);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 13);
            this.date.TabIndex = 10;
            this.date.Visible = false;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(553, 23);
            this.amount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(55, 20);
            this.amount.TabIndex = 11;
            this.amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Supply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.date);
            this.Controls.Add(this.MID);
            this.Controls.Add(this.SID);
            this.Controls.Add(this.saleBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supply";
            this.Text = "Supply";
            this.Load += new System.EventHandler(this.Supply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MRPDataSet mRPDataSet;
        private System.Windows.Forms.BindingSource supplyBindingSource;
        private MRPDataSetTableAdapters.SupplyTableAdapter supplyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountSupplyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saleBut;
        private System.Windows.Forms.Label SID;
        private System.Windows.Forms.Label MID;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.NumericUpDown amount;
    }
}
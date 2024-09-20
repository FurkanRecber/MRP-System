namespace WindowsFormsApp1
{
    partial class supplier
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
            this.addSupp = new System.Windows.Forms.Button();
            this.UpdSupp = new System.Windows.Forms.Button();
            this.DelSup = new System.Windows.Forms.Button();
            this.nameSupText = new System.Windows.Forms.TextBox();
            this.numberSupText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mRPDataSet = new WindowsFormsApp1.MRPDataSet();
            this.supplierTableAdapter = new WindowsFormsApp1.MRPDataSetTableAdapters.SupplierTableAdapter();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new WindowsFormsApp1.MRPDataSetTableAdapters.MaterialTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addSupp
            // 
            this.addSupp.Location = new System.Drawing.Point(251, 34);
            this.addSupp.Name = "addSupp";
            this.addSupp.Size = new System.Drawing.Size(144, 29);
            this.addSupp.TabIndex = 0;
            this.addSupp.Text = "Add New Supplier";
            this.addSupp.UseVisualStyleBackColor = true;
            this.addSupp.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdSupp
            // 
            this.UpdSupp.Location = new System.Drawing.Point(401, 34);
            this.UpdSupp.Name = "UpdSupp";
            this.UpdSupp.Size = new System.Drawing.Size(141, 29);
            this.UpdSupp.TabIndex = 1;
            this.UpdSupp.Text = "Uptade Supplier";
            this.UpdSupp.UseVisualStyleBackColor = true;
            this.UpdSupp.Click += new System.EventHandler(this.UpdSupp_Click);
            // 
            // DelSup
            // 
            this.DelSup.Location = new System.Drawing.Point(548, 34);
            this.DelSup.Name = "DelSup";
            this.DelSup.Size = new System.Drawing.Size(142, 29);
            this.DelSup.TabIndex = 2;
            this.DelSup.Text = "Delete Supplier";
            this.DelSup.UseVisualStyleBackColor = true;
            this.DelSup.Click += new System.EventHandler(this.button3_Click);
            // 
            // nameSupText
            // 
            this.nameSupText.Location = new System.Drawing.Point(78, 37);
            this.nameSupText.Name = "nameSupText";
            this.nameSupText.Size = new System.Drawing.Size(167, 20);
            this.nameSupText.TabIndex = 3;
            // 
            // numberSupText
            // 
            this.numberSupText.Location = new System.Drawing.Point(78, 71);
            this.numberSupText.Name = "numberSupText";
            this.numberSupText.Size = new System.Drawing.Size(167, 20);
            this.numberSupText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SID);
            this.groupBox1.Controls.Add(this.DelSup);
            this.groupBox1.Controls.Add(this.addSupp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UpdSupp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameSupText);
            this.groupBox1.Controls.Add(this.numberSupText);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 113);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SID
            // 
            this.SID.AutoSize = true;
            this.SID.Location = new System.Drawing.Point(703, 74);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(0, 13);
            this.SID.TabIndex = 7;
            this.SID.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplierBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(800, 332);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "SID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "SID";
            this.sIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "SName";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "SName";
            this.sNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.mRPDataSet;
            // 
            // mRPDataSet
            // 
            this.mRPDataSet.DataSetName = "MRPDataSet";
            this.mRPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.mRPDataSet;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "supplier";
            this.Text = "supplier";
            this.Load += new System.EventHandler(this.supplier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addSupp;
        private System.Windows.Forms.Button DelSup;
        private System.Windows.Forms.TextBox nameSupText;
        private System.Windows.Forms.TextBox numberSupText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MRPDataSet mRPDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private MRPDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private MRPDataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button UpdSupp;
        private System.Windows.Forms.Label SID;
    }
}
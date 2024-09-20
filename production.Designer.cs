namespace WindowsFormsApp1
{
    partial class production
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.probut = new System.Windows.Forms.Button();
            this.productionCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.capalabel = new System.Windows.Forms.Label();
            this.capa = new System.Windows.Forms.Label();
            this.neededpanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productionCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select  Product:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(291, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // probut
            // 
            this.probut.Location = new System.Drawing.Point(402, 311);
            this.probut.Name = "probut";
            this.probut.Size = new System.Drawing.Size(157, 38);
            this.probut.TabIndex = 4;
            this.probut.Text = "Produce";
            this.probut.UseVisualStyleBackColor = true;
            this.probut.Click += new System.EventHandler(this.probut_Click);
            // 
            // productionCount
            // 
            this.productionCount.Location = new System.Drawing.Point(418, 51);
            this.productionCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.productionCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productionCount.Name = "productionCount";
            this.productionCount.Size = new System.Drawing.Size(48, 20);
            this.productionCount.TabIndex = 5;
            this.productionCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Production Time:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(343, 111);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(19, 13);
            this.time.TabIndex = 7;
            this.time.Text = "00";
            // 
            // capalabel
            // 
            this.capalabel.AutoSize = true;
            this.capalabel.Location = new System.Drawing.Point(288, 135);
            this.capalabel.Name = "capalabel";
            this.capalabel.Size = new System.Drawing.Size(54, 13);
            this.capalabel.TabIndex = 8;
            this.capalabel.Text = "Capacity: ";
            // 
            // capa
            // 
            this.capa.AutoSize = true;
            this.capa.Location = new System.Drawing.Point(343, 135);
            this.capa.Name = "capa";
            this.capa.Size = new System.Drawing.Size(36, 13);
            this.capa.TabIndex = 9;
            this.capa.Text = "00/00";
            // 
            // neededpanel
            // 
            this.neededpanel.Location = new System.Drawing.Point(219, 178);
            this.neededpanel.Name = "neededpanel";
            this.neededpanel.Size = new System.Drawing.Size(326, 45);
            this.neededpanel.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(205, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 138);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // production
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.neededpanel);
            this.Controls.Add(this.capa);
            this.Controls.Add(this.capalabel);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productionCount);
            this.Controls.Add(this.probut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "production";
            this.Text = "1!";
            this.Load += new System.EventHandler(this.production_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productionCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button probut;
        private System.Windows.Forms.NumericUpDown productionCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label capalabel;
        private System.Windows.Forms.Label capa;
        private System.Windows.Forms.Panel neededpanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}
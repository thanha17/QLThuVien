namespace WindowsFormsApp1
{
    partial class fThongTin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.thuVienDataSet4 = new WindowsFormsApp1.ThuVienDataSet4();
            this.borrowedBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrowedBookTableAdapter = new WindowsFormsApp1.ThuVienDataSet4TableAdapters.BorrowedBookTableAdapter();
            this.idsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsachDataGridViewTextBoxColumn,
            this.tensachDataGridViewTextBoxColumn,
            this.tacgiaDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borrowedBookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 296);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 108);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(459, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(459, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(335, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Địa Chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ngày Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thông Tin Liên Hệ";
            // 
            // thuVienDataSet4
            // 
            this.thuVienDataSet4.DataSetName = "ThuVienDataSet4";
            this.thuVienDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borrowedBookBindingSource
            // 
            this.borrowedBookBindingSource.DataMember = "BorrowedBook";
            this.borrowedBookBindingSource.DataSource = this.thuVienDataSet4;
            // 
            // borrowedBookTableAdapter
            // 
            this.borrowedBookTableAdapter.ClearBeforeFill = true;
            // 
            // idsachDataGridViewTextBoxColumn
            // 
            this.idsachDataGridViewTextBoxColumn.DataPropertyName = "id_sach";
            this.idsachDataGridViewTextBoxColumn.HeaderText = "id_sach";
            this.idsachDataGridViewTextBoxColumn.Name = "idsachDataGridViewTextBoxColumn";
            this.idsachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tensachDataGridViewTextBoxColumn
            // 
            this.tensachDataGridViewTextBoxColumn.DataPropertyName = "Ten_sach";
            this.tensachDataGridViewTextBoxColumn.HeaderText = "Ten_sach";
            this.tensachDataGridViewTextBoxColumn.Name = "tensachDataGridViewTextBoxColumn";
            this.tensachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tacgiaDataGridViewTextBoxColumn
            // 
            this.tacgiaDataGridViewTextBoxColumn.DataPropertyName = "Tac_gia";
            this.tacgiaDataGridViewTextBoxColumn.HeaderText = "Tac_gia";
            this.tacgiaDataGridViewTextBoxColumn.Name = "tacgiaDataGridViewTextBoxColumn";
            this.tacgiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "So_luong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "So_luong";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            this.soluongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fThongTin";
            this.Text = "Thông tin mượn sách";
            this.Load += new System.EventHandler(this.fThongTin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private ThuVienDataSet4 thuVienDataSet4;
        private System.Windows.Forms.BindingSource borrowedBookBindingSource;
        private ThuVienDataSet4TableAdapters.BorrowedBookTableAdapter borrowedBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
    }
}
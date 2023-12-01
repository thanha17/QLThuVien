namespace WindowsFormsApp1
{
    partial class fMember
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongsoluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conlaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuVienDataSet = new WindowsFormsApp1.ThuVienDataSet();
            this.btMuon = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.tbTimKiem2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btTra = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idsachDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensachDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgiaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowedBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuVienDataSet1 = new WindowsFormsApp1.ThuVienDataSet1();
            this.tableBookTableAdapter = new WindowsFormsApp1.ThuVienDataSetTableAdapters.TableBookTableAdapter();
            this.borrowedBookTableAdapter = new WindowsFormsApp1.ThuVienDataSet1TableAdapters.BorrowedBookTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 135);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1035, 405);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btMuon);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1027, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thư Viện";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(551, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 22);
            this.textBox2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số lượng cần mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tìm kiếm theo:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(164, 86);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(186, 22);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID ",
            "Tên Sách",
            "Tác Giả"});
            this.comboBox1.Location = new System.Drawing.Point(164, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tìm Kiếm";
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
            this.tongsoluongDataGridViewTextBoxColumn,
            this.damuonDataGridViewTextBoxColumn,
            this.conlaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 343);
            this.dataGridView1.TabIndex = 8;
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
            // tongsoluongDataGridViewTextBoxColumn
            // 
            this.tongsoluongDataGridViewTextBoxColumn.DataPropertyName = "Tong_so_luong";
            this.tongsoluongDataGridViewTextBoxColumn.HeaderText = "Tong_so_luong";
            this.tongsoluongDataGridViewTextBoxColumn.Name = "tongsoluongDataGridViewTextBoxColumn";
            this.tongsoluongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // damuonDataGridViewTextBoxColumn
            // 
            this.damuonDataGridViewTextBoxColumn.DataPropertyName = "Da_muon";
            this.damuonDataGridViewTextBoxColumn.HeaderText = "Da_muon";
            this.damuonDataGridViewTextBoxColumn.Name = "damuonDataGridViewTextBoxColumn";
            this.damuonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conlaiDataGridViewTextBoxColumn
            // 
            this.conlaiDataGridViewTextBoxColumn.DataPropertyName = "Con_lai";
            this.conlaiDataGridViewTextBoxColumn.HeaderText = "Con_lai";
            this.conlaiDataGridViewTextBoxColumn.Name = "conlaiDataGridViewTextBoxColumn";
            this.conlaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableBookBindingSource
            // 
            this.tableBookBindingSource.DataMember = "TableBook";
            this.tableBookBindingSource.DataSource = this.thuVienDataSet;
            // 
            // thuVienDataSet
            // 
            this.thuVienDataSet.DataSetName = "ThuVienDataSet";
            this.thuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btMuon
            // 
            this.btMuon.Location = new System.Drawing.Point(394, 86);
            this.btMuon.Name = "btMuon";
            this.btMuon.Size = new System.Drawing.Size(99, 29);
            this.btMuon.TabIndex = 7;
            this.btMuon.Text = "Mượn";
            this.btMuon.UseVisualStyleBackColor = true;
            this.btMuon.Click += new System.EventHandler(this.btMuon_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.tbTimKiem2);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btTra);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1027, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sách Đã Mượn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Số lượng cần trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tìm kiếm theo:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(505, 52);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(186, 22);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbTimKiem2
            // 
            this.tbTimKiem2.Location = new System.Drawing.Point(162, 21);
            this.tbTimKiem2.Name = "tbTimKiem2";
            this.tbTimKiem2.Size = new System.Drawing.Size(298, 22);
            this.tbTimKiem2.TabIndex = 18;
            this.tbTimKiem2.TextChanged += new System.EventHandler(this.tbTimKiem2_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ID ",
            "Tên Sách",
            "Tác Giả"});
            this.comboBox2.Location = new System.Drawing.Point(162, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(199, 24);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tìm Kiếm";
            // 
            // btTra
            // 
            this.btTra.Location = new System.Drawing.Point(744, 48);
            this.btTra.Name = "btTra";
            this.btTra.Size = new System.Drawing.Size(99, 29);
            this.btTra.TabIndex = 15;
            this.btTra.Text = "Trả";
            this.btTra.UseVisualStyleBackColor = true;
            this.btTra.Click += new System.EventHandler(this.btTra_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsachDataGridViewTextBoxColumn1,
            this.tensachDataGridViewTextBoxColumn1,
            this.tacgiaDataGridViewTextBoxColumn1,
            this.soluongDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.borrowedBookBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 85);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1012, 270);
            this.dataGridView2.TabIndex = 0;
            // 
            // idsachDataGridViewTextBoxColumn1
            // 
            this.idsachDataGridViewTextBoxColumn1.DataPropertyName = "id_sach";
            this.idsachDataGridViewTextBoxColumn1.HeaderText = "id_sach";
            this.idsachDataGridViewTextBoxColumn1.Name = "idsachDataGridViewTextBoxColumn1";
            this.idsachDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tensachDataGridViewTextBoxColumn1
            // 
            this.tensachDataGridViewTextBoxColumn1.DataPropertyName = "Ten_sach";
            this.tensachDataGridViewTextBoxColumn1.HeaderText = "Ten_sach";
            this.tensachDataGridViewTextBoxColumn1.Name = "tensachDataGridViewTextBoxColumn1";
            this.tensachDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tacgiaDataGridViewTextBoxColumn1
            // 
            this.tacgiaDataGridViewTextBoxColumn1.DataPropertyName = "Tac_gia";
            this.tacgiaDataGridViewTextBoxColumn1.HeaderText = "Tac_gia";
            this.tacgiaDataGridViewTextBoxColumn1.Name = "tacgiaDataGridViewTextBoxColumn1";
            this.tacgiaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "So_luong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "So_luong";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            this.soluongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowedBookBindingSource
            // 
            this.borrowedBookBindingSource.DataMember = "BorrowedBook";
            this.borrowedBookBindingSource.DataSource = this.thuVienDataSet1;
            // 
            // thuVienDataSet1
            // 
            this.thuVienDataSet1.DataSetName = "ThuVienDataSet1";
            this.thuVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBookTableAdapter
            // 
            this.tableBookTableAdapter.ClearBeforeFill = true;
            // 
            // borrowedBookTableAdapter
            // 
            this.borrowedBookTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 117);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Ngày Sinh";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(544, 68);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(544, 25);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(108, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(414, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Thông Tin Liên Hệ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Địa Chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(108, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 0;
            // 
            // fMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fMember";
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btMuon;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private ThuVienDataSet thuVienDataSet;
        private System.Windows.Forms.BindingSource tableBookBindingSource;
        private ThuVienDataSetTableAdapters.TableBookTableAdapter tableBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongsoluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conlaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ThuVienDataSet1 thuVienDataSet1;
        private System.Windows.Forms.BindingSource borrowedBookBindingSource;
        private ThuVienDataSet1TableAdapters.BorrowedBookTableAdapter borrowedBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsachDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensachDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgiaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox tbTimKiem2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btTra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
    }
}
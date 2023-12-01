namespace WindowsFormsApp1
{
    partial class fAdmin
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
            System.Windows.Forms.TabPage tabPage1;
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.tbSo_luong = new System.Windows.Forms.TextBox();
            this.tbBook_author = new System.Windows.Forms.TextBox();
            this.tbBook_name = new System.Windows.Forms.TextBox();
            this.tbBook_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongsoluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conlaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuVienDataSet2 = new WindowsFormsApp1.ThuVienDataSet2();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btXoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btDangKy = new System.Windows.Forms.Button();
            this.btXem = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdaypersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuVienDataSet3 = new WindowsFormsApp1.ThuVienDataSet3();
            this.tableBookTableAdapter = new WindowsFormsApp1.ThuVienDataSet2TableAdapters.TableBookTableAdapter();
            this.accountTableAdapter = new WindowsFormsApp1.ThuVienDataSet3TableAdapters.AccountTableAdapter();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(this.label6);
            tabPage1.Controls.Add(this.label5);
            tabPage1.Controls.Add(this.tbTimKiem);
            tabPage1.Controls.Add(this.comboBox1);
            tabPage1.Controls.Add(this.btSua);
            tabPage1.Controls.Add(this.btThem);
            tabPage1.Controls.Add(this.tbSo_luong);
            tabPage1.Controls.Add(this.tbBook_author);
            tabPage1.Controls.Add(this.tbBook_name);
            tabPage1.Controls.Add(this.tbBook_ID);
            tabPage1.Controls.Add(this.label4);
            tabPage1.Controls.Add(this.label3);
            tabPage1.Controls.Add(this.label2);
            tabPage1.Controls.Add(this.label1);
            tabPage1.Controls.Add(this.dataGridView1);
            tabPage1.Location = new System.Drawing.Point(4, 25);
            tabPage1.Margin = new System.Windows.Forms.Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(4);
            tabPage1.Size = new System.Drawing.Size(1053, 495);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản Lý Sách";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tìm kiếm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tìm kiếm theo:";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(403, 134);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(154, 22);
            this.tbTimKiem.TabIndex = 12;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID ",
            "Tên Sách",
            "Tác Giả"});
            this.comboBox1.Location = new System.Drawing.Point(403, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(227, 69);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(108, 21);
            this.btSua.TabIndex = 10;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(227, 18);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(108, 22);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // tbSo_luong
            // 
            this.tbSo_luong.Location = new System.Drawing.Point(101, 140);
            this.tbSo_luong.Name = "tbSo_luong";
            this.tbSo_luong.Size = new System.Drawing.Size(100, 22);
            this.tbSo_luong.TabIndex = 8;
            // 
            // tbBook_author
            // 
            this.tbBook_author.Location = new System.Drawing.Point(101, 101);
            this.tbBook_author.Name = "tbBook_author";
            this.tbBook_author.Size = new System.Drawing.Size(100, 22);
            this.tbBook_author.TabIndex = 7;
            // 
            // tbBook_name
            // 
            this.tbBook_name.Location = new System.Drawing.Point(101, 52);
            this.tbBook_name.Name = "tbBook_name";
            this.tbBook_name.Size = new System.Drawing.Size(100, 22);
            this.tbBook_name.TabIndex = 6;
            // 
            // tbBook_ID
            // 
            this.tbBook_ID.Location = new System.Drawing.Point(101, 17);
            this.tbBook_ID.Name = "tbBook_ID";
            this.tbBook_ID.Size = new System.Drawing.Size(100, 22);
            this.tbBook_ID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tác Giả:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sách:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 175);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 316);
            this.dataGridView1.TabIndex = 0;
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
            this.tableBookBindingSource.DataSource = this.thuVienDataSet2;
            // 
            // thuVienDataSet2
            // 
            this.thuVienDataSet2.DataSetName = "ThuVienDataSet2";
            this.thuVienDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1061, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btXoa);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.btDangKy);
            this.tabPage2.Controls.Add(this.btXem);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1053, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(431, 11);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(128, 40);
            this.btXoa.TabIndex = 19;
            this.btXoa.Text = "Xóa Thành Viên";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tìm kiếm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tìm kiếm theo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 22);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ID",
            "Tên Đăng Nhập",
            "Tên"});
            this.comboBox2.Location = new System.Drawing.Point(134, 10);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 24);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btDangKy
            // 
            this.btDangKy.Location = new System.Drawing.Point(649, 57);
            this.btDangKy.Name = "btDangKy";
            this.btDangKy.Size = new System.Drawing.Size(118, 38);
            this.btDangKy.TabIndex = 2;
            this.btDangKy.Text = "Đăng Ký";
            this.btDangKy.UseVisualStyleBackColor = true;
            this.btDangKy.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // btXem
            // 
            this.btXem.Location = new System.Drawing.Point(649, 13);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(118, 38);
            this.btXem.TabIndex = 1;
            this.btXem.Text = "Xem chi tiết";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpersonDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.tenpersonDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.birthdaypersonDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactInfoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.accountBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 101);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1038, 387);
            this.dataGridView2.TabIndex = 0;
            // 
            // idpersonDataGridViewTextBoxColumn
            // 
            this.idpersonDataGridViewTextBoxColumn.DataPropertyName = "id_person";
            this.idpersonDataGridViewTextBoxColumn.HeaderText = "id_person";
            this.idpersonDataGridViewTextBoxColumn.Name = "idpersonDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // tenpersonDataGridViewTextBoxColumn
            // 
            this.tenpersonDataGridViewTextBoxColumn.DataPropertyName = "Ten_person";
            this.tenpersonDataGridViewTextBoxColumn.HeaderText = "Ten_person";
            this.tenpersonDataGridViewTextBoxColumn.Name = "tenpersonDataGridViewTextBoxColumn";
            // 
            // gioitinhDataGridViewTextBoxColumn
            // 
            this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "Gioi_tinh";
            this.gioitinhDataGridViewTextBoxColumn.HeaderText = "Gioi_tinh";
            this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
            // 
            // birthdaypersonDataGridViewTextBoxColumn
            // 
            this.birthdaypersonDataGridViewTextBoxColumn.DataPropertyName = "Birthday_person";
            this.birthdaypersonDataGridViewTextBoxColumn.HeaderText = "Birthday_person";
            this.birthdaypersonDataGridViewTextBoxColumn.Name = "birthdaypersonDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // contactInfoDataGridViewTextBoxColumn
            // 
            this.contactInfoDataGridViewTextBoxColumn.DataPropertyName = "Contact_Info";
            this.contactInfoDataGridViewTextBoxColumn.HeaderText = "Contact_Info";
            this.contactInfoDataGridViewTextBoxColumn.Name = "contactInfoDataGridViewTextBoxColumn";
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.thuVienDataSet3;
            // 
            // thuVienDataSet3
            // 
            this.thuVienDataSet3.DataSetName = "ThuVienDataSet3";
            this.thuVienDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBookTableAdapter
            // 
            this.tableBookTableAdapter.ClearBeforeFill = true;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fAdmin";
            this.Text = "ADMIN";
            this.Load += new System.EventHandler(this.Form3_Load);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox tbSo_luong;
        private System.Windows.Forms.TextBox tbBook_author;
        private System.Windows.Forms.TextBox tbBook_name;
        private System.Windows.Forms.TextBox tbBook_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private ThuVienDataSet2 thuVienDataSet2;
        private System.Windows.Forms.BindingSource tableBookBindingSource;
        private ThuVienDataSet2TableAdapters.TableBookTableAdapter tableBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongsoluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conlaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ThuVienDataSet3 thuVienDataSet3;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private ThuVienDataSet3TableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdaypersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btDangKy;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btXoa;
    }
}
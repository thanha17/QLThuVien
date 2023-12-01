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
    public partial class fDangKy : Form
    {
        QLThuVienDataContext db = new QLThuVienDataContext();

        public fDangKy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account account = new Account
            {
                Ten_person = textBox1.Text,
                Username = textBox2.Text,
                Password = textBox3.Text,
                Gioi_tinh = comboBox1.Text,
                Birthday_person = dateTimePicker1.Value.Date,
                Address = textBox4.Text,
                Contact_Info = textBox5.Text,

            };
            try
            {
                
                db.Accounts.InsertOnSubmit(account);
                db.SubmitChanges();
                MessageBox.Show("Đăng Ký Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                db.Accounts.DeleteOnSubmit(account);
                MessageBox.Show("Loi!", "Loi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void fDangKy_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Nam";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

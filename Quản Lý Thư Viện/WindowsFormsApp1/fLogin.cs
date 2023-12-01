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
    public partial class fLogin : Form
    {
        QLThuVienDataContext db = new QLThuVienDataContext();
        public static Account person_info;

        public fLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if(db.Accounts.Any(s => s.Username==textBox1.Text && s.Password==textBox2.Text) || (textBox1.Text=="admin" && textBox2.Text=="0"))
            {
                
                if (db.Accounts.Any(s => s.Username == textBox1.Text && s.Password == textBox2.Text))
                {
                    person_info = db.Accounts.Where(s => s.Username == textBox1.Text).Single();
                    fMember form2 = new fMember();
                    this.Hide();
                    form2.ShowDialog();
                    this.Show();
                }
                else
                {
                    fAdmin form3 = new fAdmin();
                    this.Hide();
                    form3.ShowDialog();
                    this.Show();
                }

            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Thông tin tài khoản không chính xác!", "Loi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fDangKy fDangKy = new fDangKy();
            this.Hide();
            fDangKy.ShowDialog();
            this.Show();
        }
    }
}

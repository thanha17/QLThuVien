using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class fAdmin : Form
    {
        QLThuVienDataContext db = new QLThuVienDataContext();
        TableBook tb;
        public static Account account1;
        private object list;

        public fAdmin()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuVienDataSet3.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.thuVienDataSet3.Account);
            // TODO: This line of code loads data into the 'thuVienDataSet2.TableBook' table. You can move, or remove it, as needed.
            this.tableBookTableAdapter.Fill(this.thuVienDataSet2.TableBook);
            comboBox1.SelectedItem = "ID ";
            comboBox2.SelectedItem = "ID";
            var st = from s in db.TableBooks select s;
            dataGridView1.DataSource = st;

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var tb = new TableBook
            {
                id_sach = tbBook_ID.Text,
                Ten_sach = tbBook_name.Text,
                Tac_gia = tbBook_author.Text,
                Tong_so_luong = int.Parse(tbSo_luong.Text),
                Da_muon = 0,
                Con_lai = int.Parse(tbSo_luong.Text)
            };
            try
            {
                db.TableBooks.InsertOnSubmit(tb);
                db.SubmitChanges();
                if (tbTimKiem.Text != "")
                    tbTimKiem_TextChanged(sender, e);
                else Form3_Load(sender, e);
            }
            catch
            {
                db.TableBooks.DeleteOnSubmit(tb);
                MessageBox.Show("Loi!", "Loi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
                TableBook tb = db.TableBooks.Where(s => s.id_sach.CompareTo(row.Cells[0].Value) == 0).Single();
                tb.Ten_sach = tbBook_name.Text;
                tb.Tac_gia = tbBook_author.Text;
                tb.Tong_so_luong = int.Parse(tbSo_luong.Text);
                tb.Con_lai = (tb.Tong_so_luong - tb.Da_muon);
                if(tb.Con_lai > 0 )
                {
                    db.SubmitChanges();
                    if (tbTimKiem.Text != "")
                        tbTimKiem_TextChanged(sender, e);
                    else Form3_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Loi!", "Loi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Loi!", "Loi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string cbb = comboBox1.SelectedItem.ToString();
            switch (cbb)
            {

                case "ID ":

                    list = db.TableBooks.Where(s => s.id_sach.Contains(tbTimKiem.Text)).ToList();
                    //dataGridView1.DataSource = list;
                    break;
                case "Tên Sách":
                    list = db.TableBooks.Where(s => s.Ten_sach.Contains(tbTimKiem.Text)).ToList();
                    //dataGridView1.DataSource = list;
                    break;
                case "Tác Giả":
                    list = db.TableBooks.Where(s => s.Tac_gia.Contains(tbTimKiem.Text)).ToList();
                    break;

            }
            //var list = db.TableBooks.Where(s => s.id.Contains(textBox1.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbTimKiem.Text != "")
                tbTimKiem_TextChanged(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cbb = comboBox2.SelectedItem.ToString();
            switch (cbb)
            {

                case "ID":
                    list = db.Accounts.Where(s => s.id_person.ToString().Contains(textBox1.Text)).ToList();
                    break;
                case "Tên Đăng Nhập":
                    list = db.Accounts.Where(s => s.Username.Contains(textBox1.Text)).ToList();
                    break;
                case "Tên":
                    list = db.Accounts.Where(s => s.Ten_person.Contains(textBox1.Text)).ToList();
                    break;

            }
            dataGridView2.DataSource = list;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1_TextChanged(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView2.Rows[dataGridView2.CurrentRow.Index];
                Account account = db.Accounts.Where(s => s.id_person.CompareTo(row.Cells[0].Value) == 0).Single();
                db.Accounts.DeleteOnSubmit(account);
                db.SubmitChanges();
            }
            catch
            {
                MessageBox.Show("Loi!", "Loi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[dataGridView2.CurrentRow.Index];
            account1 = db.Accounts.Where(s => s.id_person.CompareTo(row.Cells[0].Value) == 0).Single();
            fThongTin fThongTin = new fThongTin();
            this.Hide();
            fThongTin.ShowDialog();
            this.Show();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            fDangKy fDangKy= new fDangKy();
            this.Hide();
            fDangKy.ShowDialog();
            this.Show();
        }
    }
}

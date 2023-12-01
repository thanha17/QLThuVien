using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class fMember : Form
    {
        QLThuVienDataContext db = new QLThuVienDataContext();
        private List<TableBook> list;
        private List<BorrowedBook> list2;
        public TableBook tb;
        private BorrowedBook book_muon;
        Account person = fLogin.person_info;
        
        
        public fMember()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuVienDataSet1.BorrowedBook' table. You can move, or remove it, as needed.
            //this.borrowedBookTableAdapter.Fill(this.thuVienDataSet1.BorrowedBook);
            var st = from s in db.BorrowedBooks
                     where s.Ten_member==person.Ten_person
                     select s;
            dataGridView2.DataSource = st;
            // TODO: This line of code loads data into the 'thuVienDataSet.TableBook' table. You can move, or remove it, as needed.
            //this.tableBookTableAdapter.Fill(this.thuVienDataSet.TableBook);
            var dt = from s in db.TableBooks
                     select s;
            dataGridView1.DataSource = dt;

            comboBox1.SelectedItem = "ID ";
            comboBox2.SelectedItem = "ID ";

            textBox3.Text = person.Ten_person;
            textBox4.Text = person.Gioi_tinh;
            dateTimePicker1.Value = person.Birthday_person;
            textBox5.Text = person.Address;
            textBox6.Text = person.Contact_Info;


        }
        //trang 1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cbb = comboBox1.SelectedItem.ToString();
            switch (cbb)
            {
                
                case "ID ":
                    
                    list = db.TableBooks.Where(s => s.id_sach.Contains(textBox1.Text)).ToList();
                    break;
                case "Tên Sách":
                    list = db.TableBooks.Where(s => s.Ten_sach.Contains(textBox1.Text)).ToList();
                    break;
                case "Tác Giả":
                    list = db.TableBooks.Where(s => s.Tac_gia.Contains(textBox1.Text)).ToList();
                    break;

            }
            dataGridView1.DataSource = list;
        }

        private void btMuon_Click(object sender, EventArgs e)
        {
            
            try
            {
                DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
                tb = db.TableBooks.Where(s => s.id_sach.CompareTo(row.Cells[0].Value) == 0).Single();
                int muon = (int)numericUpDown1.Value;             
                if (muon <= tb.Con_lai && muon >0)
                {
                    if (db.BorrowedBooks.Any(s => s.id_sach == tb.id_sach && s.id_member==person.id_person.ToString()))
                    {
                        book_muon = db.BorrowedBooks.Where(s => s.id_sach == tb.id_sach && s.id_member==person.id_person.ToString()).Single();
                        book_muon.So_luong += muon;

                    }
                    else
                    {
                        book_muon = new BorrowedBook
                        {
                            id_sach = tb.id_sach,
                            Ten_sach = tb.Ten_sach,
                            Tac_gia = tb.Tac_gia,
                            Ten_member = person.Ten_person,
                            id_member = person.id_person.ToString(),
                            So_luong = muon
                        };
                        db.BorrowedBooks.InsertOnSubmit(book_muon);
                    }
                    tb.Da_muon += muon;
                    tb.Con_lai = tb.Tong_so_luong - tb.Da_muon;                   
                    
                    TransactionHistory giao_dich = new TransactionHistory
                    {
                        id_sach=tb.id_sach,
                        Ten_sach= tb.Ten_sach,
                        Tac_gia= tb.Tac_gia,
                        id_member=person.id_person.ToString(),
                        Ten_member = person.Ten_person,
                        Activate = "mượn",
                        day = DateTime.Now.Date,
                        time = DateTime.Now.TimeOfDay,
                        So_luong= muon
                    };
                    db.TransactionHistories.InsertOnSubmit(giao_dich);
                    db.SubmitChanges();
                    Form2_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Loi!", "Loi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                numericUpDown1.Value = 1;
            }
            catch { MessageBox.Show("Loi!", "Loi!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
                textBox1_TextChanged(sender, e);
        }



        //----------------------------------------------------------------------------------------------------
        //trang 2
        private void tbTimKiem2_TextChanged(object sender, EventArgs e)
        {
            string cbb = comboBox2.SelectedItem.ToString();
            switch (cbb)
            {
                case "ID ":

                    list2 = db.BorrowedBooks.Where(s => s.id_sach.Contains(tbTimKiem2.Text)).ToList();
                    break;
                case "Tên Sách":
                    list2 = db.BorrowedBooks.Where(s => s.Ten_sach.Contains(tbTimKiem2.Text)).ToList();
                    break;
                case "Tác Giả":
                    list2 = db.BorrowedBooks.Where(s => s.Tac_gia.Contains(tbTimKiem2.Text)).ToList();
                    break;

            }
            //var list = db.TableBooks.Where(s => s.id.Contains(textBox1.Text)).ToList();
            dataGridView2.DataSource = list2;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1_TextChanged(sender, e);
        }

        private void btTra_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView2.Rows[dataGridView2.CurrentRow.Index];
                book_muon = db.BorrowedBooks.Where(s => s.id_sach== row.Cells[0].Value && s.id_member==person.id_person.ToString()).Single();
                int tra = (int)numericUpDown2.Value;
                if (tra <= book_muon.So_luong)
                {
                    book_muon.So_luong -= tra;
                    tb = db.TableBooks.Where(s => s.id_sach.CompareTo(book_muon.id_sach) == 0).Single();
                    tb.Da_muon -= tra;
                    tb.Con_lai = tb.Tong_so_luong - tb.Da_muon;
                    if (book_muon.So_luong == 0)
                        db.BorrowedBooks.DeleteOnSubmit(book_muon);
                    TransactionHistory giao_dich = new TransactionHistory
                    {
                        id_sach = tb.id_sach,
                        Ten_sach = tb.Ten_sach,
                        Tac_gia = tb.Tac_gia,
                        id_member = person.id_person.ToString(),
                        Ten_member = person.Ten_person,
                        Activate = "Trả",
                        day = DateTime.Now.Date,
                        time = DateTime.Now.TimeOfDay,
                        So_luong = tra
                    };
                    db.TransactionHistories.InsertOnSubmit(giao_dich);
                    db.SubmitChanges();
                    Form2_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Loi!", "Loi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                numericUpDown2.Value = 1;
            }
            catch { MessageBox.Show("Loi!", "Loi!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}

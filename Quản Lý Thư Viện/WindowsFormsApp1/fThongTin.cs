using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class fThongTin : Form
    {
        QLThuVienDataContext db = new QLThuVienDataContext();
        Account person = fAdmin.account1;
        public fThongTin()
        {
            InitializeComponent();
        }

        private void fThongTin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuVienDataSet4.BorrowedBook' table. You can move, or remove it, as needed.
            this.borrowedBookTableAdapter.Fill(this.thuVienDataSet4.BorrowedBook);

            var list = db.BorrowedBooks.Where(s=>s.id_member.CompareTo(person.id_person)==0).ToList();
            dataGridView1.DataSource = list;

            textBox1.Text = person.Ten_person;
            textBox2.Text = person.Gioi_tinh;
            dateTimePicker1.Value = person.Birthday_person;
            textBox3.Text = person.Address;
            textBox4.Text = person.Contact_Info;
        }
    }
}

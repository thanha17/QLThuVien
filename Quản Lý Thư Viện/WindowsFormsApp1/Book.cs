using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Book
    {
        private string _id;
        private string _Book_name;
        private string Book_author;
        private string _Tong_so_luong;
        private string _Đa_muon;
        private string _Con_lai;

        public Book()
        {
        }

        public Book(string id, string book_name, string book_author, string tong_so_luong, string đa_muon, string con_lai)
        {
            _id = id;
            _Book_name = book_name;
            Book_author = book_author;
            _Tong_so_luong = tong_so_luong;
            _Đa_muon = đa_muon;
            _Con_lai = con_lai;
        }

        public string Id { get => _id; set => _id = value; }
        public string Book_name { get => _Book_name; set => _Book_name = value; }
        public string Book_author1 { get => Book_author; set => Book_author = value; }
        public string Tong_so_luong { get => _Tong_so_luong; set => _Tong_so_luong = value; }
        public string Đa_muon { get => _Đa_muon; set => _Đa_muon = value; }
        public string Con_lai { get => _Con_lai; set => _Con_lai = value; }


    }
}

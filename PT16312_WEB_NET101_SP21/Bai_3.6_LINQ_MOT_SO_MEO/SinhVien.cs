using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._6_LINQ_MOT_SO_MEO
{
    class SinhVien
    {
        private string ho;
        private string tenDem;
        private string ten;
        private string maSv;
        private int namSinh;
        private double diemCsharp;
        private string gioiTinh;
        private string queQuan;

        public SinhVien()
        {

        }

        public SinhVien(string ho, string tenDem, string ten, string maSv, int namSinh, double diemCsharp, string gioiTinh, string queQuan)
        {
            this.ho = ho;
            this.tenDem = tenDem;
            this.ten = ten;
            this.maSv = maSv;
            this.namSinh = namSinh;
            this.diemCsharp = diemCsharp;
            this.gioiTinh = gioiTinh;
            this.queQuan = queQuan;
        }

        public string Ho
        {
            get { return ho; }
            set { ho = value; }
        }
        public string TenDem
        {
            get => tenDem;
            set => tenDem = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string MaSv
        {
            get => maSv;
            set => maSv = value;
        }

        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        public double DiemCsharp
        {
            get => diemCsharp;
            set => diemCsharp = value;
        }

        public string GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }

        public string QueQuan
        {
            get => queQuan;
            set => queQuan = value;
        }

        public void inRaManHinh()
        {
            Console.WriteLine("Họ và Tên: {0} {1} {2} | Mã SV: {3} | Năm Sinh: {4} | Điểm: {5} | Giới Tính: {6} | Quê quán: {7}", ho, tenDem, ten, maSv, namSinh, diemCsharp < 0?"N/A": diemCsharp.ToString(), gioiTinh, queQuan);
        }
    }
}

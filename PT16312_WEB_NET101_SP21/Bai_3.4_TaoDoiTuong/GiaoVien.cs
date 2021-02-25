using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._4_TaoDoiTuong
{
    class GiaoVien
    {
        private string ten;
        private string magv;
        private int namSinh;
        private string diaChi;

        //ctor
        public GiaoVien()
        {
            
        }
        //ALT + ENTER
        public GiaoVien(string ten, string magv, int namSinh, string diaChi)
        {
            this.ten = ten;
            this.magv = magv;
            this.namSinh = namSinh;
            this.diaChi = diaChi;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Magv
        {
            get => magv;
            set => magv = value;
        }

        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        public string DiaChi
        {
            get => diaChi;
            set => diaChi = value;
        }

        public void inRaManHinh()
        {
            Console.WriteLine("Tên: {0} Mã: {1} Tuổi: {2} Địa Chỉ: {3}",ten,magv,2021 - namSinh,diaChi);
        }
    }
}

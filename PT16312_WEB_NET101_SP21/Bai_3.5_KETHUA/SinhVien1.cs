using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._5_KETHUA
{
    class SinhVien1
    {
        private string ho;
        private string tendem;
        private string ten;
        private string maSv;
        private double diemCsharp;

        public SinhVien1()
        {
            
        }

        public SinhVien1(string ho, string tendem, string ten, string maSv, double diemCsharp)
        {
            this.ho = ho;
            this.tendem = tendem;
            this.ten = ten;
            this.maSv = maSv;
            this.diemCsharp = diemCsharp;
        }

        public string Ho
        {
            get => ho;
            set => ho = value;
        }

        public string Tendem
        {
            get => tendem;
            set => tendem = value;
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

        public double DiemCsharp
        {
            get => diemCsharp;
            set => diemCsharp = value;
        }
    }
}

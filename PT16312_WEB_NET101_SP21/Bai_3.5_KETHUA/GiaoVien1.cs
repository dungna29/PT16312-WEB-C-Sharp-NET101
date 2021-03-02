using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._5_KETHUA
{
    class GiaoVien1
    {
        private string ho;
        private string tendem;
        private string ten;
        private string maGv;
        private double gioDay;

        public GiaoVien1()
        {
            
        }

        public GiaoVien1(string ho, string tendem, string ten, string maGv, double gioDay)
        {
            this.ho = ho;
            this.tendem = tendem;
            this.ten = ten;
            this.maGv = maGv;
            this.gioDay = gioDay;
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

        public string MaGv
        {
            get => maGv;
            set => maGv = value;
        }

        public double GioDay
        {
            get => gioDay;
            set => gioDay = value;
        }
    }
}

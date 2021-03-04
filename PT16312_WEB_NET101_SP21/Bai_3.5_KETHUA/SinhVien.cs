using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._5_KETHUA
{
    class SinhVien:Person//Sử dụng dấu : để kế thừa lớp cha
    {
        private string maSv;
        private double diemCsharp;

        public SinhVien()
        {
            
        }

        public SinhVien(string ho, string tendem, string ten, string maSv, double diemCsharp) : base(ho, tendem, ten)
        {
            
            this.maSv = maSv;
            this.diemCsharp = diemCsharp;
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

        void inRaManHinhSinhVien()
        {
            inRaManHinhPerson();//Kế thừa phương thức của lớp cha
        }

        //Để kế thừa phương thức của lớp cha sử dụng từ khóa overide và phương cha phải có virtual
        public override void inRaManHinhPerson()
        {
            //base.inRaManHinhPerson();
            Console.WriteLine("Đây là text in ra từ sinh viên");
        }
        
    }
}

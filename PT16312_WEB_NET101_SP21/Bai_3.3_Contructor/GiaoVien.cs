using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_Contructor
{
    class GiaoVien
    {
        //Phần 1: Liệt kê tất cả các thuộc tính phải có của đối tượng - Phải private các thuộc tính lại
        private string tenGV;
        private int tuoiGV;
        private string truongGV = "FPOLY";
       
       
        //Phần 2: 2 Contructor
        public GiaoVien()
        {
            
        }


        public GiaoVien(string tenGv, int tuoiGv, string truongGv)
        {
            tenGV = tenGv;
            tuoiGV = tuoiGv;
            truongGV = truongGv;
        }

        //Phương thức Getter và Setter vì các thuộc tính bị private lại
        public void setTenGV(string tenGV)
        {
            this.tenGV = tenGV;
        }

        public string getTenGV()
        {
            return tenGV;
        }

        public void setTuoiGV(int tuoiGV)
        {
            if (tuoiGV <0)
            {
                Console.WriteLine("Tuổi bạn nhập vào là số âm không thể gán cho thuộc tính");
                return;
            }
            this.tuoiGV = tuoiGV;
        }

        public int getTuoiGV()
        {
            return tuoiGV;
        }

        public string getTruongGV()
        {
            return truongGV;
        }
        //Phần 4: các phương thức của đối tượng
        private void inRaManHinh()
        {

        }

    }
}

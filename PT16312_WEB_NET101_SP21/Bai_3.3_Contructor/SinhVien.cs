using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_Contructor
{
    class SinhVien
    {
        //Phần 1: Liệt kê tất cả các thuộc tính phải có của đối tượng
        public string tenSv;
        public string maSV;
        public int tuoi;
        public double diemCsharp;

        //Phần 2: Contructor - Hàm tạo
        //Contructor phải giống tên Class
        //Contrucotr sẽ được gọi đến đầu tiên khi khởi tạo đối tượng

        //1. Contructor không tham số - gõ nhanh bằng cách gõ: ctor + tab
        public SinhVien()
        {
            Console.WriteLine("Đây là text được in ra từ Contructor không tham số");
        }

        //2. Contructor có tham số - gõ nhanh bằng cách gõ: ctorf + tab
        public SinhVien(string tenSv1, string maSv, int tuoi, double diemCsharp)
        {
            tenSv = tenSv1;
            maSV = maSv;
            this.tuoi = tuoi;
            this.diemCsharp = diemCsharp;
        }
        //Từ khóa this: dùng để tham chiếu đến thuộc tính hoặc phương thức của lớp hiện tại


        //Phần 4. Phương thức của đối tượng
        public void inRaManHinh()
        {

        }
    }
}

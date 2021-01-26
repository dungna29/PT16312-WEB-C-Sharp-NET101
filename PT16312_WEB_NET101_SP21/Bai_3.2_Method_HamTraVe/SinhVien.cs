using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._2_Method_HamTraVe
{
    /*
     * Tạo ra 1 đối tượng sinh viên
     *
     * Tên Class bắt buộc phải viết hoa chữ ái đầu của từ
     */
    class SinhVien
    {
        //Phần 1: Liệt kê tất cả các thuộc tính mà đối tượng phải có
       public string ten;
       public string diachi;
       public string quequan;
       public int sdt;

        //Phần 2: Khai báo 2 Contructor
        
        //Phần 3: Khai báo phương thước của đối tượng
        public void getSinhVien()
        {
            Console.WriteLine("Chào mừng đến với FPT {0} {1}", ten, diachi);
        }
    }
}

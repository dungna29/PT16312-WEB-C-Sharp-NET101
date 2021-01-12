using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._2_NhapXuatTuBanPhim
{
    class Program
    {
        /*
         * BÀI 1.2 Nhập xuất dữ liệu từ bàn phím
         *  1. Xuất dữ liệu ra màn hình
         *      + Phím tắt : cw + tab
         *      + Console.WriteLine(); Ghi xong thì xuống dòng
         *      + Console.Write(); Ghi xong thì không xuống dòng
         *  2. Nhập dữ liệu từ bàn phím:
         *      + Console.Read(); Đọc 1 ký tự từ bàn phím nhưng là số ASII
         *      + Console.ReadLine();  Đọc nhiều ký tự từ bàn phím và kiểu dữ liệu là string - chuỗi
         */
        static void Main(string[] args)
        { 
            //Giúp hiển thị tiếng việt trên console
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Chào các bạn đến với C#1");
            Console.Write(" 2021 ");
            Console.WriteLine(" FPT POLY");
           

            //Ví dụ mẫu: Viết 1 chương trình mời người dùng nhập tên và in ra
            //Bước 1: Xác định cần bao nhiêu biến
            string name, name2,name3;
            //Bước 2: Nhập giá trị từ bàn phím
            Console.Write("Mời bạn nhập tên: ");
             name = Console.ReadLine();//Gán chuỗi cho biến name
            //Bước 3: Xử lý nghiệp vụ
            Console.WriteLine("Tên bạn vừa nhập là: " + name);
            Console.ReadKey();
        }
    }
}

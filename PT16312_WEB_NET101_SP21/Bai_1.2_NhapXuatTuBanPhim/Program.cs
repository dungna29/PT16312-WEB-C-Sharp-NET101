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
         *      +Console.Read(); Đọc 1 ký tự từ bàn phím
         *      +Console.ReadLine();  Đọc nhiều ký tự từ bàn phím
         */
        static void Main(string[] args)
        {
            Console.WriteLine(" Chao cac ban den voi C#1");
            Console.Write(" 2021 ");
            Console.WriteLine(" Chao cac ban den voi C#1");
            Console.ReadKey();
        }
    }
}

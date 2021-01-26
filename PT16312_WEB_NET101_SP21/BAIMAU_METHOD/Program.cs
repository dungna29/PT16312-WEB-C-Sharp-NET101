using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAIMAU_METHOD
{
    class Program
    {
       static int input, a, b;
        /*
         * Chương trình máy tính 2 số có 4 phép toàn + - * :
         * Sử dụng Switch Case và vòng lặp ôm cả bài
         */
        static void Main(string[] args)
        {
            while (true)
            {
                swtichCase();
            }
        }

        static void menu()
        {
            Console.WriteLine("Chương trình máy tính POLY");
            Console.WriteLine("1. Phép công");
            Console.WriteLine("2. Phép trừ");
            Console.WriteLine("3. Phép nhân");
            Console.WriteLine("4. Phép chia");
        }

        static void swtichCase()
        {
            menu();
            Console.Write("Mời bạn chọn chức năng: ");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    nhapHaiSoTuBanPhim();
                    //congHaiSo();
                    Console.WriteLine(congHaiSo(a,b));
                    break;
                case 2:
                    nhapHaiSoTuBanPhim();
                    break;
                case 3:
                    nhapHaiSoTuBanPhim();
                    break;
                case 4:
                    nhapHaiSoTuBanPhim();
                    break;
                default:
                    break;
            }
        }
        static void nhapHaiSoTuBanPhim()
        {
            Console.Write("Mời bạn nhập sô a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mời bạn nhập sô b: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        static void congHaiSo()
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        static int congHaiSo(int a, int b)
        {
            return a + b;
        }
    }
}

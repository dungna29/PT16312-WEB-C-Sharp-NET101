using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._8_ToanTuBaNgoi
{
    class Program
    {
        /*
        * TOÁN TỬ 3 NGÔI
        * <Điều kiện hoặc nhiều điều kiện> ? <Kết quả nếu điều kiện đúng> : <Kết quả nếu điều kiện sai>;
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string kq = 5 > 6 ? "Đúng rồi" : "Sai rồi";
            string kq1 = (5 > 6) && (3 >=5) ? "Đúng rồi" : "Sai rồi";
            bool kq2 = 5 > 6 ? true : false;
            int kq3 = 5 > 6 ? 0 : 1;
            float kq4  = 5 > 6 ? 0.6f : 1.5f;
            double kq5  = 5 > 6 ? 0.6 : 1.5;
            var kq6  = 5 > 6 ? true : false;

            //Lưu ý:  Chỉ dùng trong trường hợp chỉ có 1 output đúng hoặc sai ra.

            //Giúp tiết kiệm line code đáng kể so với cách sử dụng IF thông thường dưới đây.
            if (5 > 6)
            {
                Console.WriteLine("Đúng rồi");
            } else
            {
                Console.WriteLine("Sai rồi");
            }

            //Viết 1 chương trình đăng nhập cần có User Pass
            while (true)
            {
                string user = "admin", pass = "123" ,userInput1 ,passInput;
                Console.Write("Mời bạn nhập user: ");
                userInput1 = Console.ReadLine();
                Console.Write("Mời bạn nhập pass: ");
                passInput = Console.ReadLine();
                string result = (userInput1 == user) && (passInput == pass) ? "Đăng nhập thành công" : "Đăng nhập thất bại";
                Console.WriteLine(result);
            }
        }
    }
}

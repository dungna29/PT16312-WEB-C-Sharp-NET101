using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._2_VongLap_For
{
    class Program
    {
        /*
         * Vòng lặp for
         *
         * Cách gõ: for + tab
         * Công thức:
         *  for (int i = 0; i < UPPER; i++)
            {
                //Thực hiện 1 hành động lặp lại 1 công việc nào đó.
            }
            int i = 0: Điểm bắt đầu của vòng lặp
            i < UPPER: Điều kiện để ngắt vòng lặp
            i++: Tăng i lên 1
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Vòng lặp for in ra theo điều kiện i < 10
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Đây là vòng lặp for chạy " + i);
            }

            //Nếu muốn tác động for trở thành vòng lặp vô hạn thì cần tác động vào điều kiện và i.

        }
    }
}

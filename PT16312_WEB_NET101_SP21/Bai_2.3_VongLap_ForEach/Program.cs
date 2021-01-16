using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._3_VongLap_ForEach
{
    class Program
    {
        /*
         * Vòng lặp foreach
         * Cách gõ: fore + tab
         *
         * Công thức:
         *  foreach (var VARIABLE in COLLECTION)
            {
                
            }
            var: Kiểu dữ liệu đã học ở bài khai báo biến
            VARIABLE: tên biến có thể đặt tùy ý và nó đại diện cho kiểu dữ liệu.
            COLLECTION//Array: Phải là 1 tập hợp nhiều giá trị.
         */
        static void Main(string[] args)
        {
            string[] arrName = {"C# 1", "Java 1", "C++"};
            foreach (var x in arrName)
            {
                Console.WriteLine(x + " ");
            }
            //Tương tự như cách dùng for
            for (int i = 0; i < arrName.Length; i++)
            {
                Console.WriteLine(arrName[i] + " ");
            }
            Console.ReadKey();
        }
    }
}

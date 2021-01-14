using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._9_Switch_Case
{
    class Program
    {
        /*
        * Switch Case câu lệnh rẽ nhành và thường được sử dụng làm menu trong lập trình.
        *
        * Công thức: sw + tab
        *
        *  switch (<Biểu thức>)
           {
               case <giá trị 1>:
                   Thực hiện 1 hành động nào đó nếu vào đúng case
                   break; 
               case <giá trị 2>:
                   Thực hiện 1 hành động nào đó nếu vào đúng case
                   break;
               .......
               case <giá trị n>:
                   Thực hiện 1 hành động nào đó nếu vào đúng case
                   break;
               default:
                   Khi không thỏa mãn tất cả các trường hợp trên thì sẽ vào default
                   break;
           }
        */
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
                double so1, so2;
                int input;
                Console.Write("Mời bạn nhập số thứ 1 :");
                so1 = double.Parse(Console.ReadLine());
                Console.Write("Mời bạn nhập số thứ 2 :");
                so2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Chương trình máy tính POLY");
                Console.WriteLine("1. Phép cộng");
                Console.WriteLine("2. Phép trừ");
                Console.WriteLine("Mời bạn chọn chức năng: ");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Phép cộng: {0} + {1} = {2}", so1, so2, so1 + so2);
                        break;
                    case 2:
                        Console.WriteLine("Phép trừ: {0} - {1} = {2}", so1, so2, so1 - so2);
                        break;
                    default:
                        Console.WriteLine("Chức năng bạn chọn không tồn tại");
                        break;
                }
            }
        }
    }
}

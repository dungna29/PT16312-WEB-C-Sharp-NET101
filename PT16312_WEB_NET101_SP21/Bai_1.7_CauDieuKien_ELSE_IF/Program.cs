using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._7_CauDieuKien_ELSE_IF
{
    class Program
    {
        /*
        * Bài  1.7 Cầu điều kiện Else If dùng trong trường hợp có nhiều điều kiện khác nhau và thực hành động tương ứng với từng điều kiện. Else If phải luôn True thì mới thực hiện hành động bên trong nó.
        *
        * Lưu ý: Nếu thỏa mãn 1 điều kiện thì nó chỉ thực hiện hành động trong điều kiện đó mà thôi.
        *
        * Công thức:
        *   if (true)
           {
               //Thực hiện 1 hành động nếu If đúng
           }else if (<Điều kiện 1>)
           {
               //Khi If không thỏa mãn và Else If phải true thì mới vào đây thực hiện 1 hành động.
           }else if (<Điều kiện 2>)
           {
               //Tương tự
           }else
           {
               //Khi tất cả các điều kiện ở trên không thỏa mãn thì sẽ vào đây
           }
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            /*
             * Viết 1 chương trình nhập chỉ số cân nặng của người dùng:
             * Cân nặn từ 40 đến 50kg --> Quá gầy
             * Cân nặn từ 51 đến 65kg --> Mức bình thường
             * Cân nặn từ 66 đến 80kg --> Mức hơi mập
             * Cân nặn từ 81 đến 100kg --> Mức béo phì
             * Cân nặn từ 100 đến 200kg --> Mức siêu béo phì 
             */
            while (true)
            {
                double canNang;
                Console.Write("Mời bạn nhập cân nặng vào đây: ");
                canNang = Convert.ToDouble(Console.ReadLine());
                if (canNang <= 50)
                {
                    Console.WriteLine("Quá gầy");
                }else  if (canNang <= 65)
                {
                    Console.WriteLine("Mức bình thường");
                }else  if (canNang <= 80)
                {
                    Console.WriteLine("Mức hơi mập");
                }else  if (canNang <= 100)
                {
                    Console.WriteLine(" Mức béo phì");
                }else  
                {
                    Console.WriteLine("Mức siêu béo phì ");
                }
            }
        }
    }
}

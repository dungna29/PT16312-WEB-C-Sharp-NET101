using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._6_CauDieuKien_IF_ELSE
{
    class Program
    {
        /*
         * Bài 1.6 Cầu điều kiện IF...ELSE (Nếu Thì)
         * Dùng để thực hiện 1 hành động nếu IF(TRUE) và ngược lại sẽ vào Else.
         *
         * Cấu trúc: 
         * if (true)
            {
                Nếu mà If true thì sẽ thực hiện 1 hành động nào đó
            }
            else
            {
                Nếu không thỏa mãn IF thì mặc định là vào ELSE
            }
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Nhập số buổi nghỉ vào để kiểm tra có bị cấm thi hay không
            //Bước 1: Xác định số lượng biến sử dụng
            while (true)
            {
                int nghi;
                //Bước 2: Gán giá trị
                Console.Write("Bạn nhập số buổi nghỉ vào đây: ");
                nghi = Convert.ToInt32(Console.ReadLine());//Gán giá trị 
                //Bước 3: Xử lý nghiệp vụ  
                if (nghi <=0)//Lọc giá trị khi người dùng nhập vào âm
                {
                    Console.WriteLine("Kiểu số không được phép âm");
                }
                else
                {
                    if (nghi <= 4)
                    {
                        Console.WriteLine("Chúc mừng bạn vẫn được đi học");
                    }
                    else
                    {
                        Console.WriteLine("Chúc mừng bạn mất 700k");
                    }
                }
               
            }

        }
    }
}

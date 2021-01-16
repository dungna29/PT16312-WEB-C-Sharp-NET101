using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._4_BaiTap_OnTap
{
    class Program
    {
        /*
        * Bài tập ôn tập tổng hợp:
        * Viết 1 chương trình có menu sử dụng switch case và vòng lặp:
        *         ------Chương trình 1-------
        *       1. In bảng cửu chương đơn
        *       2. In bảng cửu theo khoảng
        *       3. Kiểm tra học lực Sinh Viên Poly
        *       4. Nhập thông tin người yêu
        *       5. Thoát.
        *
        * Giải thích:
        *1. In bảng cửu chương đơn: Mời người dùng nhập vào tên 1 bảng cửu chương mà họ muốn sau đó in ra màn hình.
        *
        * 2. In bảng cửu theo khoảng: Mời người dùng nhập vào tên bảng cửu chương theo khoảng. Ví dụ: từ bảng nhân 5 đến nhân 8.
        *
        *3. Kiểm tra học lực Sinh Viên Poly: Cho sinh viên POLY nhập vào điểm tổng kết môn C# và thông báo xếp loại học lực:
        *  diem<=5 --> Yếu
        *  diem<=7 --> Khá 
        *  diem<=8 --> Tiên Tiến
        *  diem<=9 --> Giỏi
        *  diem<=10 --> Xuất sắc
        *
        *  4. Nhập thông tin người yêu: Nhập các thông tin sau của người yêu và bản thân mình gồm các thông tin sau: Tên, Năm Sinh, Giới tính, Chiều cao
        * - Yêu cầu cả bạn và người yêu đều phải nhập tất cả các thông tin trên sau đó in ra dự trên các thông tin đã nhập vào như sau:
        * - Tên người yêu:
        * - Năm sinh:
        * - Tuổi người yêu:       <In thêm Kém tuổi hoặc Lớn tuổi>        
        * - Giới tính:             <In thêm Khác giới  hoặc Cùng Giới>
        * - Chiều cao:             <In thêm Cao hơn hoặc Thấp hơn>
        *  Các câu in ra đều phụ thuộc vào việc so sánh giữa các thông số của em và người yêu đã được nhập từ đầu.
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Viết 1 chương trình cho người dùng nhập vào 1 bảng cửu chương phải sử dụng cả 3 vòng lặp for, while, do...while
            int input;
            Console.Write("Mời bạn nhập bảng cửu chương muốn in: ");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bảng cửu chương nhân  {0}", input);
            //Cách dùng for
            // for (int i = 1; i < 10; i++)
            // {
            //     Console.WriteLine("{0} x {1} = {2}",input,i,input*i);
            // }

            //While
            // int i = 1;
            // while (i < 10)
            // {
            //     Console.WriteLine("{0} x {1} = {2}", input, i, input * i);
            //     i++;
            // }

            //do while
            int i = 1;
            do
            {
                Console.WriteLine("{0} x {1} = {2}", input, i, input * i);
                i++;
            } while (i < 10);

            //In tất cả bảng cửu chương sử dụng vòng lặp while
            int k = 1;
            int j = 1;
            while (k <=10)
            {
                Console.WriteLine("Bảng cửu chương nhân  {0}", k);
                j = 1;//Reset lại j về 1 để tiếp tục chạy vào while dưới đây
                while (j < 10)
                {
                    Console.WriteLine("{0} x {1} = {2}", k, j, k * j);
                    j++;
                }
                k++;
            }
            Console.ReadKey();
        }
    }
}

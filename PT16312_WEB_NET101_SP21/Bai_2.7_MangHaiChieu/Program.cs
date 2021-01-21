using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._7_MangHaiChieu
{
    class Program
    {
        /*
        * MẢNG 2 CHIỀU - MẢNG ĐA CHIỀU (TỰ TÌM HIỂU)
        * Mảng 2 chiều cần quan tâm đến cột và q
        *
        * Công thức: <kiểu dữ liệu>[,] = new <Kiểu dữ liệu>[row,column]
        *  row: Số lượng hàng kiểu số nguyên
        *  column: Số lượng cột kiểu số nguyên
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //1. Khai báo
            int[,] arrNumber = new int[2, 3];//Khởi tạo 1 mảng 2 chiều gồm 2 hàng và 3 cột

            //2. Gán giá trị cho mảng 2 chiều
            //Gán giá trị trên dòng 0
            arrNumber[0, 0] = 5;
            arrNumber[0, 1] = 6;
            arrNumber[0, 2] = 7;

            //Gán giá trị trên dò 1
            arrNumber[1, 0] = 8;
            arrNumber[1, 1] = 9;
            arrNumber[1, 2] = 10;

            //3. Lấy giá trị
            Console.WriteLine(arrNumber[1, 0]);
            Console.WriteLine();
          
            //for
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arrNumber[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Ví dụ mẫu nhập mảng 2 chiều do người dùng
            int row, col;
            int[,] arrNumberInput;
            Console.WriteLine("Chương trình tạo mảng 2 chiều");
            Console.Write("Mời bạn nhập số lượng row: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mời bạn nhập số lượng col: ");
            col = Convert.ToInt32(Console.ReadLine());

            //Khởi tạo mảng
            arrNumberInput = new int[row, col];
            
            //Nhập dữ liệu vào mảng 2 chiều
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Giá trị tại row: {0} - col{1}: ", i,j);
                    arrNumberInput[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Xuất giá trị mảng 2 chiều
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Giá trị tại row: {0} - col{1}: = {2}", i, j, arrNumberInput[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._6_ThaoTacVoiMang
{
    class Program
    {
        /*
        * Bài 2.6 Thao tác với mảng
        *  - 1. Phương thức của Array
        *      + SetValue(<giá trị>,<index>): Gán giá trị cho phần tử ở vị trí.
        *      + GetValue(index): lấy giá trị ở vị trí
        *      + IndexOf(<Array>,<value>): Tìm kiếm vị trí của phần tử
        *      + GetLength(0): Trả ra số lượng phần tử trong mảng
        *      + Reverse(<mảng>): Đảo ngược mảng
        *      + Sort(Array): Sắp xếp mảng
        
        */

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string[] arrNames = { "B", "C", "A", "F", "E", "D" };
            //In mảng
            Console.WriteLine("Mảng kiểu chuỗi: ");
            foreach (var x in arrNames)
            {
                Console.Write(x + " ");
            }

            //1. Sort
            Console.WriteLine("\n Sắp xếp mảng : ");
            Array.Sort(arrNames);//Sắp xếp mảng từ bé đến lớn
            foreach (var x in arrNames)
            {
                Console.Write(x + " ");
            }
            //2. Reverse
            Console.WriteLine("\n Reverse mảng : ");
            Array.Reverse(arrNames);//Sắp xếp mảng từ bé đến lớn
            foreach (var x in arrNames)
            {
                Console.Write(x + " ");
            }

            //3. Một vài phương thức khác 
            Console.WriteLine("\n SetValue mảng : ");
            arrNames.SetValue("fpt", 0);//Gán giá trị mới cho vị trí của mảng.
            foreach (var x in arrNames)
            {
                Console.Write(x + " ");
            }
            //GetValue - Lấy giá trị khi biết vị trí
            Console.WriteLine("\n Vị tri 3: " + arrNames.GetValue(3));
            //Indexof
            Console.WriteLine("\n IndexOf: C " + Array.IndexOf(arrNames, "C"));

            //Getlength
            Console.WriteLine("\n Độ dài của mảng: " + arrNames.GetLength(0));

            //Thuật xoán sắp xếp nổi bọt
            int[] arrNumber = { 99, 55, 66, 77, 11, 33 };
            Console.WriteLine("Mảng ban đầu :");
            foreach (var x in arrNumber)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Giải thích thuật toán");
            //Thuật toán sắp xếp nổi bọt
            for (int i = 0; i < arrNumber.Length; i++)
            {
                Console.WriteLine("\n Tại thời điểm i = " + i);
                foreach (var x in arrNumber)
                {
                    Console.Write(x + " ");
                }
                for (int j = i + 1; j < arrNumber.Length; j++)
                {
                    Console.WriteLine("\n Tại thời điểm j = " + j);
                    Console.WriteLine("Điều kiện:  " + arrNumber[i] + " > " + arrNumber[j]);
                    if (arrNumber[i] > arrNumber[j])
                    {
                        int temp = arrNumber[i];
                        arrNumber[i] = arrNumber[j];
                        arrNumber[j] = temp;
                        Console.WriteLine("Sau khi đổi chỗ: ");
                        foreach (var x in arrNumber)
                        {
                            Console.Write(x + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("\n Sau khi sắp xếp");
            foreach (var x in arrNumber)
            {
                Console.Write(x + " ");
            }
            Console.ReadKey();
            /*
             * Bài 1: Viết 1 chương trình cho phép người dùng nhập vào bao nhiêu số tùy thích. Sau khi nhập xong in ra màn hình các số chẵn trên 1 dòng và số lẻ trên 1 dòng.
             *
             * Bài 2: Viết 1 chương trình cho phép người dùng nhập vào 1 dãy điểm. In ra màn hình dãy điểm người vừa nhập và bệnh cạnh mỗi 1 đầu điều thông báo Trượt hoặt đỗ dựa trên điều kiện điểm đỗ >=5 và Trượt <5.
             *
             * Bài 3: Viết 1 chương trình nhập nhiều  thông tin của sinh viên POLY. Mỗi sinh viên khi nhập vào cần các thông tin sau: Tên, Năm Sinh, Msv. Sau khi người dùng nhập xong hết thông tin sinh viên cần thêm thì sẽ in tất cả ra màn hình lưu in thêm tuổi của mỗi sinh viên tương ứng.
             */
        }
    }
}

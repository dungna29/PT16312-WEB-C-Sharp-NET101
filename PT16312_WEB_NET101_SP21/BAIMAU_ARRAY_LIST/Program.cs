using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAIMAU_ARRAY_LIST
{
    class Program
    {
        static void Main(string[] args)
        {
            //Phần 1 : Liệt kê các biến cần sử dụng
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            int input;
            int[] arrNumbetB1;
            List<double> lstDiemBai2 = new List<double>();
            //Phần 1: Tạo menu cho người dùng nhìn
            Console.WriteLine("Bài tập mẫu");
            Console.WriteLine("Bài 1");
            Console.WriteLine("Bài 2");
            Console.WriteLine("Bài 3");
            Console.WriteLine("Mời bạn chọn chức năng");
            input = Convert.ToInt32(Console.ReadLine());//Gán giá trị do người dùng nhập vào
            switch (input)
            {
                case 1:
                    Console.WriteLine("Bạn muốn nhập bao nhiêu số? :");
                    input = Convert.ToInt32(Console.ReadLine());
                    //Khởi tạo mảng sau khi lấy được giá trị của người dùng
                    arrNumbetB1 = new int[input];
                    //Nhập dữ liệu vào mảng sử dụng vòng lặp
                    for (int i = 0; i < arrNumbetB1.Length; i++)
                    {
                        Console.WriteLine("Mời bạn nhập số thứ : " + i);
                        //Gán giá trị cho từng vị trí của mảng
                        arrNumbetB1[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    //In mảng ra màn hình
                    foreach (var x in arrNumbetB1)
                    {
                        Console.WriteLine(x);//x là giá trị ở trong mảng số nguyên
                    }

                    break;
                case 2:
                    Console.WriteLine("Bạn muốn nhập bao điểm số C#? :");
                    input = Convert.ToInt32(Console.ReadLine());
                    //Nhập dữ liệu vào List điểm được khai báo ở trên
                    for (int i = 0; i < input; i++)
                    {
                        //Thực hiện thêm phần tử vào List
                        Console.WriteLine("Mời bạn nhập điểm thứ : " + i);
                        lstDiemBai2.Add(Convert.ToDouble(Console.ReadLine()));
                    }
                    //In ra những điểm < 5
                    foreach (var x in lstDiemBai2)
                    {
                        if (x < 5)//Nếu x là điểm < 5 thì mới được in điểm đó
                        {
                            Console.WriteLine("Điểm nhỏ hơn 5 = " + x);
                        }

                    }
                    //In số điểm cao nhất trong dãy điểm
                    double max = lstDiemBai2[0];
                    foreach (var x in lstDiemBai2)
                    {
                        if (max < x)
                        {
                            //Gán lại giá trị cho biến max nếu max nhỏ hơn x
                            max = x;
                        }
                    }
                    //In giá trị max ra màn hình
                    Console.WriteLine("Điểm C# cao nhất là: " + max);
                    Console.WriteLine("Điểm C# cao nhất là: " + lstDiemBai2.Max());//Sử dụng câu lệnh LINQ

                    //In tất cả các index lẻ trong List
                    for (int i = 0; i < lstDiemBai2.Count; i++)
                    {
                        // if (i%2==0)
                        // {
                        //     continue;
                        // }
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(lstDiemBai2[i]);
                        }
                    }
                    break;
                case 3:
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}

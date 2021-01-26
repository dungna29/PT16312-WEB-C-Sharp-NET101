using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._2_Method_HamTraVe
{
    class Program
    {
        /*
        * Hàm trả về công thức và định nghĩa ở bên Project 3.1
        *
        * Định nghĩa: Hàm trả về bắt buộc phải trả về 1 giá trị hoặc 1 tập giá trị, đối tượng.... tương ứng với kiểu dữ liệu của hàm.
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //1. Sử dụng hàm trả về không tham số
            // Coi hàm trả về là 1 giá trị hoặc 1 tập giá trị hoặc 1 đối tượng....
            int year = 2020;
            getYear();//Không in ra gì vì hàm là 1 giá trị  = 2020
            Console.WriteLine(getYear() + 1);

            //Sử dụng hàm trả về dạng tập giá trị
            foreach (var x in getListByDungna())
            {
                Console.Write(x + " ");
            }

            for (int i = 0; i < getListByDungna().Length; i++)
            {
                Console.Write(getListByDungna()[i] + " ");
            }

            //Gọi hàm là 1 đối tượng
            Console.WriteLine(getSinhVien().ten);
            Console.ReadKey();
        }
        //Phần 1: Hàm trả về không tham số
        //Ví dụ hàm trả về kiểu giá trị đơn: int,string,double.....
        static int getYear()
        {
            //Hàm bắt buộc phải trả về đúng kiểu dữ liệu của hàm
            // return <trả về đúng kiểu dữ liệu>
            int a = 2020;
            return a;
        }

        //Ví dụ hàm trả về là tập giá trị: Array,List...
        static int[] getListByDungna()
        {
            //int[] arrYear = {1980,1981......}
            int[] arrYear = new int[2021 - 1989];
            int temp = 0;
            for (int i = 1989; i < 2021; i++)
            {
                arrYear[temp] = i;
                temp++;
            }
            return arrYear;
        }

        //Hàm trả về 1 đối tượng
        static SinhVien getSinhVien()
        {
            SinhVien sv1 = new SinhVien();
            sv1.ten = "Long";
            return sv1;
        }


        //int year = tham số có kiểu dữ liệu và đặt tên tham số
        static int inRaManHinhCoThamSo(int year, string name)
        {
            //Coi tham số như là biến có thể thao tác được với nó
            return 0;
        }
        static List<string> inRaManHinhCoThamSo(int[] year, string[] name, List<string> lstname, SinhVien sinhvien)
        {
            //Coi tham số như là biến có thể thao tác được với nó
            return null;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai_3._0_OOP_LapTrinhHuongDoiTuong;

namespace Bai_3._1_Method_PhuongThucKhongTraVe
{
    class Program
    {
        /*
         *  Bài 3.1 Hàm -Phương thức - Method
         *  Định nghĩa: 1 tập các câu lệnh cùng nhau thực hiện 1 tác vụ nào đó.
         *  LỢI ÍCH: - Giúp quản lý code tốt hơn
         *           - Tái sử dụng
         *
         *  Công thức chung:
         *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
         *  {
         *          Body code
         *  }
         * <Phạm vi truy cập> - Access Specifier:Public,Private,Protected, Default
         *
         * <Kiểu trả về> : có 2 kiểu trả về và không trả về
         *          - Kiểu không trả về: void
         *          - Kiểu trả về: là giá trị đơn(int,string,double....) hoặc tập giá trị(Array,List.....) hoặc đối tượng(class) và còn nhiều kiểu khác.
         *
         * <Tên phương thức>: Tên động từ viết thường + tên.
         * <Danh sách tham số>: Phương thức có thể có tham hoặc không tham số và lưu ý khi sử dụng tham số thì khi gọi phương thức thì phải truyền đúng vị trí của tham số và kiểu dữ liệu.
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.WriteLine("Chúc mừng năm mới FPT");
            Console.WriteLine("Chúc mừng năm mới FPT");
            Console.WriteLine("Chúc mừng năm mới FPT");
            Console.WriteLine("Chúc mừng năm mới");
            Console.WriteLine("Chúc mừng năm mới");
            Console.WriteLine("Chúc mừng năm mới");
            Console.WriteLine("Chúc mừng năm mới");

            //1. Gọi hàm không tham số: Cần phải biết tên hàm, phạm vi truy cập của hàm không bị private khi gọi từ Class khác.
            inRaManHinh();//Bắt buộc phải kết thúc bằng ()
           
            //2. Gọi hàm có tham số: Bắt buộc phải truyền đủ tham số theo thứ tự của hàm và phải đúng kiểu dữ liệu
            inRaManHinhCoThamSo(2021,"Long");
            Console.ReadKey();
        }
        //Phần 1: Kiểu không trả về và không tham số
        static void inRaManHinh()
        {
            //Body code thực hiện nhiều câu lệnh để giải quyết 1 nghiệp vụ nào đó. Ví dụ: Tách menu, các chức năng.......
            Console.WriteLine("Chúc mừng năm mới FPT");
        }
        //Phần 2: Kiểu không trả về và có tham số

        //Tham số trả về các giá trị đơn
        //int year = tham số có kiểu dữ liệu và có tên tham số
        static void inRaManHinhCoThamSo(int year, string name)
        {
            //Coi tham số như là biến thì có thể thao tác được với nó
            Console.WriteLine("Chúc mừng năm mới FPT" +" "+year +" " +"Chào bạn :" + name);
        }

        static void inRaManHinhCoThamSo2(int[] arrNumber, int a, List<string> lstName, SinhVien sv1)
        {

        }

    }
}

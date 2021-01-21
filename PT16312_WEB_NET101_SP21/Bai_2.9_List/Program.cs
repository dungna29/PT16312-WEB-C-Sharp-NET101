using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._9_List
{
    class Program
    {
        /*
         *  LIST trong C# Generic Collections nó dùng lưu trữ giống như ArrayList vê khái niệm.
         *
         *  1.Khai báo:
         *      List<Kiểu dữ liệu> lst + Tên =  new List<Kiểu dữ liệu>();
         *      List<Kiểu dữ liệu> lst + Tên =  new List<Kiểu dữ liệu>(size);//Khai báo kích thước định sẵn
         */

        /*
         * A. CÁC PHƯƠNG THỨC TRONG List
         * 1. Add(object Value): Thêm đối tượng vào cuối.
         * 2. AddRange(ListObject): Thêm danh danh sách vào cuối.
         * 3. BinarySearch(object Value): Tìm kiếm value trong danh sách. Nếu tìm thấy sẽ trả lại index và không tìm thấy thì trả lại index âm. Để sử dụng danh sách phải sắp xếp.
         * 4. Clear(): Xóa tất cả các phần tử.
         * 5. Clone(): Tạo 1 bản sao của danh sách đó.
         * 6. Contains(object Value): Kiểm tra đối tượng value có tồn tại trong danh sách hay không? - Trả ra true hoặc false
         * 7. Getrange(int StartIndex, int EndIndex): Trả về 1 danh sách bao gồm các phần tử từ điểm được chỉ định.
         * 8. IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện trong danh sách và nếu không tìm thấy trả về -1.
         *9.CopyTo(<tên mảng>,<index>): Thực hiện sao chép các phần tử List về mảng 1 chiều từ index của mảng
         * 10. Remove(<value>): Xóa value ở trong List
         *
         * Ngoài ra còn có thêm 1 số phương thức khác
         */
        /*
            Triển khai 3 bài dưới bằng List
               * Bài 1: Viết 1 chương trình cho phép người dùng nhập vào bao nhiêu số tùy thích. Sau khi nhập xong in ra màn hình các số chẵn trên 1 dòng và số lẻ trên 1 dòng.
               *
               * Bài 2: Viết 1 chương trình cho phép người dùng nhập vào 1 dãy điểm. In ra màn hình dãy điểm người vừa nhập và bệnh cạnh mỗi 1 đầu điều thông báo Trượt hoặt đỗ dựa trên điều kiện điểm đỗ >=5 và Trượt <5.
               *
               * Bài 3: Viết 1 chương trình nhập nhiều  thông tin của sinh viên POLY. Mỗi sinh viên khi nhập vào cần các thông tin sau: Tên, Năm Sinh, Msv. Sau khi người dùng nhập xong hết thông tin sinh viên cần thêm thì sẽ in tất cả ra màn hình lưu in thêm tuổi của mỗi sinh viên tương ứng.
               */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //1. Khai báo
            List<int> lstNumber = new List<int>();
            List<string> lstName;
            lstName = new List<string>();

            List<double> lstDiem = new List<double>(5);

            //2. Gán giá trị
            lstName.Add("FPT");
            lstName.Add("BK");
            lstName.Add("POLY");

            //3. Lấy giá trị <tên list>[index]
            Console.WriteLine(lstName[1]);
           
            //Ví dụ mẫu
            //Viết 1 chương trình nhập mã sinh viên POly số lượng theo người dùng chỉ định
            List<string> lstMsv = new List<string>();
            int input;
            Console.WriteLine("Bạn muốn nhập vào bao nhiêu msv? ");
            input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("Nhập mã thứ: " + i);
                //Đổ giá trị vào trong List
                lstMsv.Add(Console.ReadLine());
            }
            
            //In ra màn hình
            foreach (var x in lstMsv)
            {
                Console.WriteLine(x);
            }
            
            Console.ReadKey();
        }
    }
}

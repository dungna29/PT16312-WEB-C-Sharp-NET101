using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._3_EpKieuTrongLapTrinh
{
    class Program
    {
        /*
         * P1: Ép kiểu - Chuyển đổi từ kiểu dữ liệu số sang dạng số khác - Không đổ kiểu dữ liệu lớn về bé mà chỉ bé lên lớn ví dụ int lớn hơn byte hoặc long nhất trong số nguyên. Ngoài ra các bạn có thể tham khảo lại trong bảng kích thước kiểu dữ liệu.
         *
         * Công thức ép kiểu tường minh:
         *        (<kiểu dữ liệu>) <biến cần ép kiểu>;
         *
         * P2: Ép kiểu từ string về số
         *  + Phương thức Parse()
         *  + Lớp Convert()
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //P1: Ép kiểu từ kiểu dữ liệu số
            //Ví dụ 1:
            byte a = 1;
            int b = 1;
            b = a;// Chuyển đổi kiểu dữ liệu đúng vì int lớn hơn byte
            //a = b;// Chuyển đổi kiểu dữ liệu không đúng vì int lớn hơn byte

            //Ví dụ 2:
            double diem1 = 9.2;
            long temp;
            temp = (long)diem1;//Cast là ép kiểu từ số thực về số nguyên
            Console.WriteLine("Sau khi ép kiểu từ double về long" + temp);
           

            //P2: Ép kiểu từ string về số
            // Ví dụ: Parse
            string tempstring = "2020";//2020 nhưng ở dạng chuỗi không thể tính toán được
            int intParse = int.Parse(tempstring);//Ép kiể string về số nguyên
            double doubleParse = double.Parse(tempstring);
            bool boolParse = bool.Parse("true");

            //Ví dụ: Convert
            string tempstring1 = "2020";
            int intConvert = Convert.ToInt32(tempstring1);
            double intConvert = Convert.ToDouble("8.6");
            bool boolConvert = Convert.ToBoolean("false");
            Console.ReadKey();
        }
    }
}

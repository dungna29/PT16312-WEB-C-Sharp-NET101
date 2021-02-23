using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_Contructor
{
    class Program
    {
        /*
         * Đặc tả truy xuất trong C# - Phạm vi truy cập - Access Modifier c#
         * 1. Public: Không giới hạn khi truy cập
         * 2. Private: Chỉ được phép truy cập ở bên trong của Class
         * 3. Protected: Chỉ có các class con mới có thể truy cập
         * 4. Internal: Chỉ được phép sử dụng bên trong project
         * 5. Protected internal: 
         */

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            
            //Phần 1: Gọi đối tượng ra để sử dụng thì cần phải biết tên đối tượng
            SinhVien sv1 = new SinhVien();//Tạo ra 1 đối tượng sinh viên
            //Gán giá trị cho thuộc tính đối tượng thì sử dụng biến đối tượng chấm ra các thuộc tính
            sv1.tenSv = "Lê Văn Lưu";
            sv1.tuoi = 28;//Gán đúng kiểu dữ liệu cho thuộc tính của đối tượng
            sv1.diemCsharp = 6;

            //In thông tin của đối tượng
            Console.WriteLine(sv1.tenSv +" " + sv1.diemCsharp);

            //Phần 2: Contructor không tham số (Nếu trong Class không tạo ra contructor thì C# sẽ ngầm hiểu tạo ra 1 Contructor không tham số)
            SinhVien sv2 = new SinhVien();
            sv2.tenSv = "Nguyễn Đức Tuấn";
            sv2.tuoi = 28;//Gán đúng kiểu dữ liệu cho thuộc tính của đối tượng
            sv2.diemCsharp = 6;
            Console.WriteLine(sv2.tenSv + " " + sv2.diemCsharp);

            //Phần 3: Contructor có tham số
            //Khi sử dụng Contructor phải gán giá trị cho thuộc tính của đối tượng khi sử dụng
            //Khi truyền tham số phải đúng vị trí và kiểu dữ liệu
            SinhVien sv3 = new SinhVien("Dũng", "dungna", 30, 5);
            //sv3.tenSv = "Nguyễn Anh Dũng";//Vẫn có thể gán lại giá trị nếu muốn
            Console.WriteLine(sv3.tenSv + " " + sv3.diemCsharp);

            //Phần 4: Khi các thuộc tính bị Private phải sử dụng Getter và Setter để gán và lấy giá trị
            GiaoVien gv1 = new GiaoVien();
            //Gán giá trị sử dụng Setter
            gv1.setTenGV("Dũng");
            int tuoi = -1;
            gv1.setTuoiGV(tuoi);
            //Lấy giá trị sử dụng Getter
            Console.WriteLine(gv1.getTenGV() + " " + gv1.getTuoiGV() + " " + gv1.getTruongGV());

            /*
            * Bài tập:
            * Viết 1 chương trình cho người dùng nhập vào 1 đối tượng Sinh Viên gồm các thuộc tính : Ten,Tuoi,Msv,Sdt sau đó in ra .
            * - Tạo 1 Class đối tượng hoàn chỉnh gồm 4 phần có private thuộc tính
            */
        }
    }
}

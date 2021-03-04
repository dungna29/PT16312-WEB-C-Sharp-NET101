using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._5_KETHUA
{
    class Program
    {
        /*
         * KỂ THỪA TRONG C#
         * - Trong C# hoặc Java 1 lớp con chỉ có 1 cha. Không có đa kế thừa.
         * - Khi kế thừa lớp con sẽ kế thừa các thuộc tính và phương thức của lớp cha,.
         *
         * - this: Tham chiếu đến thuộc tính và phương thức của lớp hiện tại.
         * - base: Tham chiếu đến thuộc tính và phương thức của lớp cha.
         */
        static void Main(string[] args)
        {
            /*
             * Tạo 4 đối tượng
             * SinhVien1(Ho,TenDem,Ten,MaSv,DiemCsharp)
             * GiaoVien1(Ho,TenDem,Ten,MaGv,GioDay)
             * KeToan1(Ho,TenDem,Ten,MaKT,ChamCong)
             * BaoVe1(Ho,TenDem,Ten,MaBv,CaTruc)
             *
             * Dựa vào các class trên sẽ thấy bị trùng lặp các thuộc tính chung.
             */

            //P1: Gán giá trị cho đối tượng không áp dụng kế thừa
            SinhVien1 sv1 = new SinhVien1();
            sv1.Ho = "Nguyễn";
            sv1.Tendem = "Anh";
            sv1.Ten = "Dũng";
            sv1.MaSv = "dungna";
            sv1.DiemCsharp = 3;
           
            //Phần 2: Gán giá trị cho đối tượng có áp dựng kế thừa
            SinhVien sv2 = new SinhVien();
            sv2.Ho = "Nguyễn";
            sv2.Tendem = "Anh";
            sv2.Ten = "Dũng";
            sv2.MaSv = "dungna";
            sv2.DiemCsharp = 3;

            //Phần 3: Nạp chồng phương thức (Overloading) các phương thức có tên giống nhau nhưng tham số sẽ phải khác nhau đầu ra cũng sẽ khác nhau

            //Phần 4: Ghi đè phương thức- khi 1 lớp kế thừa phương thức của lớp cha thì nó có thể thay đổi code bên trong phương thức đó.
            Person p1 = new Person();
            p1.inRaManHinhPerson();
            SinhVien sv3 = new SinhVien();
            sv3.inRaManHinhPerson();
            /*
             * Viết 1 chương trình quản lý giao viên
             * Person(ho,tendem,ten,sdt,quequan) - Lớp Cha
             * GiaoVien(maGv - gioDay)
             *
             *- 2 chức năng sau:
             *  1. Thêm 1 giáo viên
             *  2. Thêm nhiều giáo viên
             */
        }

        //Nạp chồng phương thức
        static void phuongThuc1()
        {

        }
        static void phuongThuc1(int a)
        {

        }
        static void phuongThuc1(int a,int b)
        {

        }
    }
}

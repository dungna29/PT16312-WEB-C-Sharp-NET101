using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._4_TaoDoiTuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Program p = new Program();
            p.tao2DoiTuongContructor();
            //p.tao1DoiTuong();
            // p.tao1MangDoiTuong();
            //p.tao1ListDoiTuong();

        }

        //1. Sử dụng contructor đẻ tạo đối tượng
        void tao2DoiTuongContructor()
        {
            //Contructor không tham số
            GiaoVien gv1 = new GiaoVien();//Khởi tạo 1 đối tượng
            gv1.Ten = "Dũng";
            gv1.Magv = "Dungna";
            gv1.NamSinh = 1999;
            gv1.DiaChi = "Số 1 đường tây hồ";
            gv1 = new GiaoVien();//gv1 sẽ bị khởi tạo lại và các thuộc tính sẽ null
            gv1.inRaManHinh();

            //Contructor có tham số
            GiaoVien gv2 = new GiaoVien("Minh", "MinhDQ", 2000, "Số 2 Tây hồ");
            gv2.inRaManHinh();
        }

        //2. Tạo 1 đối tượng do người dùng nhập liệu
        void tao1DoiTuong()
        {
            GiaoVien gv1 = new GiaoVien();
            Console.WriteLine("Mời bạn nhập tên: ");
            gv1.Ten = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập mã: ");
            gv1.Magv = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập năm sinh: ");
            gv1.NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập địa chỉ: ");
            gv1.DiaChi = Console.ReadLine();

            Console.WriteLine("Thông tin giáo viên bạn vừa nhập vào là: ");
            gv1.inRaManHinh();
        }

        //3. Tạo 1 mảng đối tượng cho người dùng nhập
        void tao1MangDoiTuong()
        {
            //Bước 1: Khai báo
            //Công thức khai báo mảng: <kiểu dữ liệu>[] tên mảng = new <kiểu dữ liệu>[kích thước];
            GiaoVien[] arrGiaoViens;
            int size;

            //Bước 2: triển khai
            Console.WriteLine("Mời bạn nhập số GV: ");
            size = Convert.ToInt32(Console.ReadLine());
            //Sau khi người dùng nhập số lượng giáo viên mong muốn thì tiến hành khởi tạo mảng
            arrGiaoViens = new GiaoVien[size];
            for (int i = 0; i < size; i++)
            {
                arrGiaoViens[i] = new GiaoVien();//Khởi tạo đối tượng tại vị trí thứ i
                Console.WriteLine("Mời bạn nhập tên: ");
                arrGiaoViens[i].Ten = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập mã: ");
                arrGiaoViens[i].Magv = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập năm sinh: ");
                arrGiaoViens[i].NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập địa chỉ: ");
                arrGiaoViens[i].DiaChi = Console.ReadLine();
            }

            //Bước 3: In 
            foreach (var x in arrGiaoViens)
            {
                x.inRaManHinh();
            }

           
        }
        //4. Tạo 1 List đối tượng do người dùng nhập
        void tao1ListDoiTuong()
        {
            //Bước 1: Khai báo
            List<GiaoVien> lstGiaoViens = new List<GiaoVien>();
            GiaoVien gv1;
            int size;

            //Bước 2: triển khai
            Console.WriteLine("Mời bạn nhập số GV: ");
            size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                gv1 = new GiaoVien();
                Console.WriteLine("Mời bạn nhập tên: ");
                gv1.Ten = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập mã: ");
                gv1.Magv = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập năm sinh: ");
                gv1.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập địa chỉ: ");
                gv1.DiaChi = Console.ReadLine();
                lstGiaoViens.Add(gv1);//Gán đối tượng vào List đối tượng sau mỗi 1 vòng chạy
            }

            //Bước 3: In 
            foreach (var x in lstGiaoViens)
            {
                x.inRaManHinh();
            }
        }
    }
}

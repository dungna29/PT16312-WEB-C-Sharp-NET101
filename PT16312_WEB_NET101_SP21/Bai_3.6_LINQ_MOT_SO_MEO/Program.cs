using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._6_LINQ_MOT_SO_MEO
{
    class Program
    {
        private static List<SinhVien> _lstSinhViens = new List<SinhVien>();
        private static string _input;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            them5SV();
            xuatDs();
            Console.WriteLine("--------------------------------");
            // timKiemSinhVien();
            // Console.WriteLine("Ds sinh viên sau khi sắp xếp");
             sortSinhVien();
             xuatDs();
            //timKiemSinhVienKhongDiem();
        }

        static void xuatDs()
        {
            foreach (var x in _lstSinhViens)
            {
                x.inRaManHinh();
            }
        }
        static void them5SV()
        {
            SinhVien sv1 = new SinhVien("Nguyễn", "Anh", "Z", "PH00532", 5, -1, "Nam", "HN");
            SinhVien sv2 = new SinhVien("Hoàng", "Anh", "E", "PH00533", 6, -2, "Nam", "HN");
            SinhVien sv3 = new SinhVien("Đinh", "Anh", "W", "PH00534", 7, 3, "Nam", "HN");
            SinhVien sv4 = new SinhVien("Nguyễn", "Quốc", "A", "PH00535", 4, 5, "Nam", "HN");
            SinhVien sv5 = new SinhVien();
            sv5.Ho = "Đặng";
            sv5.TenDem = "Quang";
            sv5.Ten = "Minh";
            sv5.MaSv = "Ph000555";
            sv5.NamSinh = 1998;
            sv5.DiemCsharp = 8;
            sv5.GioiTinh = "Nam";
            sv5.QueQuan = "ĐÀ NẴNG";
            _lstSinhViens.Add(sv1);
            _lstSinhViens.Add(sv2);
            _lstSinhViens.Add(sv3);
            _lstSinhViens.Add(sv4);
            _lstSinhViens.Add(sv5);
        }

        static void timKiemSinhVien()
        {
            //Cách 1 cách cũ
            Console.WriteLine("Mời bạn nhập mã Sinh Viên muốn tìm: ");
            _input = Console.ReadLine();
            // for (int i = 0; i < _lstSinhViens.Count; i++)
            // {
            //     if (_input == _lstSinhViens[i].MaSv)
            //     {
            //         Console.WriteLine("ĐÃ TÌM THẤY SINH VIÊN: ");
            //         _lstSinhViens[i].inRaManHinh();
            //     }
            // }

            //Cách 2 rút gọn sử LINQ
            _lstSinhViens.Where(c => c.MaSv == _input).FirstOrDefault().inRaManHinh();
        }


        static void timKiemSinhVienKhongDiem()
        {
            double khoang1, khoang2;
            Console.WriteLine("Mời bạn nhập khoảng điểm 1: ");
            khoang1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập khoảng điểm 2: ");
            khoang2 = Convert.ToDouble(Console.ReadLine());

            //Cách 2 rút gọn sử LINQ
            foreach (var x in _lstSinhViens.Where(c => (c.DiemCsharp >= khoang1 && c.DiemCsharp <= khoang2) || (c.DiemCsharp >= khoang2 && c.DiemCsharp <= khoang1)))
            {
                x.inRaManHinh();
            }
        }

        static void sortSinhVien()
        {
            //Cách sử dụng List sort objects
            //_lstSinhViens.Sort((c1,c2)=>c1.Ten.CompareTo(c2.Ten));
            
            //Sử dụng LINQ để sắp xếp xuôi
            // Sử dụng LINQ để sắp xếp ngược _lstSinhViens.OrderByDescending
            var ListSVSapXep = _lstSinhViens.OrderBy(c => c.Ten).ToList();
            foreach (var x in ListSVSapXep)
            {
                x.inRaManHinh();
            }
        }
    }
}

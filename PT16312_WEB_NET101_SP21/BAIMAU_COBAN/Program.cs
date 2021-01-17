using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAIMAU_COBAN
{
    class Program
    {
        //Bài tập : Viết 1 chương trình cho phép người dùng đăng nhập vào được thông qua tài khoản và mật khẩu đúng. Tài khoản mật khẩu các bạn sẽ cho trước. Nếu đăng nhập thành công thì sẽ thực hiện cho phép người dùng nhập 1 số nằm trong 2 khoảng  từ 10 đến 20 hoặc 90 100. Nếu nhập đúng in ra thông báo nhập thành công và kết thúc chương trình. Nếu người dùng nhập không đúng trong 2 khoảng thì yêu cầu nhập lại.
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            const string user = "dungna29", pass = "1";
            string inputUser, inputPass,dungnaa;
            bool result, resultNumber;
            int inputNumber;
            Console.WriteLine("******Login POly******");
            do
            {
                Console.Write("User: ");
                inputUser = Console.ReadLine();
                Console.Write("Pass: ");
                inputPass = Console.ReadLine();
                result = (inputUser == user && inputPass == pass) ? true : false;
                if (!result)
                {
                    Console.WriteLine("Mời bạn đăng nhập lại sai rồi");
                } 
            } while (!result);

            do
            {
                Console.WriteLine("Mời bạn nhập số trong khoảng 10 - 20 || 90 - 100 :");
                inputNumber = Convert.ToInt32(Console.ReadLine());
                resultNumber = (inputNumber >= 10 && inputNumber <= 20) || (inputNumber >= 90 && inputNumber <= 100)
                    ? true
                    : false;
                if (!resultNumber)
                {
                    Console.WriteLine("Mời bạn nhập lại số đúng với yêu cầu sai rồi");
                }
            } while (!resultNumber);

            Console.WriteLine("Chương trình kết thúc");
            Console.ReadKey();

        }
    }
}

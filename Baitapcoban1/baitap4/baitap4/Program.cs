using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    class Program
    {
        static void Main(string[] args)
        {
            float a72, b72, c72;
            Console.Write("Nhap 3 so\n");
            Console.Write("Nhap so a: ");
            a72 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap so b: ");
            b72 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap so c: ");
            c72 = Convert.ToInt32(Console.ReadLine());
            if (a72 * a72 + b72 * b72 == c72 * c72 || b72 * b72 + c72 * c72 == a72 * a72 || c72 * c72 + a72 * a72 == b72 * b72)
                Console.Write("ba so dung la 3 canh cua 1 tam giac vuong");
            else
                Console.Write("ba so khong phai la 3 canh cua 1 tam giac vuong");
        }
    }
}

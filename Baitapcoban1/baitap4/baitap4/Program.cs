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
            float a, b, c;
            Console.Write("Nhap 3 so\n");
            Console.Write("Nhap so a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap so b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap so c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)
                Console.Write("ba so dung la 3 canh cua 1 tam giac vuong");
            else
                Console.Write("ba so khong phai la 3 canh cua 1 tam giac vuong");
        }
    }
}

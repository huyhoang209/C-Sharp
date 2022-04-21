using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.Write("Nhap 3 so\n\n");

            Console.Write("Nhap so a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap so b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap so c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && b + c > a && c + a > b)
                Console.Write("Ba so nay la 3 canh cua 1 tam giac");
            else
                Console.Write("\nBa so nay khong phai 3 canh cua 1 tam giac");
        }
    }
}

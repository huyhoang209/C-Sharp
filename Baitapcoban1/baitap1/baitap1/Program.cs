using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num72;
            Console.Write("\n\n");
            Console.Write("Nhap mot so nguyen bat ky: ");
            num72 = Convert.ToInt32(Console.ReadLine());
            if (num72 >= 0)

                Console.WriteLine("Đây là so nguyên dương.\n", num72);
            else
                Console.WriteLine("Đây là so nguyên âm. \n", num72);

            Console.ReadKey();
        }
    }
}

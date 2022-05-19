using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num72;
            Console.Write("Nhap mot so nguyen bat ky: ");
            num72 = Convert.ToInt32(Console.ReadLine());
            switch(num72)
            {
                case 1: Console.WriteLine("Mot\n", num72); break;
                case 2: Console.WriteLine("Hai\n", num72); break;
                case 3: Console.WriteLine("Ba\n", num72); break;
                case 4: Console.WriteLine("Bon\n", num72); break;
                case 5: Console.WriteLine("Nam\n", num72); break;
                case 6: Console.WriteLine("Sau\n", num72); break;
                case 7: Console.WriteLine("Bay\n", num72); break;
                case 8: Console.WriteLine("Tam\n", num72); break;
                case 9: Console.WriteLine("Chin\n", num72); break;

            }
        }
    }
}

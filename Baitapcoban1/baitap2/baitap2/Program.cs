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
            int num;
            Console.Write("Nhap mot so nguyen bat ky: ");
            num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1: Console.WriteLine("Mot\n", num); break;
                case 2: Console.WriteLine("Hai\n", num); break;
                case 3: Console.WriteLine("Ba\n", num); break;
                case 4: Console.WriteLine("Bon\n", num); break;
                case 5: Console.WriteLine("Nam\n", num); break;
                case 6: Console.WriteLine("Sau\n", num); break;
                case 7: Console.WriteLine("Bay\n", num); break;
                case 8: Console.WriteLine("Tam\n", num); break;
                case 9: Console.WriteLine("Chin\n", num); break;

            }
        }
    }
}

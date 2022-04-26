using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diemdanh26_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a,b,c: ");
            double a272 = Int32.Parse(Console.ReadLine());
            double b272 = Int32.Parse(Console.ReadLine());
            double c272 = Int32.Parse(Console.ReadLine());
            ptb2 pt = new ptb2(a272, b272, c272);

            double delta = pt.delta(a272, b272, c272);
            int check272 = pt.nghiem(delta);
            if (check272 < 0)
            {
                Console.WriteLine("Pt vo nghiem");
            }
            else if (check272 == 0)
            {
                double x = -b272 / (2 * a272);
                Console.WriteLine("pt co nghiem kep: ", x);
            }
            else
            {
                double x1 = (-b272 - Math.Sqrt(delta)) / (2 * a272);
                double x2 = (-b272 + Math.Sqrt(delta)) / (2 * a272);

                Console.WriteLine("Pt co 2 nghiem x1={0} , x2={1}: ", x1, x2);
            }
            Console.ReadKey();
        }
    }

    class ptb2
    {
        private double a272;
        private double b272;
        private double c272;

        public ptb2()
        {
        }

        public ptb2(double a272, double b272, double c272)
        {
            A = a272;
            B = b272;
            C = c272;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double delta(double a272, double b272, double c272)
        {
            return b272 * b272 - 4 * a272 * c272;
        }

        public int nghiem(double delta272)
        {
            if (delta272 < 0)
            {
                return -1;
            }
            else if (delta272 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baikiemtra1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bai 1: Tinh tong hieu tich thuong");
            Console.WriteLine("Bai 2: In ra la co VietNam bang dau = va *");
            Console.WriteLine("Bai 3: Đổi số thập phân thành số nhị phân từ một số thập phân");
            Console.WriteLine("Bai 4: In ra các thông tin của bản thân (họ tên, lớp, mã sv)");

            double n72 = double.Parse(Console.ReadLine());
            switch (n72)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Bai 1:\n ");
                    tinh();

                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Bai 2:\n");
                    laco();
                    break;
                case 3:

                    Console.Clear();
                    Console.Write("Bai 3:\n");
                    doiso();
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Bai 4: \n");
                    profile();
                    break;
            }
            Console.ReadKey();
    }
        static void tinh()
        {
            Console.WriteLine("nhap a:");
            int a72 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap b:");
            int b72 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nKet Qua la:\n");
            Console.WriteLine("a + b = " + (a72 + b72));
            Console.WriteLine("a - b = " + (a72 - b72));
            Console.WriteLine("a * b = " + (a72 * b72));
            Console.WriteLine("a / b = " + (a72 / b72));
            Console.WriteLine("a % b = " + (a72 % b72));
        }
        static void laco()
        {
            int Vertical = 20;
            int Horizontal = 50;
            char drawChar = '*';
            char insideChar = ' ';
            int countLoopVertical = 0;
            int countLoopHorizontal = 0;

            while (countLoopVertical < Vertical)
            {

                countLoopHorizontal = 0;

                while (countLoopHorizontal < Horizontal)
                {

                    if (countLoopVertical % (Vertical - 1) == 0 || ((countLoopVertical % (Vertical - 1) != 0) && (countLoopHorizontal % (Horizontal - 1) == 0)))
                    {
                        Console.Write(drawChar);    
                    }
                    else
                    {
                        Console.Write(insideChar); 
                    }             
                    countLoopHorizontal++;
                }

                Console.WriteLine();
                countLoopVertical++;
            }
            Console.ReadKey();
        }
 
        static void doiso()
        {
            Console.Write("nhap so: ");
            int number72 = int.Parse(Console.ReadLine());         
            string Result72 = string.Empty;
            for (int i = 0; number72 > 0; i++)
            {               
                Result72 = number72 % 2 + Result72;
                number72 = number72 / 2;
            }
            Console.WriteLine($"ket qua: {Result72}");     
            Console.ReadKey();
        }
        static void profile()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Họ Tên: Đinh Huy Hoàng\n");
            Console.WriteLine("Lớp: 19T2\n");
            Console.WriteLine("Mã Sinh Viên: 1911505310272\n");
        }
    }
    }
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTdiemdanh10_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr272 = new int[100];
            int n272;
            n272 = 10;
            Console.Write("Nhap {0} phan tu vao trong mang:\n", n272);
            for (int i = 0; i < n272; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr272[i] = Convert.ToInt32(Console.ReadLine());
            }
            minMax(arr272);
            Console.WriteLine("Mảng sắp xếp tăng dần");
            mangTang(arr272);
            Console.ReadKey();
        }
        static void minMax(int[] arr272)
        {
            int max272, min272;


            max272 = arr272[0];
            min272 = arr272[0];

            for (int i = 1; i < 10; i++)
            {
                if (arr272[i] > max272)
                {
                    max272 = arr272[i];
                }


                if (arr272[i] < min272)
                {
                    min272 = arr272[i];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", max272);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", min272);
        }
        static void mangTang(int[] arr272)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (arr272[i] > arr272[j])
                    {
                        int temp272 = arr272[i];
                        arr272[i] = arr272[j];
                        arr272[j] = temp272;
                    }
                }

            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr272[i] + " ");
            }
        }
    }
}
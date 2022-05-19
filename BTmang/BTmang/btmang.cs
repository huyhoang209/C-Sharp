using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTmang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Bài tập mảng\n");
        come:
            Console.Write("----------------------\n");
            Console.WriteLine("1: Bai58 Thuật  toán  sàng  Erastosthenes");
            Console.WriteLine("2: Bai59 Xuất năm Dương lịch kế tiếp có cùngtên năm Âm lịch");        
            Console.WriteLine("3: Bai61 Tính tổng các số nguyên dương có trong mảng");
            Console.WriteLine("4: Bai62 Kiểm tra xem tổng các số chẵn ở vị trí lẻ có bằng tổng các số lẻ ở vị trí chẵn hay không? ");
            Console.WriteLine("5: Bai63 Đếm số phần tử chia hết cho 4");
            Console.Write("----------------------\n");
            Console.Write("Chọn bài: \n");
            double n272 = double.Parse(Console.ReadLine());
            switch (n272)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Bai 58: Thuật  toán  sàng  Erastosthenes\n");
                    Eratosthenes();
                    goto come;
                    break;

                case 2:
                    Console.Clear();
                    Console.Write("Bai 59: Xuất năm Dương lịch kế tiếp có cùngtên năm Âm lịch \n ");
                    Calendar();
                    goto come;
                    break;

                case 3:
                    Console.Clear();
                    Console.Write("Bai 61: Tính tổng các số nguyên dương có trong mảng\n");
                    ArrayValues61();
                    goto come;
                    break;

                case 4:
                    Console.Clear();
                    Console.Write("Bai 62: Kiểm tra xem tổng các số chẵn ở vị trí lẻ có bằng tổng các số lẻ ở vị trí chẵn hay không? \n");
                    ArrayValues62();
                    goto come;
                    break;
                case 5:
                    Console.Clear();
                    Console.Write("Bai 63:Đếm số phần tử chia hết cho 4 \n");
                    ArrayValues63();
                    goto come;
                    break;

            }
            Console.ReadKey();

        }
        static void Eratosthenes()
        {
            int N = 100, n72;
            Boolean[] check = new Boolean[N + 1];
            Console.WriteLine("nhập n: ");
            n72 = int.Parse(Console.ReadLine());

            // Khởi tạo tất cả các số [2...N] đều là số nguyên tố
            for (int i = 2; i <= N; i++)
            {
                check[i] = true;
            }

            // Thuật toán sàng nguyên tố
            // Nếu một số là số nguyên tố, thì tất cả các bội của nó không phải số nguyên tố
            for (int i = 2; i <= N; i++)
            {
                if (check[i] == true)
                {
                    for (int j = 2 * i; j <= N; j += i)
                    {
                        check[j] = false;
                    }
                }
            }
            // In ra các số là số nguyên tố
            for (int i = 2; i <= N; i++)
            {
                if (check[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
        static void Calendar()
        {
            int year72;
            string[] can72 = new string[] { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            string[] chi72 = new string[] { "Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };

            Console.WriteLine("nhap nam: ");
            year72 = int.Parse(Console.ReadLine());

            Console.WriteLine("Năm " + year72.ToString() + " là năm " + can72[year72 % 10] + " " + chi72[year72 % 12]);
            Console.ReadLine();
        }
       
        static void ArrayValues61()
        {
            var rand72 = new Random();
            int n, s = 0;
            Console.Write("Nhập số phần tử của mảng: ");
            int[] a = new int[201];
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = rand72.Next(-100, 100);
                Console.Write("{0,15:N0}", a[i]);
                if (a[i] > 0)
                {
                    s += a[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine(" Tổng các số nguyên dương trong mảng là: " + s);
            Console.WriteLine();
        }
        static void ArrayValues62()
        {
            var rand72 = new Random();
            int n, sc = 0, sl = 0;
            string diff;
            Console.Write("Nhập số phần tử của mảng: ");
            int[] a = new int[201];
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = rand72.Next(10, 20);
                Console.Write("{0,15:N0}", a[i]);
                if (i % 2 == 0)
                {
                    sc += a[i];
                }
                else
                {
                    sl += a[i];
                }

            }
            if (sc == sl)
                diff = "giống";
            else
                diff = "khác";
            Console.WriteLine();
            Console.WriteLine("Tong vi tri chan ({0}) {2} tong chan vi tri le ({1})", sc, sl, diff);
        }
        static void ArrayValues63()
        {
            var rand72 = new Random();
            int n, divisible = 0;
            Console.Write("Nhập số phần tử của mảng: ");
            int[] a = new int[201];
            int[] b = new int[201];
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = rand72.Next(-100, 100);
                Console.Write("{0,15:N0}", a[i]);
                if (a[i] % 4 == 0 && a[i] % 10 == 6)
                {
                    divisible += 1;
                }
                b[i] = a[i];
                if (b[i] % 2 == 1 || b[i] % 2 == -1)
                {
                    b[i] *= 2;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Có {0} chia hết cho 4, có tận cùng là 6", divisible);
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");
            }
        }
    }
}

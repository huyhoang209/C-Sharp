using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTSTRUCT_ENUM_FOREACH
{
    class Program
    {
       public struct sinhvien
        {
            public string maso272;
            public string hoten272;
            public double diemtoan272;
            public gioitinh gioitinh272;
            public double diemly272;
            public double diemhoa272;
        }
        public enum gioitinh
        {
            Nam,
            Nu
        };
        public enum hocluc
        {
            Yeu,
            TrungBinh,
            Kha,
            Gioi
        };
        public static void nhapDS(ref sinhvien[] sv, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu " + (i + 1));
                Console.Write("Ho ten: ");
                string ht272 = Console.ReadLine();
                Console.Write("Ma sinh vien: ");
                string msv272 = Console.ReadLine();
                Console.Write("Gioi tinh (0: nam  1: nu): ");
                int gt272 = int.Parse(Console.ReadLine());
                Console.Write("Diem toan: ");
                double dt272 = double.Parse(Console.ReadLine());
                Console.Write("Diem ly: ");
                double dl272 = double.Parse(Console.ReadLine());
                Console.Write("Diem hoa: ");
                double dh272 = double.Parse(Console.ReadLine());


                sv[i].hoten272 = ht272;
                sv[i].maso272 = msv272;
                if (gt272 == 0)
                    sv[i].gioitinh272 = gioitinh.Nam;
                else
                    sv[i].gioitinh272 = gioitinh.Nu;
                sv[i].diemtoan272 = dt272;
                sv[i].diemly272 = dl272;
                sv[i].diemhoa272 = dh272;

            }
        }
        public static void xuatDS(sinhvien[] sv, int n)
        {
            int i = 1;
            foreach (sinhvien item272 in sv)
            {
                Console.WriteLine("----- " + i + " -----");
                Console.WriteLine("Ho ten: " + item272.hoten272);
                Console.WriteLine("Ma sinh vien: " + item272.maso272);
                int gt = (int)item272.gioitinh272;
                if (gt == 0)
                    Console.WriteLine("Gioi tinh: Nam");
                else
                    Console.WriteLine("Gioi tinh: Nữ");
                Console.WriteLine("Diem toan: " + item272.diemtoan272);
                Console.WriteLine("Diem ly: " + item272.diemly272);
                Console.WriteLine("Diem hoa: " + item272.diemhoa272);
                int hocluc = (int)diemTB(item272.diemtoan272, item272.diemly272, item272.diemhoa272);
                switch (hocluc)
                {
                    case 0:
                        Console.WriteLine("Hoc luc: Yeu");
                        break;
                    case 1:
                        Console.WriteLine("Hoc luc: Trung Binh");
                        break;
                    case 2:
                        Console.WriteLine("Hoc luc: Kha");
                        break;
                    case 3:
                        Console.WriteLine("Hoc luc:Gioi");
                        break;

                }

                i++;
            }
        }
        public static hocluc diemTB(double toan, double ly, double hoa)
        {
            double dtb = (toan + ly + hoa) / 3;
            if (dtb <= 4)
                return hocluc.Yeu;
            else if (dtb <= 5)
                return hocluc.TrungBinh;
            else if (dtb <= 7)
                return hocluc.Kha;
            else
                return hocluc.Gioi;
        }
        public static void timKiem(sinhvien[] sv, int n, string ht)
        {
            foreach (sinhvien item117 in sv)
            {
                if (item117.hoten272 == ht)
                {
                    Console.WriteLine("Ho ten: " + item117.hoten272);
                    Console.WriteLine("Ma sinh vien: " + item117.maso272);
                    int gt = (int)item117.gioitinh272;
                    if (gt == 0)
                        Console.WriteLine("Gioi tinh: Nam");
                    else
                        Console.WriteLine("Gioi tinh: Nữ");
                    Console.WriteLine("Diem toan: " + item117.diemtoan272);
                    Console.WriteLine("Diem ly: " + item117.diemly272);
                    Console.WriteLine("Diem hoa: " + item117.diemhoa272);
                    int hocluc = (int)diemTB(item117.diemtoan272, item117.diemly272, item117.diemhoa272);
                    switch (hocluc)
                    {
                        case 0:
                            Console.WriteLine("Hoc luc: Yeu");
                            break;
                        case 1:
                            Console.WriteLine("Hoc luc: Trung Binh");
                            break;
                        case 2:
                            Console.WriteLine("Hoc luc: Kha");
                            break;
                        case 3:
                            Console.WriteLine("Hoc luc:Gioi");
                            break;

                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien: ");
            int n272 = int.Parse(Console.ReadLine());
            sinhvien[] sv272 = new sinhvien[n272];
            nhapDS(ref sv272, n272);
            Console.WriteLine("\n\n==========DANH SACH SINH VIEN==========");
            xuatDS(sv272, n272);

            Console.WriteLine("\n==========TIM KIEM SINH VIEN==========");
            Console.Write("Nhap ten sinh vien: ");
            string ht272 = Console.ReadLine();
            timKiem(sv272, n272, ht272);

            Console.ReadLine();
        }
    }
}

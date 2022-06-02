using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLhodan
{
    /*Nguoi*/
    class Nguoi
    {
        private string hoten272;
        private int tuoi272;
        private string nghenghiep272;
        private int cmnd272;

        public Nguoi()
        {
        }

        public Nguoi(string hoten272, int tuoi272, string nghenghiep272, int cmnd272)
        {
            this.Hoten272 = hoten272;
            this.Tuoi272 = tuoi272;
            this.Nghenghiep272 = nghenghiep272;
            this.Cmnd272 = cmnd272;
        }

        public string Hoten272 { get => hoten272; set => hoten272 = value; }
        public int Tuoi272 { get => tuoi272; set => tuoi272 = value; }
        public string Nghenghiep272 { get => nghenghiep272; set => nghenghiep272 = value; }
        public int Cmnd272 { get => cmnd272; set => cmnd272 = value; }

        public virtual void InputNguoi()
        {
            Console.WriteLine("Nhap Ho va Ten : ");
            hoten272 = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            tuoi272 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nghe nghiep:  ");
            nghenghiep272 = Console.ReadLine();
            Console.WriteLine("Nhap so cmnd: ");
            cmnd272 = Int32.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Ho va Ten: {0} , Ngay sinh : {1} , Nghe nghiep: {2} , CMND: {3}", hoten272, tuoi272, nghenghiep272, cmnd272);
        }
    }
    /*HoDan*/
    class HoDan : Nguoi
    {
        private int sotv272;
        private int sonha272;
        private Nguoi[] thanhvien272 = new Nguoi[10];

        public int Sotv272 { get => sotv272; set => sotv272 = value; }
        public int Sonha272 { get => sonha272; set => sonha272 = value; }
        internal Nguoi[] Thanhvien272 { get => thanhvien272; set => thanhvien272 = value; }

        public HoDan()
        {

        }

        public HoDan(int sotv272, int sonha272, Nguoi[] thanhvien272)
        {
            this.sotv272 = sotv272;
            this.sonha272 = sonha272;
            this.thanhvien272 = thanhvien272;
        }

        public void InputHoDan()
        {
            Console.WriteLine("Nhap so thanh vien: ");
            sotv272 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nha: ");
            sonha272 = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= Sotv272; i++)
            {
                Console.WriteLine("Nhap so thanh vien thu " + i);
                thanhvien272[i] = new Nguoi();
                thanhvien272[i].InputNguoi();
            }
        }
        public void Display()
        {
            Console.WriteLine("So thanh vien: {0}, So nha: {1}", Sotv272, sonha272);
            for (int i = 1; i <= sotv272; i++)
            {
                Console.WriteLine("Thanh vien thu " + i);
                thanhvien272[i].Display();
            }
        }
    }
    /*KhuPho*/
    class KhuPho
    {
        private HoDan[] dshodan272 = new HoDan[10];
        private int sohodan272;

        public void InputKhuPho()
        {
            Console.WriteLine("Nhap so ho dan: ");
            sohodan272 = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= sohodan272; i++)
            {
                Console.WriteLine("Nhap so ho dan thu " + i);
                dshodan272[i] = new HoDan();
                dshodan272[i].InputHoDan();
            }
            Console.WriteLine("Thong tin tat ca ho dan: ");
            for (int i = 1; i <= sohodan272; i++)
            {
                Console.WriteLine("Ho dan thu " + i);
                dshodan272[i].Display();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KhuPho ql = new KhuPho();
            ql.InputKhuPho();
            Console.ReadKey();
        }
    }
}
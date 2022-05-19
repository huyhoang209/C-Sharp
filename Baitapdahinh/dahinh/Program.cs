using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dahinh
{
    class DaGiac
    {
        int soCanh;

        public DaGiac(int soCanh)
        {
            SoCanh72 = soCanh;
        }

        public int SoCanh72 { get => soCanh; set => soCanh = value; }

        virtual public void Xuat()
        {
            Console.WriteLine("Day la da giac.");
        }
    }
    class HinhVuong : DaGiac
    {
        public HinhVuong(int soCanh) : base(soCanh)
        {
            SoCanh72 = soCanh;
        }

        override public void Xuat()
        {
            Console.WriteLine("Co 4 canh bang nhau va 1 goc vuong.");
        }
    }
    class TamGiac : DaGiac
    {
        public TamGiac(int soCanh) : base(soCanh)
        {
            SoCanh72 = soCanh;
        }

        override public void Xuat()
        {
            Console.WriteLine("Co 3 canh va tong 2 canh bat ki lon hon canh con lai.");
        }
    }
    class HinhChuNhat : DaGiac
    {
        public HinhChuNhat(int soCanh) : base(soCanh)
        {
            SoCanh72 = soCanh;
        }

        override public void Xuat()
        {
            Console.WriteLine("Co 2 cap canh bang nhau va 1 goc vuong.");
        }
    }
    class HinhTuGiac : DaGiac
    {
        public HinhTuGiac(int soCanh) : base(soCanh)
        {
            SoCanh72 = soCanh;
        }

        override public void Xuat()
        {
            Console.WriteLine("Co 4 canh.");
        }
    }
    class HinhBinhHanh : DaGiac
    {
        public HinhBinhHanh(int soCanh) : base(soCanh)
        {
            SoCanh72 = soCanh;
        }

        override public void Xuat()
        {
            Console.WriteLine("Co 2 cap canh doi song song bang nhau, 2 goc doi bang nhau va 2 duong cheo cat nhau tai trung diem cua hinh.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Tam giac");
            Console.WriteLine("2. Tu giac");
            Console.WriteLine("3. Hinh binh hanh");
            Console.WriteLine("4. Hinh chu nhat");
            Console.WriteLine("5. Hinh vuong");
            Console.Write("Chon: ");
            int hinh = int.Parse(Console.ReadLine());

            if (hinh == 1)
            {
                DaGiac tg = new TamGiac(3);
                tg.Xuat();
            }
            else if (hinh == 2)
            {
                DaGiac tg = new HinhTuGiac(4);
                tg.Xuat();
            }
            else if (hinh == 3)
            {
                DaGiac tg = new HinhBinhHanh(4);
                tg.Xuat();
            }
            else if (hinh == 4)
            {
                DaGiac tg = new HinhChuNhat(4);
                tg.Xuat();
            }
            else if (hinh == 5)
            {
                DaGiac tg = new HinhVuong(4);
                tg.Xuat();
            }
            else
            {
                Console.WriteLine("Lua chon khong hop le!");
            }

            Console.ReadLine();
        }
    }
}

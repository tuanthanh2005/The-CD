using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1_QuanLyCD
{
    class CD
    {
        private int maCD;
        private string tuaCD;
        private string casi;
        private int soBaiHat;
        private int giaThanh;



        public CD()
        {

        }
        public CD(int maCD, string tuaCD,string casi, int soBaiHat, int giaThanh)
        {
            this.maCD = maCD;
            this.tuaCD = tuaCD;
            this.casi = casi;
            this.soBaiHat = soBaiHat;
            this.giaThanh = giaThanh;
        }
        public int MaCD
        {
            set { this.maCD = value; }
            get { return maCD; }
        } 
        public string TuaCD
        {
            set { this.tuaCD = value; }
            get { return tuaCD; }
        }public string CaSi
        {
            set { this.casi = value; }
            get { return casi; }
        }public int SoBaiHat
        {
            set { this.soBaiHat = value; }
            get { return soBaiHat; }
        }public int GiaThanh
        {
            set { this.giaThanh = value; }
            get { return giaThanh; }
        }
        public override string ToString()
        {
            return $"{maCD}-{tuaCD}-{casi}-{soBaiHat}-{GiaThanh}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanlyCD quanly = new QuanlyCD();
            int chon = 0;
            do
            {
                Console.WriteLine("---------------------MeNu--------------------");
                Console.WriteLine("1 Them CD");
                Console.WriteLine("2 Tinh trung Binh Gia Thanh");
                Console.WriteLine("3 Sap Xep Giam Dan");
                Console.WriteLine("4 Sap Tang Dan ");
                Console.WriteLine("5 Xuat Thong Tin");
                Console.WriteLine("0 ket Thuc");
                Console.WriteLine("Lua Chon Chuc Nang");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:// xu ly them CD
                        CD cd = new CD();
                        Console.WriteLine("Nhap ma cd: ");
                        cd.MaCD = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap Tua Cd");
                        cd.TuaCD = Console.ReadLine();
                        Console.WriteLine("Nhap ca si");
                        cd.CaSi = Console.ReadLine();
                        Console.WriteLine("Nhap So Bai Hat");
                        cd.SoBaiHat = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap Gia Thanh");
                        cd.GiaThanh = int.Parse(Console.ReadLine());
                        quanly.Them(cd);


                        break;
                    case 2:
                        double kq = quanly.TinhTrungBinhDonGia();
                        Console.WriteLine("Gia Thanh La {0:#,##0.00}",kq);
                        break;
                    case 3:
                        quanly.SapXepGiamGiaThanh();
                        Console.WriteLine("Da Sap Giam Dan");
                        break;
                    case 4:
                        break;
                    case 5:
                        quanly.Xuat();
                        break;
                    case 0:
                        Console.ReadLine();
                        break;
                       

                }
            } while (chon != 0);
        }
    }
}

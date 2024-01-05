using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1_QuanLyCD
{
    class QuanlyCD
    {
        private CD[] ds;
        private int n;


        public QuanlyCD()
        {
            ds = new CD[100];
            n = 0;

        }
        public QuanlyCD(int sophantu)
        {
            ds = new CD[sophantu];
            n = 0;
        }
        public void Them(CD cd)
        {
            if (n >= ds.Length)
            {
                Console.WriteLine("Danh Sach  Da Day ");
            }
            else
            {
                if (!KiemTraCD(cd.MaCD))
                {
                    ds[n++] = cd;

                }
                else
                {
                    Console.WriteLine("Trung ma CD");
                }
            }
        }
        private bool KiemTraCD(int macd)
        {
            for (int i = 0;i < n;i++)
            {
                if (ds[i].MaCD==macd)
                {
                    return true;
                }
            
            }
            return false;
        }
        public double TinhTrungBinhDonGia()
        {
            int Sum = 0;
            for (int i = 0; i < n; i++)
            {
                Sum += ds[i].GiaThanh;
            }
            return (double)Sum / n;
        }
        public void Xuat()
        {
            Console.WriteLine("{0,10} {1,30} {2,30} {3,10} {4,15}","maCD","tuaCd","ca Si","So Bai Hat","Gia Thanh");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ds[i].ToString());
            }
        }
        public void SapXepGiamGiaThanh()
        {
            CD tam;
            for (int i = 0; i < n-1; i++)
            {
                for (int j=i+1 ; j < n; j++)
                {
                    if (ds[i].GiaThanh<ds[j].GiaThanh)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }

                }
            }  

          
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathModuleProject
{
    class temelkavramlar
    {

        public static int TekilToplamaYap(int toplama)
        {

            return toplama;

        }
        public static int TekilToplamaYap()
        {
            int toplama = 0;
            while (true)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi==0)
                {

                    break;
                }
                else
                {
                    toplama=sayi+toplama;
                }
                
            }
            return toplama;

        }
        public static int TekilToplamaYap(int toplama, int toplam2, int toplama3)
        {

            return toplama + toplam2+ toplama3;

        }
        public static int TekilToplamaYap(int toplama, int toplam2, int toplama3, int toplama4)
        {

            return toplama + toplam2 + toplama3 + toplama4;

        }
        public static int ToplamaYap(int toplama)
        {

            return toplama;

        }
        public static int ToplamaYap()
        {
            int toplama = 0;
            while (true)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                {

                    break;
                }
                else
                {
                    toplama = sayi + toplama;
                }


            }
            return toplama;

        }
        public static int CikarmaYap()
        {
            int cikarma = 0;
            while (true)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                {

                    break;
                }
                else
                {
                    cikarma = cikarma - sayi;
                }


            }
            return cikarma;

        }
        public static int Carpma()
        {
            int Carpma = 1;
            while (true)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                {

                    break;
                }
                else
                {
                    Carpma = sayi * Carpma;
                }


            }
            return Carpma;

        }

        public static int Bolme()
        {
            int Bolme = 1;
            while (true)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                {

                    break;
                }
                else
                {
                    Bolme = Sayi * Carpma;
                }


            }
            return Bolme;

        }
        public static int KareAl(int sayi)
        {
            return sayi * sayi;

        }
        public static double KareKokAl(double sayi)
        {
            long i, n = (long)sayi, t;
            double r = sayi;
            for (i = 0; i < n; i++)
            {
                r = (r + (sayi / r)) * 0.5;
                t = (long)r;
                if ((t * t) < t)
                    break;
            }
            return r;
        }


    }
}

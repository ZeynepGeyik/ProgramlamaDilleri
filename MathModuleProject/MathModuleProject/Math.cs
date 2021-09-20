using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathModuleProject
{
    class math
    {

        public static int MutlakDegerAl(int deger)
        {
            if (deger > 0)
            {
                return deger;

            }
            else
            {
               return -deger;
            }
        }

        public static float MutlakDegerAl(float deger)
        {
            if (deger > 0)
            {
                return deger;

            }
            else
            {
                return -deger;
            }
        }

        public static double MutlakDegerAl(double deger)
        {

            if (deger > 0)
            {
                return deger;

            }
            else
            {
                return -deger;
            }
        }

        public static double RasyonelSayıHesapla(int ust,int taban)
        {

            
                return ust / taban;
            
           
        }
        public static string RasyonelSayıHesapla(int ust, int taban,String Reel)
        {


            return ust + "/ " + taban;



        }
        public static string RasyonelSayıTopla(int ust, int taban,int ust2,int taban2)
        {
            int ortaktaban = taban - taban2;
            ust = ust * taban2;
            ust2 = ust2 * taban;
            
            return ust+ust2 + "/ " + ortaktaban;



        }
        public static string RasyonelSayıCikart(int ust, int taban, int ust2, int taban2)
        {
            int ortaktaban = taban - taban2;
            ust = ust * taban2;
            ust2 = ust2 * taban;

            return ust - ust2 + "/ " + ortaktaban;



        }
        public static void İkinciDerecedenEsitsizlik()
        {
            Console.Write("A Değerini Giriniz = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B Değerini Giriniz = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("C Değerini Giriniz = ");
            int c = Convert.ToInt32(Console.ReadLine());
            double d = (b * b) - (4 * a * c);
            if (d > 0)
            {
                
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("Denklemin İki Kökü Vardır = ");
                Console.WriteLine("x1 =" + x1);
                Console.WriteLine("x2 =" + x2);
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Denklemin Bir Kökü Vardır = ");
                Console.WriteLine("x =" + x);
            }
            else
            {
                Console.Write("Reel Kök yoktur.");
            }
            Console.ReadKey();
        }
        public static string BirinciDerecedenEsitsizlik(int ust, int taban, int ust2, int taban2)
        {
            int ortaktaban = taban - taban2;
            ust = ust * taban2;
            ust2 = ust2 * taban;

            return ust - ust2 + "/ " + ortaktaban;



        }
        public static string BasitEsitsizlikCozucu(int b, int c)
        {
            Console.WriteLine("Lütfen denklemin sol tarafını 0 a eşitleyiniz.");
   
            int yenideger = b / c;
            string cozum = b + "x" + c + "=0" +
                "x=" + yenideger;


            return "";

        }
        public static int Usbul(int taban ,int us )
        {
            for (int i = 0; i < us; i++)
            {
                taban = taban * taban;
            }
            return taban;
        }


    }
}

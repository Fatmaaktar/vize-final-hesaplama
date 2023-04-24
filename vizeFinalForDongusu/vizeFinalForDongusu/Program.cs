using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizeFinalSınıfMevcuduIcin
{
    class Program
    {
        static void Main(string[] args)
        {
            int sinifMevcudu;
            double vize, final, ort;
            string adSoyad;
            Console.Write("Sınıf mevcudu giriniz : ");
            sinifMevcudu = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=sinifMevcudu; i++)
            {
                Console.WriteLine("Ad soyad giriniz");
                adSoyad = Console.ReadLine();
                Console.WriteLine("Vize notunu giriniz : ");
                vize = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Final notunu giriniz : ");
                final = Convert.ToDouble(Console.ReadLine());
                ort = vize * 0.4 + final * 0.6;
                Console.WriteLine(ort);

                if (ort >= 60)
                {
                    Console.WriteLine(adSoyad + ": Geçti");
                }
                else
                {
                    Console.WriteLine(adSoyad + ": Kaldı");
                }
            }

            Console.ReadKey();
        }
    }
}

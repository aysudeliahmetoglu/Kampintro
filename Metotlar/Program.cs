using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "elma";
            double Fiyati = 15;
            string aciklamasi = "Amasya elması";

            string[] meyveler = new string[] { "elma", "karpuz" };
            Urun urun1 = new Urun ();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklamasi = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklamasi = "diyarbakır karpuzu";

            Urun[] ürünler = new Urun[] {urun1,urun2};
            //type-safe 
            foreach (var urun in ürünler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklamasi);
                Console.WriteLine("-------------------");
            }
            Console.WriteLine("---------------metotlar--------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);
            



        }
    }
    }

// metotlar tekrar tekrar kullanılmayı sağlayan kod metotları (do not repeat  yourself)-clean code best practice
using System;
// do not repeat yourself
namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            Console.WriteLine("kategori");
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            Console.WriteLine(kategoriEtiketi);
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
                
               
        }
    }
}

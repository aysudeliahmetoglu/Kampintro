using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "pyhton", "yazılım ggeliştirici", "java" };
            for (int i =0; i <kurslar.Length; i+=2)
            {
                Console.WriteLine(kurslar[i]);

            }
            // foreach dizileri tek tek dolaşmaya yarıyor
        }
    }
}

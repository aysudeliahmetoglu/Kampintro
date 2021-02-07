using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Kurs Kurs1 = new Kurs();
            Kurs1.KursAdi = "c#";
            Kurs1.KursunEgitmeni = "engin demirog";
            Kurs1.IzlenmeOrani = 68;

            Kurs Kurs2 = new Kurs();
            Kurs2.KursAdi = "java";
            Kurs2.KursunEgitmeni = "kerem";
            Kurs2.IzlenmeOrani = 60;

            Kurs Kurs3 = new Kurs();
            Kurs3.KursAdi = "phyton";
            Kurs3.KursunEgitmeni = "berkay";
            Kurs3.IzlenmeOrani = 80;


            
        }
       
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
Console.WriteLine(Kurs1.KursAdi + " : " + Kurs1.KursunEgitmeni);

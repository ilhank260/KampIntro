using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "ilhan";
            int yas = 20;
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "İlhan";
            kurs1.KursAdi = "Java";
            kurs1.IzlenmeOrani = 500;
            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Selim";
            kurs2.KursAdi = "Ptyhon";
            kurs2.IzlenmeOrani = 280;
            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Halil";
            kurs3.KursAdi = "Css";
            kurs3.IzlenmeOrani = 120;

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            

            Console.WriteLine("Hello World!");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}

using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kampı";
            string kurs2 = "Programlamaya Başlangıc Kursu";
            string kurs3 = "Java";
            string kurs4 = "Python";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            //Array - Diziler

            string[] Kurslar = new string[] { "Yazılım Geliştirme Kampı", "Programlamaya Başlangıc Kursu", "Java","Python"};

            Console.WriteLine("Hello World!");
            for (int i = 0; i <Kurslar.Length; i++) // Length Kursların Elemanı kadar döndür :)
            {
                Console.WriteLine(Kurslar[i]);
            }

            Console.WriteLine();
            foreach (string kurs in Kurslar) // Foreach Dizileri Tek tek dolaşmaya yarar
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}

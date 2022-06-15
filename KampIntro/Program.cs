using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type safety - tip güvenliği
            string kategoriEtiketi = "Kategori Etiketi";
            int OgrenciSayisi = 3200;
            double FaizOrani= 3.14;
            bool SistemeGirisYapmismi = false;
            double DolarDun = 7.35;
            double DolarBugun = 7.45;
            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(DolarDun<DolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (SistemeGirisYapmismi==true)
            {
                Console.WriteLine("Sisteme Giriş Yapıldı.");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Başarısız.");
            }

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine("Hello World!");
            
        }
    }
}

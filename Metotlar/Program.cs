using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 20;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Karpuz";
            urun2.Fiyati = 5;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new[] { urun1, urun2 };
            //Type-safe --Tip Güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürünün Adı : " + urun.UrunAdi);
                Console.WriteLine("Ürünün Fiyatı : "+ urun.Fiyati);
                Console.WriteLine("Ürünün Açıklaması :" + urun.Aciklama);
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("----------------Metotlar---------------------");
            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 15);
            sepetManager.Ekle2("Elma", "Kırmızı elma", 18);

        }
    }
}
// Dont repeat your self-DRY - Clean code -  Best Practice 
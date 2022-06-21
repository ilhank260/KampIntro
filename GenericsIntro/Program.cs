using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<String> isimler = new MyList<string>();
            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);
            isimler.Add("Selim");
            Console.WriteLine(isimler.Length);
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

            Console.WriteLine("Hello World!");
        }
    }
}

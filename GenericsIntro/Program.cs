﻿using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<String> isimler = new MyList<string>();
            isimler.Add("Engin");

            Console.WriteLine("Hello World!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor  new'lediğin anda çalışan bloğa denir. newlendiğinde 0 elemanlı items oluşur.
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items; //Geçiçi dizi. geçici dizinin referansı items ın referansı 
            items = new T[items.Length + 1]; // Eleman sayımı 1 arttırıyorum.
            for (int i = 0; i < tempArray.Length; i++) //TempArray e tutturduğumuz değerleri items'a ekle.
            {
                items[i] = tempArray[i];

            }
            items[items.Length - 1] = item; // items a gelen son elemanı ekle. 
        }
    }
}

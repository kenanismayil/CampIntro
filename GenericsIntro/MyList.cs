using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;      //Listeler arka planda bir array'i yonetir!
        //Constructor -> class'in ismiyle aynidir. Bu class'i new'ledigimizde bu blok otomatik olarak calisir!
        public MyList()
        {
            items = new T[0];   //0 elemanli array olusturduk.
        }
        public void Add(T item)
        {
            //Gecici diziye items'in referansini veririz.
            //Her yeni eleman eklendiginde referans adresi silinmesin diye bunu yapariz. Boylece onceki degerler korunur.
            T[] tempArray = items;      
            //Diziye eleman ekleyebiliriz.
            items = new T[items.Length + 1];  // Dizinin eleman sayisini bir arttiririz.(Her seferinde yeni eleman diziye eklemek icin)

            for (int i = 0; i < tempArray.Length; i++)
            {
                //items eski degerlerine kavusur.
                items[i] = tempArray[i];    
            }

            //Eklenmek istenen son eleman item'a esitlenir.
            items[items.Length - 1] = item;
        }
    }
}

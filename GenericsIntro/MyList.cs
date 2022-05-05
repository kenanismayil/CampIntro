using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>     //Generic Class
    {
        T[] _array;         //Listeler arka planda bir array'i yonetir!
        T[] _tempArray;     //Gecici bir dizi olusturulur.

        //Constructor -> class'in ismiyle aynidir. Bu class'i new'ledigimizde bu blok otomatik olarak calisir!
        public MyList()
        {
            _array = new T[0];   //0 elemanli bir array olusturduk.
        }
        public void Add(T item)
        {
            //Gecici diziye _array'in referansini veririz.
            //Her yeni eleman eklendiginde referans adresi silinmesin diye bunu yapariz. Boylece onceki degerler korunur.
            _tempArray = _array;      
            //Diziye eleman ekleyebiliriz.
            _array = new T[_array.Length + 1];    //Dizinin eleman sayisini bir arttiririz.(Her seferinde yeni eleman diziye eklemek icin)

            for (int i = 0; i < _tempArray.Length; i++)
            {
                //_array eski degerlerine kavusur.
                _array[i] = _tempArray[i];    
            }

            //Eklenmek istenen son eleman item'a esitlenir.
            _array[_array.Length - 1] = item;
        }

        //Count property'sini olusturarak _array'in son uzunluk bilgisi elde edilir.
        public int Count
        {
            get { return _array.Length; }
        }



    }
}

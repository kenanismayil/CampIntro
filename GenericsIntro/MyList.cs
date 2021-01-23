using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>                  //T verdigimiz tipe karslik gelir.Yani istedigim elemanin tipini belirleyebilirim
    {
        T[] items;                  //Bir class'in icinde metotun disinda bu diziyi tanimladim ki,bu diziye sinif icinde tanimladigim baska metotlar icerisinden de erisilebilsin.

        //Array referans bir tip oldugu icin her zaman new'lemem lazimdir.

        //Bir class'i new'ledigimde calisan bloga Constructor denir ve Constructor'lar sinifin ismiyle ayni olur.

        //Constructor                                       //Bir class new'lendiginde zaten constructor tanimlanir. 
        public MyList()
        {
            items = new T[0];                               //0 elemanli bir array olusturduk.Boylece bu diziye eleman ekleme yapabilirim.
        }
        public void Add(T item)                             //Burda T verdim ki bu metota gonderecegim veri tipi benim istedigim elemanin turu de o olsun.
        {
            T[] tempArray = items;                          //items dizisini gecici bir diziye aktardim ki alt satirda newledigimde'de bir onceki elemanlarim diziden silinmesin.
            items = new T[items.Length+1];                  //(items.length) dizimin eleman sayisini verir.Bu satirda dizimin eleman sayisini 1 arttirdim.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;       //Aslinda eklemek istedigim elemani suan ekledim.Dizimin son elemani su sekilde verilir.
            Console.WriteLine(item);
        }

        public int Length
        {
            get { return items.Length; }
        }

        //Isimleri soyle de yazdirabiliriz.

        public T[] Items
        {
            get { return items; }
        }
    }
}

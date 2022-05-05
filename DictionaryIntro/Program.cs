using System;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Kalem", 15);
            myDictionary.Add("Defter", 80);
            myDictionary.Add("Kitap", 150);
            myDictionary.Add("Silgi", 10);

            Console.WriteLine("Key = Value degerleri:");
            //Manuel olarak Key ve Value Degerleri:
            //Console.WriteLine(myDictionary.Keys[0] + " = " + myDictionary.Values[0]);
            //Console.WriteLine(myDictionary.Keys[1] + " = " + myDictionary.Values[1]);
            //Console.WriteLine(myDictionary.Keys[2] + " = " + myDictionary.Values[2]);
            //Console.WriteLine(myDictionary.Keys[3] + " = " + myDictionary.Values[3]);

            //Dongu yardimiyla Key ve Value Degerleri:
            for (int i = 0; i < myDictionary.Keys.Length; i++)
            {
                Console.WriteLine("{0} : {1}", myDictionary.Keys[i], myDictionary.Values[i]);
            }

            Console.WriteLine("------------------------------");

            Console.WriteLine("Key ve Value dizisinin uzunlugu:");
            Console.WriteLine("Key sayisi : " + myDictionary.Length1);
            Console.WriteLine("Value sayisi : " + myDictionary.Length2);




            Console.ReadKey();
        }
    }
}

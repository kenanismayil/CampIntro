using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {   //Generic yapilara bir ornek
            //List C#'da olmasa ben nasil yazardim? -> if list is not in C# how can I write list?
            //String tipinde bir liste yarattim.

            MyList<string> nouns = new MyList<string>();                           //String verdim fakat istedigim tipi verebiliyorum.
            nouns.Add("Kenan");
            Console.WriteLine(nouns.Length);

            nouns.Add("Kerem");
            Console.WriteLine(nouns.Length);
        
            Console.WriteLine("--------------");
        
            foreach (var item in nouns.Items)
            {
                Console.WriteLine(item);
            }

            //Listeler arka planda bir array olusturur.
            Console.ReadLine();
        }
    }
}

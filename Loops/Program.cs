using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Biz donguleri birbirini tekrar eden yapilar icin kullanilir.

            string course1 = "C";
            string course2 = "C#";
            string course3 = "Java";

            //array - dizi
            //Istedigim kadar kurslari ayni degisken icinde tutabilirim.
            //string array
            //Dinamik yapi boylece saglanir.
            string[] courses = new string[] {
                "C",
                "Haskell",
                "Java","Python",
                "C++",
                "C#" };

            Console.WriteLine("For Basladi");
            Console.WriteLine("----------------------------------------");

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("For Bitti");

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Foreach Basladi");
            Console.WriteLine("----------------------------------------");

            //Dizi temelli yapilari tek tek dolasarak donmeye yarar.
            //Kurslar icersinde tek tek dolasir
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Foreach Bitti");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\n");

            Console.WriteLine("Sayfa Sonu - footer");

            Console.ReadLine();
        }
    }
}

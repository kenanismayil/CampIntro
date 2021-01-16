using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kenan";
            int age = 21;

            Course course1 = new Course();             //Ilk kursu tanimlamak icin boyle yapilir.
            course1.CourseAdi = "C#";
            course1.Teacher = "Engin Demirog";
            course1.ViewRate = 70;

            Course course2 = new Course();             //Ikinci kursu tanimlamak icin boyle yapilir.
            course2.CourseAdi = "Java";
            course2.Teacher = "Kerem Varis";
            course2.ViewRate = 64;

            Course course3 = new Course();             //Ucuncu kursu tanimlamak icin boyle yapilir.
            course3.CourseAdi = "Python";
            course3.Teacher = "Berkay Bilgin";
            course3.ViewRate = 80;

            Course course4 = new Course();             //Ucuncu kursu tanimlamak icin boyle yapilir.
            course4.CourseAdi = "C++";
            course4.Teacher = "Murat Kurtbogan";
            course4.ViewRate = 90;

            //Manuel yapida gosterim:
            //Console.WriteLine(course1.CourseAdi + ":" + course1.Teacher);

            //Dinamik yapida gosterim:
            Course[] courses = new Course[] {
                course1,
                course2,
                course3,
                course4
            };

            foreach (var course in courses) 
                //course--takma isim,var yerine Course diyebiliriz.Yani Course sinifi veri tipindedir.
            {
                Console.WriteLine(course.CourseAdi + "  ->  " + course.Teacher + " : " + course.ViewRate);
            }

            Console.ReadLine();
        }
    }
    class Course
    {
        public string CourseAdi { get; set; }
        public string Teacher { get; set; }
        public int ViewRate { get; set; }

    }
}

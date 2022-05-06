using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Loglama operasyonu icin Iki farkli alternatif loglama sistemi kullandik. Ilki Database, Ikincisi ise File logger service'tir.
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanina Loglandi!");
        }
    }
}

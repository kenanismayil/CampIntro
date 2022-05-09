using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kredilerin orneklerini olusturma

            //Ekranda olan kullanilabilecek kredi ornekleri:
            ICreditManager personalCrediManager = new PersonalCrediManager();
            ICreditManager transportCrediManager = new TransportCrediManager();
            ICreditManager residenceCrediManager = new ResidenceCrediManager();
            ICreditManager smallBusninessCrediManager = new SmallBusinessCrediManager();

            

            //Loglayici ornekleri olusturmak:
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            //Basvuru yapilacak olan krediye basvuru yapilmasi
            ApplicationManager applicationManager = new ApplicationManager();

            List<ILoggerService> loggerServices = new List<ILoggerService>
            {
                databaseLoggerService,
                smsLoggerService
            };

            //applicationManager.MakeAnApplication(residenceCrediManager, smsLoggerService);        Tek bir loglayici servis yollar.
            //Listeli bir sekilde istedigimiz loglayici servisleri methoda yollayabiliriz.
            applicationManager.MakeAnApplication(transportCrediManager, loggerServices);
            applicationManager.MakeAnApplication(smallBusninessCrediManager, loggerServices);
            


            List<ICreditManager> credits = new List<ICreditManager>
            {
                personalCrediManager,
                transportCrediManager
            };

            //applicationManager.MakeCreditPreInformation(credits);





            Console.ReadKey();
        }
    }
}

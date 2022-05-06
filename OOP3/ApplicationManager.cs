using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Krediye basvurmak icin Basvuru Islemlerinin oldugu manager class'i olusturdum.
    class ApplicationManager
    {
        //Method Injection
        //Basvuru Manager'de asla hangi kredi turu, hangi loglayici olduguna dair bilgi yoktur!
        //Sadece soyut halleri var, somut hallerini enjekte ediyoruz!
        public void MakeAnApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)   //Parametre olarak istedigimiz krediyi yollayabiliriz.Cunki ICrediManager interface'dir.
        {
            //Basvuran bilgilerini degerlendirme
            //

            //Krediyi hesaplama kismi:
            //Kredi Bagimsiz hale getirme: Sadece gondermek istedigimiz krediyi hesaplar ve ekranda gosterir.
            //Loglari Bagimsiz hale 
            creditManager.Calculate();

            //loggerService.Log();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void MakeCreditPreInformation(List<ICreditManager> credits)
        {
            //Listedeki her bir kredinin hesabini yapar.
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}

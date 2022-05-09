using System;

namespace GameSaleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Validasyon servisi ornegi olusturuldu.
            IUserValidationService userValidationService = new UserValidationManager();

            //Gamer ornegi olusturuldu
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FirstName = "Kenan",
                LastName = "Ismayil",
                UserName = "kenanismayil",
                BirthYear = 2000,
                IdentityNumber = 21213,
                Balance = 213.23
            };

            //GameManager class ornegi olusturulurken kendi Costructor parametresinde istedigi icin parametreye Validasyon ornegi yazilir!
            //Parametrede dogrulama sinifinin kim oldugunu istiyor.
            //GameManager class'i Calisabilmesi icin dogrulama microservisine ihtiyac duyuyor!
            GameManager gameManager = new GameManager(userValidationService);
            gameManager.Add(gamer1);



            OrderManager orderManager = new OrderManager(new CampaignManager());
            orderManager.Sale(gamer1);


            Console.ReadKey();
        }
    }
}

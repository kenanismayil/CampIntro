using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gercek(invidual) - Tuzel(corporate) (Ikisi de Musteridir, ama birbirine benziyor diye birbirinin yerine kullanilamaz. Farkli musteri tipleridir!)
            //SOLID prensibleri -> L harfi bunu soyler. Birbirine benziyor diye iki objeyi birbirinin yerine kullanma. Inheritance kullan!

            //Invidual Client instances:
            InvidualClient client1 = new InvidualClient();
            client1.Id = 1;
            client1.ClientNo = "42424";
            client1.Name = "Kenan";
            client1.Surname = "Ismayil";
            client1.TcNo = "3424242";


            //Corporate Client instances:
            CorporateClient client2 = new CorporateClient();
            client2.Id = 2;
            client2.ClientNo = "232323";
            client2.CompanyName = "Kodlama";
            client2.TaxNo = "123313133";


            //Client instances:
            //Client class, hem Invidual Client'in referans no'sunu, hem de Corporate Client'in referans no'sunu tutuyor!
            Client client3 = new InvidualClient();
            Client client4 = new CorporateClient();


            ClientManager clientManager = new ClientManager();
            clientManager.Add(client1);
            clientManager.Add(client2);
            clientManager.Add(client3);



            Console.ReadKey();
        }
    }
}

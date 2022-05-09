using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject
{
    //MicroService ->GameManager class'in baska bir servisi kullanir!
    class GameManager : IGamerService
    {
        //IUserValidationService Constructoru olusturulur. Asagida GameManager icersinde bir dogrulama servisini kullandim.
        IUserValidationService _userValidationService;

        //Constructor
        public GameManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(" -> Dogrulama Basarili!");
                Console.WriteLine($"<{gamer.UserName}> isimli kullanici sisteme kayit oldu.");
            }
            else
            {
                Console.WriteLine(" -> Dogrulama Basarisiz!");
                Console.WriteLine($"<{gamer.UserName}> isimli kullanici sisteme kayit olamadi.");
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit Guncellendi!");
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit Silindi!");
        }       
    }
}

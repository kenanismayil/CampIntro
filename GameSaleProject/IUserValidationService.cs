using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject
{
    //Kullanici Bilgilerini Dogrulama ->Soyutlastirma yaptim.
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}

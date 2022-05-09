using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject
{
    //Somut Halini Yazdim.
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.IdentityNumber == 21213 && gamer.FirstName == "Kenan" 
                && gamer.LastName == "Ismayil" && gamer.BirthYear == 2000)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}

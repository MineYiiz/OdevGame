using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevGame.UserValidate
{
    public class MernisService : IUserValidationService
    {
       public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.IdentityNumber), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(),gamer.BirthYear.Year);
        }
    }
}

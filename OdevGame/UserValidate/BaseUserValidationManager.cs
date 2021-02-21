using System;
using System.Collections.Generic;
using System.Text;

namespace OdevGame.UserValidate
{
    public class BaseUserValidationManager : IGamerService
    {
        public virtual
            void Add(Gamer gamer)
        {
            Console.WriteLine("DB'ye Kaydedildi: "+ gamer.FirstName + " " + gamer.LastName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("DB'den Silindi: " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("DB'de Güncellendi: " + gamer.FirstName + " " + gamer.LastName);
        }

    }
}

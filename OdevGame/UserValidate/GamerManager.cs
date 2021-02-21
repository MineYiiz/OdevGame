using System;
using System.Collections.Generic;
using System.Text;

namespace OdevGame
{
    public class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kayıt Edildi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}

using OdevGame.Sales;
using OdevGame.UserValidate;
using System;

namespace OdevGame
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseUserValidationManager GamerManager = new BaseUserValidationManager();
            GamerManager.Add(new Gamer { BirthYear = new DateTime(1994, 10, 28), FirstName = "Mine", LastName = "Yiğiz", IdentityNumber = "32576407846", Id = 1 });
           

            BaseOrderManager orderManager = new BaseOrderManager();
            orderManager.ConfirmOrder(new Order { OrderId = 1,GameId=1,GameName="Avatar",Price=20, OrderDate = new DateTime(2021, 02, 20) });

            Console.ReadLine();
        }
    }
}

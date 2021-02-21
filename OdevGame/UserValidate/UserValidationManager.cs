using OdevGame.UserValidate;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdevGame
{
    public class UserValidationManager : BaseUserValidationManager
    {
        private IUserValidationService _userValidationService;
    public UserValidationManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public override void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Geçerli bir kişi değil!");
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;

namespace SciFramework.Controllers.User
{
    public partial class UserEndpoint
    {
        [HttpPost("login")]
        public ActionResult<string> Login(string email, string password)
        {
            string authKey;

            throw new NotImplementedException();

            return authKey;
        }

        [HttpPost("register")]
        public ActionResult<bool> Register(string email)
        {
            bool isEmailAlreadyRegistered;

            throw new NotImplementedException();

            return isEmailAlreadyRegistered;
        }

        [HttpPost("resetPassword")]
        public ActionResult<bool> ResetPassword(string email)
        {
            bool isEmailRegistered;

            throw new NotImplementedException();

            return isEmailRegistered;
        }

        [HttpPost("profileImage")]
        public ActionResult<bool> ProfileImage(string profileImage, string authKey)
        {
            bool isSuccesed;

            throw new NotImplementedException();

            return isSuccesed;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SciFramework.Interfaces.User;
using System;

namespace SciFramework.Controllers.User
{
    public partial class UserEndpoint
    {
        [HttpGet("{uid}")]
        public ActionResult<IUser> GetUserByUID(string uid)
        {
            throw new NotImplementedException();
        }
    }
}

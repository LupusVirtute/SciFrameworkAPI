using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SciFramework.Models.User;

namespace SciFramework.Controllers.User
{
    [ApiController]
    [Route("api/User")]
    public partial class UserEndpoint : ControllerBase
    {
        protected virtual List<Models.User.User> loadUsers()
        {
            throw new NotImplementedException();
        }

        protected virtual Models.User.User loadUser(string uid)
        {
            throw new NotImplementedException();
        }


        protected virtual long insertUsers(Models.User.User user)
        {
            throw new NotImplementedException();
        }

        protected virtual bool updateUsers(Models.User.User user)
        {
            throw new NotImplementedException();
        }

        protected virtual bool deleteUsers(Models.User.User user)
        {
            throw new NotImplementedException();
        }

    }
}

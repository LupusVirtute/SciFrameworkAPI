using SciFramework.Controllers.User;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using UnitTests.DataBaseDemo;
using Dapper.Contrib.Extensions;
using Xunit;

namespace UnitTests.Controllers.User
{
    public partial class UserEndpointTests
    {
        public class TestUserEndpoint : UserEndpoint
        {
            protected override List<SciFramework.Models.User.User> loadUsers()
            {
                using (IDbConnection connection = DBConnector.DbConnection)
                {
                    var output = connection.GetAll<SciFramework.Models.User.User>();
                    return output.ToList();
                }
            }

            protected override SciFramework.Models.User.User loadUser(string uid)
            {
                using (IDbConnection connection = DBConnector.DbConnection)
                {
                    var output = connection.Get<SciFramework.Models.User.User.Model>(uid);
                    return output.ToUser();
                }
            }
            protected override long insertUsers(SciFramework.Models.User.User user)
            {
                using (IDbConnection connection = DBConnector.DbConnection)
                {
                    return connection.Insert(user);
                }
            }

            protected override bool updateUsers(SciFramework.Models.User.User user)
            {
                using (IDbConnection connection = DBConnector.DbConnection)
                {
                    return connection.Update(user);
                }
            }

            protected override bool deleteUsers(SciFramework.Models.User.User user)
            {
                using (IDbConnection connection = DBConnector.DbConnection)
                {
                    return connection.Delete(user);
                }
            }

            [Fact]
            public void testGetUserFromTestUserEndpoint()
            {
                var endpoint = new TestUserEndpoint();
                
                var user = endpoint.loadUser("0f8fad5b-d9cb-469f-a165-70867728950e");

                Assert.NotNull(user);
                Assert.Equal("0f8fad5b-d9cb-469f-a165-70867728950e", user.UID);
                Assert.Equal("Tester", user.NickName);
                Assert.Equal("None", user.B64Image);
            }
        }
    }
}

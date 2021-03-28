using System;
using SciFramework.Interfaces.User;
using Xunit;

namespace UnitTests.Controllers.User
{
    public partial class UserEndpointTests
    {
        // /{id}
        [Theory]
        [InlineData("", "")]
        public void testGetUesrIfDataAreCorrect(string uid, string nickname)
        {
            IUser user = userEndpoint.GetUserByUID(uid).Value;

            throw new NotImplementedException();

            Assert.Equal(uid, user.UID);
            Assert.Equal(nickname, user.NickName);
        }

        [Theory]
        [InlineData("", "")]
        public void testFailGetUesrIfDataAreIncorrect(string uid, string nickname)
        {
            IUser user = userEndpoint.GetUserByUID(uid).Value;

            throw new NotImplementedException();

            Assert.NotEqual(uid, user.UID);
            Assert.NotEqual(nickname, user.NickName);
        }
    }
}

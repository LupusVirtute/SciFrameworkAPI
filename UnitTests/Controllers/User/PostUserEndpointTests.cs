using System;
using Xunit;

namespace UnitTests.Controllers.User
{
    public partial class UserEndpointTests
    {
        // /register
        [Theory]
        [InlineData("test@test.net", "@123Password")]
        public void testRegisterUesrForCorrectData(string email, string password)
        {
            bool isSuccess = userEndpoint.Register(email, password).Value;

            throw new NotImplementedException();

            Assert.True(isSuccess);
        }

        [Theory]
        [InlineData("someString", "@123Password")]
        public void testFailRegisterUesrForIncorrectEmail(string email, string password)
        {
            bool isSuccess = userEndpoint.Register(email, password).Value;

            throw new NotImplementedException();

            Assert.False(isSuccess);
        }

        [Theory]
        [InlineData("new01@test.net", "pass")]
        public void testFailRegisterUesrForIncorrectPassword(string email, string password)
        {
            bool isSuccess = userEndpoint.Register(email, password).Value;

            throw new NotImplementedException();

            Assert.False(isSuccess);
        }

        [Theory]
        [InlineData("someString", "pass")]
        public void testFailRegisterIfEmailAlreadyRegistered(string email, string password)
        {
            bool isSuccess = userEndpoint.Register(email, password).Value;

            throw new NotImplementedException();

            Assert.False(isSuccess);
        }

        // /resetPassword
        [Theory]
        [InlineData("new02@test.net")]
        public void testResetPasswordIfEmailIsCorrect(string email)
        {
            bool isSuccess = userEndpoint.ResetPassword(email).Value;
            
            throw new NotImplementedException();

            Assert.True(isSuccess);
        }
        [Theory]
        [InlineData("exist@test.net")]
        public void testFailResetPasswordIfEmailIsNotExist(string email)
        {
            bool isSuccess = userEndpoint.ResetPassword(email).Value;

            throw new NotImplementedException();

            Assert.False(isSuccess);
        }

        [Theory]
        [InlineData("someString")]
        public void testFailResetPasswordIfEmailIsNotCorrect(string email)
        {
            bool isSuccess = userEndpoint.ResetPassword(email).Value;

            throw new NotImplementedException();

            Assert.False(isSuccess);
        }

        // /login
        [Theory]
        [InlineData("", "")]
        public void testLoginWidthCorrectData(string email, string password)
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData("", "")]
        public void testFailLoginWidthIncorrectEmail(string email, string password)
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData("", "")]
        public void testFailLoginWidthIncorrectPassword(string email, string password)
        {
            throw new NotImplementedException();
        }

        // /profileImage
        [Theory]
        [InlineData("", "")]
        public void testSetProfileImageWidthCorrectData(string base64, string authKey)
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData("", "")]
        public void testFailSetProfileImageWidthIncrrectData(string base64, string authKey)
        {
            throw new NotImplementedException();
        }
    }
}

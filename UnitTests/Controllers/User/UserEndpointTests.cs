using SciFramework.Controllers.User;

namespace UnitTests.Controllers.User
{
    public partial class UserEndpointTests
    {
        UserEndpoint userEndpoint;

        public UserEndpointTests()
        {
            userEndpoint = new TestUserEndpoint();
        }
    }
}

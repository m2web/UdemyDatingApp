using DatingApp.API.Controllers;
using DatingApp.API.DTOs;
using Xunit;

namespace APITests
{
    public class AuthControllerTests
    {
        private readonly AuthController _authController;

        public AuthControllerTests(AuthController authController)
        {
            _authController = authController;
        }
        
        [Fact]
        public void CreatePasswordHashTest()
        {
            var userDto = new UserForRegisterDTO{
                Username = "Test",
                Password = "password"
            };
            //TODO: get working
            // _authController.Register(userDto);
        }
    }
}
using System;
using Xunit;
using DatingApp.API.Data;
using Moq;
using DatingApp.API.Models;

namespace APITests
{
    public class AuthRepositoryTests
    {
        private readonly IAuthRepository _apiData;

        //TODO: get past the following error:
        /*
            Error Message: Castle.DynamicProxy.InvalidProxyConstructorArgumentsException : 
            Can not instantiate proxy of class: DatingApp.API.Data.DataContext.
            Could not find a constructor that would match given arguments:
            Moq.Mock`1[Microsoft.EntityFrameworkCore.DbContext]

            Note once that is done uncomment CreatePasswordHashTest and test
        */
        public AuthRepositoryTests(){
            var dbContectMock = new Mock<Microsoft.EntityFrameworkCore.DbContext>();
            var mock = new Mock<DataContext>(dbContectMock);
            _apiData = new DatingApp.API.Data.AuthRepository(mock.Object);
        }

        // [Fact]
        // public void CreatePasswordHashTest()
        // {
        //     var user = new User();
        //     _apiData.Register(user, "testpassword");
        // }
    }
}

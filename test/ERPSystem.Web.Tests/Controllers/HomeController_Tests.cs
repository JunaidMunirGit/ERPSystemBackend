﻿using System.Threading.Tasks;
using ERPSystem.Models.TokenAuth;
using ERPSystem.Web.Controllers;
using Shouldly;
using Xunit;

namespace ERPSystem.Web.Tests.Controllers
{
    public class HomeController_Tests: ERPSystemWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
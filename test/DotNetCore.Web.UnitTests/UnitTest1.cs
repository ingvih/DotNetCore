using System;
using DotNetCore.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DotNetCore.Web.UnitTests
{
    public class HomeControllerTests
    {
        private HomeController _homeController;

        public HomeControllerTests()
        {
            _homeController = new HomeController();
        }

        [Fact]
        public void IndexReturnsViewResult()
        {
            // Arrange

            // Act
            IActionResult result = _homeController.Index();

            // Actual
            Assert.IsType<ViewResult>(result);
        }
    }
}

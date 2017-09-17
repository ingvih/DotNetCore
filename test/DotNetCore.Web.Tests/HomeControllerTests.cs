using DotNetCore.Web.Core.Business;
using DotNetCore.Web.Features.Home;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DotNetCore.Web.Tests
{
    public class HomeControllerTests
    {
        private readonly HomeController _homeController;

        public HomeControllerTests()
        {
            _homeController = new HomeController(new ContentBusiness());
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

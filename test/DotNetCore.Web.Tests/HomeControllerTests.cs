using DotNetCore.Web.Core.Business;
using DotNetCore.Web.Features.Home;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Moq;

namespace DotNetCore.Web.Tests
{
    public class HomeControllerTests
    {
        private readonly HomeController _homeController;
        private readonly Mock<IContentBusiness> _contentBusinessMock = new Mock<IContentBusiness>();

        public HomeControllerTests()
        { 
            _homeController = new HomeController(_contentBusinessMock.Object);
        }

        [Fact]
        public void IndexReturnsViewResult()
        {
            // Arrange
            const string expectedOutput = "Output";
            _contentBusinessMock.Setup(x => x.GetTestContent("Input")).Returns(expectedOutput);

            // Act
            IActionResult result = _homeController.Index();
            Assert.IsType<ViewResult>(result);
            var viewResult = (ViewResult)result;
            object model = viewResult.Model;
            Assert.IsType<HomeViewModel>(model);
            var homeViewModel = (HomeViewModel)model;
            string actualOutput = homeViewModel.Property;
            
            // Actual
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}

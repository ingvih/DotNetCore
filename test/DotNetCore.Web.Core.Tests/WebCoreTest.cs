using DotNetCore.Web.Core.Business;
using Xunit;

namespace DotNetCore.Web.Core.Tests
{
    public class WebCoreTest
    {
        private IContentBusiness _contentBusiness;
        public WebCoreTest()
        {
            _contentBusiness = new ContentBusiness();
        }

        [Fact]
        public void TestGetTestValue()
        {
            // Arrange
            const string input = "Test Value";
            string expectedOutput = $"Test from ContentBusiness: {input}";

            // Act
            string actualOutput = _contentBusiness.GetTestContent(input);
            
            // Assert
            Assert.Equal(expectedOutput, actualOutput);


        }
    }
}

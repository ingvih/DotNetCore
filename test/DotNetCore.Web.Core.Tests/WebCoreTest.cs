using Xunit;

namespace DotNetCore.Web.Core.Tests
{
    public class WebCoreTest
    {
        private readonly HelperClass _helperClass;

        public WebCoreTest()
        {
            _helperClass = new HelperClass();
        }

        [Fact]
        public void TestGetTestValue()
        {
            // Arrange
            const string input = "Test Value";
            string expectedOutput = $"Test from Web.Core: {input}";

            // Act
            string actualOutput = _helperClass.GetTestValue(input);
            
            // Assert
            Assert.Equal(expectedOutput, actualOutput);


        }
    }
}

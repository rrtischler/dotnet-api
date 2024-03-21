using Microsoft.Extensions.Logging;
using Moq;

namespace Dotnet.Api.Tests
{
    public class WeatherForecastControllerTest
    {
        private ILogger<WeatherForecastController> _logger;
        private WeatherForecastController _controller;

        public WeatherForecastControllerTest()
        {
            _logger = new Mock<ILogger<WeatherForecastController>>().Object;
            _controller = new(_logger);
        }

        [Fact]
        public void Get_Only_5()
        {
            // Given
            // // When
            var result = _controller.Get();
            // Then
            Assert.Equal(5, result.Count());
        }
    }
}

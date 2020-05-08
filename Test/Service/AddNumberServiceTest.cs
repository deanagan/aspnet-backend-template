using Xunit;
using Xunit.Abstractions;
using FluentAssertions;

using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

using Api.Services;

namespace Test.Service
{
    public class AddNumberServiceShould
    {
        private readonly ILogger<AddNumberService> _logger;

        public AddNumberServiceShould(ITestOutputHelper testOutputHelper)
        {
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddProvider(new XunitLoggerProvider(testOutputHelper));
            _logger = loggerFactory.CreateLogger<AddNumberService>();
        }

        [Theory]
        [InlineData(new object[] {1,1,2})]
        [InlineData(new object[] {2,2,4})]
        [InlineData(new object[] {3,3,6})]
        public void GetTotal_WhenAddingTwoNumbers(int a, int b, int result)
        {
            // Arrange
            var sut = new AddNumberService(_logger);
            // Act
            var total = sut.AddNumbers(a, b);
            // Assert
            total.Should().Be(result);
        }

        [Fact]
        public void GetTotal_WhenAddingTwoNegativeNumbers()
        {
            // Arrange
            var sut = new AddNumberService(_logger);
            // Act
            var total = sut.AddNumbers(-1,-3);
            // Assert
            total.Should().Be(-4);
        }
    }
}

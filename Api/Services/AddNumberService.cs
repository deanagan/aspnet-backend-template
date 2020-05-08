using Microsoft.Extensions.Logging;

namespace Api.Services
{
    public class AddNumberService
    {
        ILogger<AddNumberService> _logger;
        public AddNumberService(ILogger<AddNumberService> logger)
        {
           this._logger = logger;
        }

        public int AddNumbers(int a, int b)
        {
            _logger.LogInformation($"We are adding {a} and {b}");
            return a + b;
        }
    }
}

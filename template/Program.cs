using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DotNetAsyncConsole
{
    public class Program
    {
        private readonly ILogger _logger;

        public Program(ILogger<Program> logger)
        {
            _logger = logger;
        }

        public async Task Run()
        {
            _logger.LogInformation("Hello World");
        }
    }
}

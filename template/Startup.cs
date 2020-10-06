using System.Threading.Tasks;

namespace DotNetAsyncConsole
{
    public static class Startup
    {
        public static async Task Main(string[] args)
        {
            var program = BuildProgram(args);
            await program.Run();

#if DEBUG
            Console.ReadLine();
#endif
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(log => log.AddConsole());
            services.AddSingleton<Program>();
        }

        private static Program BuildProgram(string[] args)
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider(true);

            return serviceProvider.GetRequiredService<Program>();
        }
    }
}

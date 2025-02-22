using ScreenSoundDesktop.Configuration;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ScreenSoundDesktop
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Carregar a configuração do appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Configurar os serviços e injeção de dependência
            var services = new ServiceCollection();
            services.AddDatabaseConfiguration(configuration); // Chama a extensão para configurar o banco
            services.AddTransient<Principal, Principal>(); // DI vai injetar automaticamente o contexto

            ServiceProvider = services.BuildServiceProvider();

            // Rodar a aplicação
            Application.Run(ServiceProvider.GetRequiredService<Principal>());
        }
    }
}

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

            // Carregar a configura��o do appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Configurar os servi�os e inje��o de depend�ncia
            var services = new ServiceCollection();
            services.AddDatabaseConfiguration(configuration); // Chama a extens�o para configurar o banco
            services.AddTransient<Principal, Principal>(); // DI vai injetar automaticamente o contexto

            ServiceProvider = services.BuildServiceProvider();

            // Rodar a aplica��o
            Application.Run(ServiceProvider.GetRequiredService<Principal>());
        }
    }
}

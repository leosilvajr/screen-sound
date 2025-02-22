using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ScreenSoundDesktop.Context
{
    public class ScreenSoundContextFactory : IDesignTimeDbContextFactory<ScreenSoundContext>
    {
        public ScreenSoundContext CreateDbContext(string[] args)
        {
            // Configurar o caminho base e carregar o appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Configurar as opções do DbContext
            var builder = new DbContextOptionsBuilder<ScreenSoundContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlite(connectionString);

            return new ScreenSoundContext(builder.Options);
        }
    }
}

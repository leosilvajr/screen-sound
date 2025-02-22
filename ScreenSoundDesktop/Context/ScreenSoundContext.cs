using Microsoft.EntityFrameworkCore;
using ScreenSound.Models;

namespace ScreenSoundDesktop.Context
{
    public class ScreenSoundContext : DbContext
    {
        public ScreenSoundContext(DbContextOptions<ScreenSoundContext> options) : base(options) { }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Banda> Bandas { get; set; }
        public DbSet<Musica> Musicas { get; set; }

    }
}

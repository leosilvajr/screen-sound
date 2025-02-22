using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScreenSound.Models
{
    public class Banda : IAvaliavel
    {
        private List<Album> albuns = new List<Album>();
        private List<Avaliacao> notas = new List<Avaliacao>();

        public Banda()
        {
            Nome = string.Empty;
        }

        public Banda(string nome)
        {
            Nome = nome;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string? Resumo { get; set; }

        public List<Album> Albuns => albuns;

        public double Media => notas.Count == 0 ? 0 : notas.Average(a => a.Nota);

        public void AdicionarAlbum(Album album)
        {
            albuns.Add(album);
        }

        public void AdicionarNota(Avaliacao nota)
        {
            notas.Add(nota);
        }
    }
}

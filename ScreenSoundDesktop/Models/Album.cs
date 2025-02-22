using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScreenSound.Models
{
    public class Album : IAvaliavel
    {
        private List<Musica> musicas = new List<Musica>();
        private List<Avaliacao> notas = new List<Avaliacao>();

        public Album()
        {
            Nome = string.Empty;
        }

        public Album(string nome)
        {
            Nome = nome;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public List<Musica> Musicas => musicas;

        public double Media => notas.Count == 0 ? 0 : notas.Average(a => a.Nota);

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void AdicionarNota(Avaliacao nota)
        {
            notas.Add(nota);
        }
    }
}

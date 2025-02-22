using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScreenSound.Models
{
    public class Musica
    {
        public Musica()
        {
            Nome = string.Empty;
        }

        public Musica(int artistaId, string nome)
        {
            ArtistaId = artistaId;
            Nome = nome;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [ForeignKey("ArtistaId")]
        public Banda? Artista { get; set; }

        public int ArtistaId { get; set; }

        public int Duracao { get; set; }

        public bool Disponivel { get; set; }

        public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista?.Nome}";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista?.Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            Console.WriteLine(Disponivel ? "Disponível no plano." : "Adquira o plano Plus+");
        }
    }
}

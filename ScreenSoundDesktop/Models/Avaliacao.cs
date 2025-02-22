using System.ComponentModel.DataAnnotations;

namespace ScreenSound.Models
{
    public class Avaliacao
    {
        public Avaliacao() { } // Necessário para o EF Core

        public Avaliacao(int nota)
        {
            Nota = nota;
        }

        [Key]
        public int Id { get; set; }

        [Range(0, 10)]
        public int Nota { get; set; }

        public static Avaliacao Parse(string texto)
        {
            int nota = int.Parse(texto);
            return new Avaliacao(nota);
        }
    }
}

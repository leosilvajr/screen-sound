using PrimeiroProjeto;

internal class Program
{
    private static void Main(string[] args)
    {


        Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
        Services.ExibirOpcoesDoMenu(bandasRegistradas);
    }
}
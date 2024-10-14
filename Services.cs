namespace PrimeiroProjeto
{
    public static class Services
    {


        public static void ExibirOpcoesDoMenu(Dictionary<string, List<int>> bandasRegistradas)
        {
            View.ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibir a média de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    RegistrarBanda(bandasRegistradas);
                    break;
                case 2:
                    MostrarBandasRegistradas(bandasRegistradas);
                    break;
                case 3:
                    AvaliarUmaBanda(bandasRegistradas);
                    break;
                case 4:
                    MostrarMediaDeUmaBanda(bandasRegistradas);
                    break;
                case -1:
                    Console.WriteLine("Tchau tchau :)");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        public static void RegistrarBanda(Dictionary<string, List<int>> bandasRegistradas)
        {
            Console.Clear();
            View.ExibirTituloDasOpcoes("Registro de bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            bandasRegistradas.Add(nomeDaBanda, new List<int>());
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu(bandasRegistradas);
        }

        public static void MostrarBandasRegistradas(Dictionary<string, List<int>> bandasRegistradas)
        {
            Console.Clear();
            View.ExibirTituloDasOpcoes("Exibindo todas as bandas registradas");

            if (bandasRegistradas.Keys.Count == 0)
            {
                Console.WriteLine($"Nenhuma banda registrada até o momento.");
            }

            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu(bandasRegistradas);
        }

        public static void AvaliarUmaBanda(Dictionary<string, List<int>> bandasRegistradas)
        {
            Console.Clear();
            View.ExibirTituloDasOpcoes("Avaliando uma banda");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;

            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
                int nota = int.Parse(Console.ReadLine()!);
                bandasRegistradas[nomeDaBanda].Add(nota);
                Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
                Thread.Sleep(3000);
                Console.Clear();
                ExibirOpcoesDoMenu(bandasRegistradas);
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada.");
                Console.WriteLine("Digite uma tecla para voltar para o menu principal.");
                Console.ReadKey();
                ExibirOpcoesDoMenu(bandasRegistradas);
            }
        }

        public static void MostrarMediaDeUmaBanda(Dictionary<string, List<int>> bandasRegistradas)
        {
            Console.Clear();
            View.ExibirTituloDasOpcoes("Média de uma banda");

            //Qual banda voce quer ver a media
            Console.Write("Digite o nome da banda que deseja ver a média: ");
            string nomeDaBanda = Console.ReadLine()!;


            //Verificar se a banda esta presente no dicionario
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                var bandaSelecionada = bandasRegistradas[nomeDaBanda];
                var totalNotas = 0;

                foreach (int nota in bandaSelecionada)
                {
                    totalNotas += nota;
                }
                var media = totalNotas / bandaSelecionada.Count;

                Console.WriteLine($"\nA media da banda {nomeDaBanda} é {media}.");


                Thread.Sleep(3000);
                Console.Clear();
                ExibirOpcoesDoMenu(bandasRegistradas);
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada.");
                Console.WriteLine("Digite uma tecla para voltar para o menu principal.");
                Console.ReadKey();
                ExibirOpcoesDoMenu(bandasRegistradas);
            }


            //Se estiver realizar o calculo da media e mostrar

        }
    }
}

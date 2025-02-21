using OpenAI_API;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarBanda : Menu
    {
        public  override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Registro das bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            Banda banda = new Banda(nomeDaBanda);
            bandasRegistradas.Add(nomeDaBanda, banda);

            var client = new OpenAIAPI(Constantes.APY_KEY);
            var chat = client.Chat.CreateConversation();

            chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo. Adote um estilo informal.");
            try
            {
                string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
                banda.Resumo = resposta;
            }
            catch (HttpRequestException ex)
            {
                // Verifica se a exceção contém a mensagem de quota insuficiente
                if (ex.Message.Contains("insufficient_quota"))
                {
                    banda.Resumo = "Crédito insuficiente. Por favor, verifique seu plano ou detalhes de faturamento.";
                }
                else
                {
                    // Outras exceções podem ser tratadas aqui, se necessário
                    banda.Resumo = "Erro ao tentar se comunicar com a API.";
                }
            }


            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
        }
    }
}

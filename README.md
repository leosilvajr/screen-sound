# Screen Sound

![Tela do Projeto](https://i.ibb.co/FnJBT19/Screenshot-3.png)

**Screen Sound** é um projeto de console interativo que permite aos usuários registrar, avaliar e consultar a média de bandas musicais. Com uma interface simples e intuitiva, o projeto foi criado para demonstrar o uso de coleções do C# e o conceito de menus dinâmicos em um aplicativo de linha de comando.

## Funcionalidades Principais

- **Registro de Bandas**: Permite ao usuário adicionar bandas ao sistema.
- **Exibição de Bandas Registradas**: Mostra todas as bandas que foram registradas até o momento.
- **Avaliação de Bandas**: O usuário pode atribuir notas às bandas.
- **Cálculo da Média de Notas**: Exibe a média das avaliações feitas para uma banda específica.

## Estrutura do Projeto

### 1. **`Program.cs`**
   O arquivo principal que inicia o projeto e chama as funcionalidades contidas na classe `Services`. Utiliza um dicionario (`Dictionary<string, List<int>>`) para armazenar as bandas e suas avaliações.

### 2. **Namespace `Services`**
   Aqui estão os métodos que realizam as principais ações do sistema:
   
   - `ExibirOpcoesDoMenu`: Mostra o menu principal e trata a escolha do usuário.
   - `RegistrarBanda`: Adiciona uma nova banda ao dicionário.
   - `MostrarBandasRegistradas`: Exibe a lista de bandas registradas.
   - `AvaliarUmaBanda`: Permite ao usuário dar uma nota a uma banda.
   - `MostrarMediaDeUmaBanda`: Calcula e exibe a média das notas de uma banda.

### 3. **Namespace `View`**
   Contém métodos auxiliares para exibição de informações:
   
   - `ExibirLogo`: Mostra o logotipo e uma mensagem de boas-vindas.
   - `ExibirTituloDasOpcoes`: Formata e exibe o título das opções selecionadas.

## Tecnologias Utilizadas

- **C# .NET**: A linguagem principal utilizada para a construção do projeto.
- **Dicionários (`Dictionary`)**: Para armazenar o nome das bandas e suas respectivas avaliações.
- **Estruturas de controle**: Como `switch-case` para lidar com as opções do menu.
- **Funções de Exibição e Formatação**: Métodos para exibir o logotipo, título e organizar o layout do console.
  

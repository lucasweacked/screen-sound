// Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "Red Hot Chili Peppers", "The Bealtes", "U2", "Oasis", "Queen" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Red Hot Chili Peppers", new List<int> { 10, 9, 8 });
bandasRegistradas.Add("Pink Floyd", new List<int>());

void ExibirLogo()
{
    Console.WriteLine("***************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("***************************");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
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
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandas();
            break;
        case 3: AvaliarBandas();
            break;
        case 4: ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulo("Registro das Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTitulo("Exibindo todas as bandas registradas");

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTitulo(string titulo)
{
    int quantidade = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidade, '*');

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBandas()
{
    /*Digite qual banda deseja avaliar.
    Se a banda existir, atribuir uma nota.
    Se não, volta ao menu principal.*/
    Console.Clear();
    ExibirTitulo("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nome = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nome))
    {
        Console.Write($"Qual a nota que a banda {nome} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nome].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nome}!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } 
    else
    {
        Console.WriteLine($"\nA banda {nome} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTitulo("Exibir média de avaliação da banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nome = Console.ReadLine()!;

    if(bandasRegistradas.ContainsKey(nome)) 
    { 
        List<int> notas = bandasRegistradas[nome];
        Console.WriteLine($"\nA média da banda {nome} é {notas.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    } 
    else
    {
        Console.WriteLine($"\nA banda {nome} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();
//Screen Sound

string mensagemBoasVindas = "Boas vindas ao Screen Sound";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirMensagemBoasVindas(){
    Console.WriteLine("*********************");
    Console.WriteLine(mensagemBoasVindas);
    Console.WriteLine("*********************"); 
}


void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\n Digite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; //! para que o valor nao retorne nulo
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2: MostrarBandasRegistradas();
            break;  
        case 3: AvaliarBanda();
        break;
        case 4: ExibirMediaDaBanda();
        break;        
    }

}

void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    ExibirOpcoesMenu();
    Console.Clear();

}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("Bandas registradas até o momento: \n");

    //for (int i = 0; i < listaDasBandas.Count; i++)
   // {
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void AvaliarBanda()
{
    //digite qual banda deseja avaliar
    // se a banda existir no dicionario, atribuir uma nova
    // senao, volta ao menu principal

    Console.Clear();
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.Write($"A nota {nota} foi registrada com sucesso para a banda {nomeBanda}.");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesMenu();

    } else 
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        ExibirOpcoesMenu();
    }

}

void ExibirMediaDaBanda() 
{

    //limpar a tela
    //perguntar qual banda deseja exibir a media
    // consultar se a banda está inserida no dicionario da aplicação
    // se sim, realizar o calculo da media de exibir o resultado

    Console.Clear();
    Console.Write("Qual é o nome da banda que você deseja exibir a média de avaliações? ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeBanda];
        Console.WriteLine($"\nA média da banda {nomeBanda} é {notasDaBanda.Average()}."); //função pronta que exibe a media sem precisar fazer calculo
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();

    } else 
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        
        
    }

}



ExibirMensagemBoasVindas();
ExibirOpcoesMenu();
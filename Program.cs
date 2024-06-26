// Screen Sound

// List<string> bandList = new List<string> { "U2", "The Beatles" };

Dictionary<string, List<int>> bandList = new Dictionary<string, List<int>>
{
    { "Linkin Park", new List<int>{10, 9, 8} },
    { "The Beatles", new List<int>() },
};

static void ShowLogo()
{
    string mensagem = "Boas vindas ao Screen Sound";
    // @"" verbatim literal, permite escrever do jeito que voce quer que apareça
    Console.WriteLine(@"    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagem);
}

void MenuOptions()
{
    ShowLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda: ");
    Console.WriteLine("Digite 2 para mostrar todas as bandas: ");
    Console.WriteLine("Digite 3 para avaliar uma banda: ");
    Console.WriteLine("Digite 4 para exibir a média de uma banda: ");
    Console.WriteLine("Digite 0 para sair: ");

    Console.Write("\nOpção: ");
    string optionInput = Console.ReadLine()!;

    int option = int.Parse(optionInput);

    switch (option)
    {
        case 0:
            break;
        case 1:
            Register();
            break;
        case 2:
            ShowBands();
            break;
        case 3:
            RateBands();
            break;
        case 4:
            break;
    }

}

void Register()
{
    Console.Clear();
    Console.WriteLine(@"
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ █▀█
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▄█
    ");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string name = Console.ReadLine()!;
    bandList.Add(name, new List<int>());
    Console.WriteLine($"A banda foi {name} registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    MenuOptions();

}

void ShowBands()
{
    Console.Clear();
    Console.WriteLine(@"    
█▀▀ ▀▄▀ █ █▄▄ █ █▀█
██▄ █░█ █ █▄█ █ █▀▄
    ");

    foreach (var band in bandList)
    {
        Console.WriteLine($"Banda: {band.Key}");
    }

    Console.ReadKey();
    Console.Clear();
    MenuOptions();
}

void RateBands()
{

    Console.Clear();
    Console.WriteLine(@"
▄▀█ █░█ ▄▀█ █░░ █ ▄▀█ █▀█   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▀█ ▀▄▀ █▀█ █▄▄ █ █▀█ █▀▄   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█
    ");
    Console.Write("\nDigite o nome da banda que deseja avaliar: ");
    string name = Console.ReadLine()!;

    if (!bandList.ContainsKey(name))
    {
        Console.WriteLine($"A banda {name} não foi encontrada");
        Thread.Sleep(2000);
        Console.Clear();
        MenuOptions();
        return;
    }

    Console.Write($"\nDigite a nota da banda {name}:");
    int rate = int.Parse(Console.ReadLine()!);

    bandList[name].Add(rate);
    Console.WriteLine($"\nA banda {name} foi avaliada com a nota {rate}");
    Thread.Sleep(2000);
    Console.Clear();
    MenuOptions();

}

MenuOptions();
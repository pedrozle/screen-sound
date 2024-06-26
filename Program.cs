// Screen Sound

List<string> bandList = new List<string> { "U2", "The Beatles" };

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
    bandList.Add(name);
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
    for (int i = 0; i < bandList.Count; i++)
    {
        Console.WriteLine($"Banda: {bandList[i]}");
    }
    Console.ReadKey();
    Console.Clear();
    MenuOptions();
}

MenuOptions();
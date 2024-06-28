// Screen Sound

using ScreenSound.DB;
using ScreenSound.Menus;
using ScreenSound.Models;

try
{
    using var connection = new Connection().GetConnection();
    connection.Open();
    Console.WriteLine(connection.State);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
return;

Artist linkinPark = new("Linkin Park");
linkinPark.RateArtist(10);
linkinPark.RateArtist(8);
linkinPark.RateArtist(10);
linkinPark.RateArtist(7);

Artist theBeatles = new("The Beatles");
theBeatles.RateArtist(10);
theBeatles.RateArtist(5);
theBeatles.RateArtist(7);

Album album = new("Hybrid Theory", linkinPark.Name, 2000);

Music music1 = new("Papercut", linkinPark.Name, album.Name, 185, true);
Music music2 = new("One Step Closer", linkinPark.Name, album.Name, 157, true);
Music music3 = new("Crawling", linkinPark.Name, album.Name, 209, false);
Music music4 = new("In the End", linkinPark.Name, album.Name, 216, false);
Music music5 = new("A Place for My Head", linkinPark.Name, album.Name, 185, false);

album.AddMusic(music1);
album.AddMusic(music2);
album.AddMusic(music3);
album.AddMusic(music4);
album.AddMusic(music5);

linkinPark.AddAlbum(album);

album = new("Meteora", linkinPark.Name, 2003);

music1 = new("Numb", linkinPark.Name, album.Name, 187, true);
music2 = new("Somewhere I Belong", linkinPark.Name, album.Name, 220, true);
music3 = new("Breaking the Habit", linkinPark.Name, album.Name, 197, false);
music4 = new("Faint", linkinPark.Name, album.Name, 162, false);
music5 = new("From the Inside", linkinPark.Name, album.Name, 170, false);

album.AddMusic(music1);
album.AddMusic(music2);
album.AddMusic(music3);
album.AddMusic(music4);
album.AddMusic(music5);


linkinPark.AddAlbum(album);

Dictionary<string, Artist> bandList = new()
{
    { linkinPark.Name, linkinPark },
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
    Console.WriteLine("Digite 4 para exibir detalhes de uma banda: ");
    Console.WriteLine("Digite 0 para sair: ");

    Console.Write("\nOpção: ");
    string optionInput = Console.ReadLine()!;

    int option = int.Parse(optionInput);

    switch (option)
    {
        case 0:
            break;
        case 1:
            var menuRegister = new MenuRegister();
            menuRegister.Execute(bandList);
            MenuOptions();
            break;
        case 2:
            var menuListArtist = new MenuListArtist();
            menuListArtist.Execute(bandList);
            MenuOptions();
            break;
        case 3:
            var menuRateArtist = new MenuRateArtist();
            menuRateArtist.Execute(bandList);
            MenuOptions();
            break;
        case 4:
            var menuInfo = new MenuInfo();
            menuInfo.Execute(bandList);
            MenuOptions();
            break;
    }

}

MenuOptions();
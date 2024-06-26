namespace ScreenSound.Menus;

class Menu
{

    readonly List<string> Titles = new List<string>
    {
        @"    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ",
    @"
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ █▀█
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▄█
    ",
    @"    
█▀▀ ▀▄▀ █ █▄▄ █ █▀█
██▄ █░█ █ █▄█ █ █▀▄
    ",
    @"
▄▀█ █░█ ▄▀█ █░░ █ ▄▀█ █▀█   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▀█ ▀▄▀ █▀█ █▄▄ █ █▀█ █▀▄   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█
    ",
    @"
█ █▄░█ █▀▀ █▀█
█ █░▀█ █▀░ █▄█
    "
    };

    public void ShowTitle(int menuOption)
    {
        Console.Clear();
        Console.WriteLine(Titles[menuOption]);
    }

}
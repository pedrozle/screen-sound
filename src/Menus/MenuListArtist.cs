using ScreenSound.Models;

namespace ScreenSound.Menus;

class MenuListArtist : Menu
{

    internal void Execute(Dictionary<string, Artist> bandList)
    {
        ShowTitle(2);

        foreach (var band in bandList)
        {
            Console.WriteLine($"Banda: {band.Key}");
        }

        Console.ReadKey();
        Console.Clear();
    }

}
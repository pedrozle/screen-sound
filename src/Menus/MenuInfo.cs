using ScreenSound.Models;

namespace ScreenSound.Menus;

class MenuInfo : Menu
{


    internal void Execute(Dictionary<string, Artist> bandList)
    {
        ShowTitle(4);
        Console.Write("\nDigite o nome da banda que deseja obter os detalhes: ");
        string name = Console.ReadLine()!;
        if (!bandList.TryGetValue(name, out Artist? value))
        {
            Console.WriteLine($"A banda {name} não foi encontrada");
            Thread.Sleep(2000);
            Console.Clear();
        }

        var artist = bandList[name];
        Console.WriteLine($"\n{artist}");
        Console.ReadKey();
        Console.Clear();
    }

}
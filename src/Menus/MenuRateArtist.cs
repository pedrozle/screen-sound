using ScreenSound.Models;

namespace ScreenSound.Menus;

class MenuRateArtist : Menu
{
    internal void Execute(Dictionary<string, Artist> bandList)
    {
        ShowTitle(3);

        Console.Write("\nDigite o nome da banda que deseja avaliar: ");
        string name = Console.ReadLine()!;

        if (!bandList.TryGetValue(name, out Artist? value))
        {
            Console.WriteLine($"A banda {name} não foi encontrada");
            Thread.Sleep(2000);
            Console.Clear();
            return;
        }

        Console.Write($"\nDigite a nota da banda {name}:");
        int rate = int.Parse(Console.ReadLine()!);

        bandList[name].RateArtist(rate);

        Console.WriteLine($"\nA banda {name} foi avaliada com a nota {rate}");
        Thread.Sleep(2000);
        Console.Clear();
    }
}
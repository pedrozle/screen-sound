using ScreenSound.Models;

namespace ScreenSound.Menus;

class MenuRegister : Menu
{
    internal void Execute(Dictionary<string, Artist> bandList)
    {
        ShowTitle(1);
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string name = Console.ReadLine()!;

        if (bandList.ContainsKey(name))
        {
            Console.WriteLine("Banda já registrada!");
            Thread.Sleep(2000);
            Console.Clear();
        }

        Artist artist = new(name);
        bandList.Add(name, artist);

        Console.WriteLine($"A banda foi {name} registrada com sucesso");
        Thread.Sleep(2000);
        Console.Clear();
    }
}
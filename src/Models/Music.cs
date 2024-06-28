namespace ScreenSound.Models;

class Music(string name, string artist, string album, int duration, bool available)
{
    public string Name { get; } = name;
    public string Artist { get; } = artist;
    public string Album { get; } = album;
    public int Duration { get; } = duration;
    public bool Available { get; } = available;

    override public string ToString()
    {
        return $"Título: {Name}, Artista: {Artist}, Album: {Album} Duração: {Duration}, Disponível:  {(Available ? "Disponível na assinatura" : "Assine para ter acesso")}";
    }

}


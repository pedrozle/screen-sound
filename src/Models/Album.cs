namespace ScreenSound.Models;

class Album(string albumName, string artist, int year)
{

    private readonly List<Music> MusicCollection = [];

    public string Name { get; } = albumName;

    private string Artist { get; set; } = artist;

    private int Year { get; set; } = year;

    private int Duration { get; set; } = 0;

    public void AddMusic(Music music)
    {
        MusicCollection.Add(music);
        Duration += music.Duration;
    }

    public override string ToString()
    {
        string info = $"Álbum: {Name}\nArtist: {Artist}\nAno de lançamento: {Year}\nDuração total {Duration} segundos\nMúsicas:";

        foreach (Music music in MusicCollection)
        {
            info += $"\n{music}";
        }
        return info;
    }

}

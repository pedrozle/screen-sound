namespace ScreenSound;
class Artist(string name)
{
    public string Name { get; } = name;

    private List<Album> Discography { get; } = [];

    private List<int> Rating { get; } = [];

    public void AddAlbum(Album album)
    {
        Discography.Add(album);
    }

    public void RateArtist(int rate)
    {
        Rating.Add(rate);
    }

    public float GetRating()
    {
        if (Rating.Count == 0) return 0f;
        return Rating.Sum() / Rating.Count;
    }

    public override string ToString()
    {
        string info = $"Artista: {Name}\nAvaliação: \nMédia: {GetRating()} - Total de avaliações: {Rating.Count}\n\nDiscografia: \n";
        foreach (var album in Discography)
        {
            info += $"\n{album}\n\n";
        }
        return info;
    }

}
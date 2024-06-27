namespace ScreenSound;
class Artist(string name)
{
    public string Name { get; } = name;

    private List<Album> Discography { get;} = new List<Album>();

    public void AddAlbum(Album album){
        Discography.Add(album);
    }

    public override string ToString(){
        string info = $"Artista: {Name}\n\nDiscografia: \n";
        foreach (var album in Discography)
        {
            info += $"\n{album.ToString()}\n\n";
        }
        return info;
    }

}
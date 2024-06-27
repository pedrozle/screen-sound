namespace ScreenSound
{
    class Music
    {
        public string Name { get; }
        public string Artist { get; }
        public string Album { get; }
        public int Duration { get; }
        public bool Available { get; }

        public Music(string name, string artist, string album, int duration, bool available)
        {
            Name = name;
            Artist = artist;
            Album = album;
            Duration = duration;
            Available = available;
        }

        override public string ToString()
        {
            return $"Título: {Name}, Artista: {Artist}, Album: {Album} Duração: {Duration}, Disponível:  {(Available ? "Disponível na assinatura" : "Assine para ter acesso")}";
        }

    }
}
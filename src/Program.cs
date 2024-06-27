// Screen Sound

using ScreenSound;

Album album = new("A Night at the Opera", "Queen", 1975);

Music music1 = new("Bohemian Rhapsody", "Queen", "A Night at the Opera", 355, true);
Music music2 = new("You Are My Best Friend", "Queen", "A Night at the Opera", 172, true);
Music music3 = new("Love of my life", "Queen", "A Night at the Opera", 219, false);
Music music4 = new("Death of two lefs", "Queen", "A Night at the Opera", 223, false);

album.AddMusic(music1);
album.AddMusic(music2);
album.AddMusic(music3);
album.AddMusic(music4);

Artist artist = new("Queen");

artist.AddAlbum(album);

Console.WriteLine(artist.ToString());

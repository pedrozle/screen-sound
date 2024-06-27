// Screen Sound

using ScreenSound;

Artist artist = new("Queen");

Album album = new("A Night at the Opera", artist.Name, 1975);

Music music1 = new("Bohemian Rhapsody", artist.Name, album.Name, 355, true);
Music music2 = new("You Are My Best Friend", artist.Name, album.Name, 172, true);
Music music3 = new("Love of my life", artist.Name, album.Name, 219, false);
Music music4 = new("Death of two lefs", artist.Name, album.Name, 223, false);

album.AddMusic(music1);
album.AddMusic(music2);
album.AddMusic(music3);
album.AddMusic(music4);


artist.AddAlbum(album);

Console.WriteLine(artist.ToString());

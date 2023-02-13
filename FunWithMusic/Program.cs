using System;
using System.Net.Http.Headers;

namespace movies
{
    class Program
    {
        enum Genre
        {
            Pop,
            Rock,
            Metal,
            Classical,
            HipHop
        }
        struct Song
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Song(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;    
                Genre = genre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setLength(string length)
            {
                Length = length;
            }

            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength: " + Length +
                    "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What album?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("What's it's length?");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("P - Pop\nR - Rock\nM - Metal\nC - Classical\nH - HipHop");
            Genre tempGenre = Genre.Pop;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'M':
                    tempGenre = Genre.Metal;
                    break;
                case 'C':
                    tempGenre = Genre.Classical;
                    break;
                case 'H':
                    tempGenre = Genre.HipHop;
                    break;
            }
            Song song = new Song(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Console.WriteLine($"{song.Display()}");
            Song newSong = song;
            Console.WriteLine("What is the next song title?");
            newSong.setTitle(Console.ReadLine());
            Console.WriteLine("What is the length of the next song?");
            newSong.setLength(Console.ReadLine());
            Console.WriteLine($"{newSong.Display()}");
            Console.ReadLine();
        }
    }
}
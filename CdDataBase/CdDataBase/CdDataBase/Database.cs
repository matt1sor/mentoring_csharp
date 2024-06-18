using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace CdDataBase
{
    public class Database
    {
        private List<Album> albums;

        public Database()
        {
            albums = new List<Album>();
        }

        public void AddAlbumToDatabase(Album album)
        {
            albums.Add(album);
        }

        public void DisplayAll()
        {
            albums.ForEach(p => Console.WriteLine(p.AlbumId));
        }

        // public void AlbumDetails(int id)
        // {
        //     var album = albums.FirstOrDefault(a => a.AlbumId == id.ToString());
        //     if (album != null)
        //     {
        //         Console.WriteLine($"Title: {album.Title}");
        //         Console.WriteLine($"Type: {album.Type}");
        //         Console.WriteLine($"Duration: {album.Duration}");
        //         Console.WriteLine("Tracks:");
        //         foreach (var track in album.Tracks)
        //         {
        //             Console.WriteLine($"  {track.TrackId}. {track.Title}");
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("Album not found");
        //     }
        // }
        
        
        public void TrackDetailsByNumber(int albumId,int trackNumber)
        {
            var album = albums.FirstOrDefault(a => a.AlbumId == albumId.ToString());
            if (album != null)
            {
                var track = album.Tracks[trackNumber];
                if (track != null)
                {
                    Console.WriteLine($"Title: {track.Title}");
                    Console.WriteLine($"Duration: {track.Duration}");
                    Console.WriteLine("Artists:");
                    foreach (var artist in track.Artists)
                    {
                        Console.WriteLine(artist);
                    }
                    Console.WriteLine($"Composer: {track.Composer}");
                }
                else
                {
                    Console.WriteLine("Track not found");
                }
            }
            else
            {
                Console.WriteLine("Album not found");
            }
        }
        
        
        public void TrackDetailsByName(int albumId,string trackName)
        {
            var album = albums.FirstOrDefault(a => a.AlbumId == albumId.ToString());
            if (album != null)
            {
                var track = album.Tracks.FirstOrDefault(t => t.Title == trackName);
                if (track != null)
                {
                    Console.WriteLine($"Title: {track.Title}");
                    Console.WriteLine($"Duration: {track.Duration}");
                    Console.WriteLine("Artists:");
                    foreach (var artist in track.Artists)
                    {
                        Console.WriteLine(artist);
                    }
                    Console.WriteLine($"Composer: {track.Composer}");
                }
                else
                {
                    Console.WriteLine("Track not found");
                }
            }
            else
            {
                Console.WriteLine("Album not found");
            }
        }
        
        
        
        
        
        
        // public void SaveToFile(string filePath)
        // {
        //     var tempPath = Path.GetTempPath();
        //     // var tempPath = "/Users/mateusz";
        //     var fileName = "database.txt";
        //     var path = Path.Combine(tempPath, fileName);
        //     var file = new StreamWriter(path);
        //     foreach (var line in this.albums)
        //     {
        //         file.WriteLine(line);
        //     }
        // }

        
    }
    
    public class Program
    {
        static void Main()
        {
            var database = new Database();
            Person mateusz = new Person("Mateusz","Depka");
            Person mariusz = new Person("Mariusz","Depka");
            Person adam = new Person("Adam","Depka");

            List<Person> lista = new List<Person>(){mariusz,mateusz,adam};

            Track mentoring = new Track("Mentoring", 3.30, lista, mateusz);
            Track cSharp = new Track("Mentoring", 3.30, lista, adam);
            Track sii = new Track("Mentoring", 2.30, lista, mariusz);
            
            List<Track> trackList = new List<Track>(){mentoring, cSharp, sii};

            Album intern = new Album("Intern", "CD", 9.30, trackList, lista);
            
            database.AddAlbumToDatabase(intern);
            database.DisplayAll();
            // database.AlbumDetails(1);
            // database.TrackDetails(1,2);
            // database.SaveToFile("/Users/mateusz");
        }
        
        




       

    }
    

}


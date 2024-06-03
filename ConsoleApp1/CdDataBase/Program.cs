


namespace CdDataBase
{
   public class Person
   {
       public string Name;
       public string Lastname;

        public Person(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }
        
    }
   public class Track
    {
        public string Title;
        public double Duration;
        public List<Person> Artists;
        public Person Composer;
        public int TrackId;
        
        public Track(string title, double duration, List<Person> artists, Person composer, int trackId)
        {
            Title = title;
            Duration = duration;
            Artists = artists;
            Composer = composer;
            TrackId = trackId;
        }
        
        
        
    }
    public class Album
    {
        public String Title;
        public String Type;
        public double Duration;
        public List<Track> Tracks;
        public List<Person> Musicians;
        public int AlbumId;
        
        public Album(string title, string type, double duration, List<Track> tracks, List<Person> artists, int albumNumber)
        {
            Title = title;
            Type = type;
            Duration = duration;
            Tracks = tracks;
            Musicians = artists;
            AlbumId = albumNumber;
        }
        
    }



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
            albums.ForEach(p => Console.WriteLine(p.Title));
        }

        public void AlbumDetails(int id)
        {
            foreach (var p in albums)
            {
                if (p.AlbumId == id)
                {
                    Console.WriteLine($"Title: {p.Title}");
                    Console.WriteLine($"Type: {p.Type}");
                    Console.WriteLine($"Duration: {p.Duration}");
                    Console.WriteLine("Tracks:");
                    foreach (var track in p.Tracks)
                    {
                        Console.WriteLine($"  {track.TrackId}. {track.Title}");
                    }
                    
                }
                
            }
        }
        
        //error handling (if not exists) ???
        
        public void TrackDetails(int AlbumId,int TrackId)
        {
            foreach (var p in albums)
            {
                if (p.AlbumId == AlbumId)
                {
                    foreach (var track in p.Tracks)
                        
                    {
                        if (track.TrackId == TrackId)
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
                    }
                    
                }
                
            }
        }
        
        //error handling (if not exists) ???
        
        
        
        
        public void SaveToFile(string filePath)
        {
            var tempPath = Path.GetTempPath();
            // var tempPath = "/Users/mateusz";
            var fileName = "database.txt";
            var path = Path.Combine(tempPath, fileName);
            var file = new StreamWriter(path);
            foreach (var line in this.albums)
            {
                file.WriteLine(line);
            }
        }

        
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

            Track mentoring = new Track("Mentoring", 3.30, lista, mateusz, 1);
            Track cSharp = new Track("Mentoring", 3.30, lista, adam, 2);
            Track sii = new Track("Mentoring", 2.30, lista, mariusz, 3);
            
            List<Track> trackList = new List<Track>(){mentoring, cSharp, sii};

            Album intern = new Album("Intern", "CD", 9.30, trackList, lista, 1);// we can add method which count duration by tracks
            
            database.AddAlbumToDatabase(intern);
            database.DisplayAll();
            database.AlbumDetails(1);
            database.TrackDetails(1,2);
            database.SaveToFile("/Users/mateusz");
        }
        
        




       

    }
    

}


using System;
using System.Collections.Generic;
namespace CdDataBase
{
    public class Album
    {
        public string Title;
        public string Type;
        public double Duration;
        public List<Track> Tracks;
        public List<Person> Musicians;

        public string AlbumId { get; }

    private string GenerateId()
        {
            return Guid.NewGuid().ToString("N");
        }
        public Album(string title, string type, double duration, List<Track> tracks, List<Person> artists)
        {
            Title = title;
            Type = type;
            Duration = duration;  
            Tracks = tracks;
            Musicians = artists;
            AlbumId = GenerateId();
        }
        
    }
}
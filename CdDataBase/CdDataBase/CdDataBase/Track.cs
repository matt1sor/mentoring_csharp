
using System;
using System.Collections.Generic;

namespace CdDataBase
{
    public class Track
    {
        public string Title;
        public double Duration;
        public List<Person> Artists;
        public Person Composer;
        public string TrackId{ get; }
        
        private string GenerateId()
        {
            return Guid.NewGuid().ToString("N");
        }
        public Track(string title, double duration, List<Person> artists, Person composer)
        {
            Title = title;
            Duration = duration;
            Artists = artists;
            Composer = composer;
            TrackId = GenerateId();
        }
        
        
        
    }
}
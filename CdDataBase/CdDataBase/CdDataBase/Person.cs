using System;

namespace CdDataBase
{
    public class Person
    {
        public string Name;
        public string Lastname;
        public string PersonId { get; }
        
        private string GenerateId()
        {
            return Guid.NewGuid().ToString("N");
        }

        public Person(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
            PersonId = GenerateId();
        }
        
    }
}
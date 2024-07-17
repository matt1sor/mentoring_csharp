using System;
using System.Collections.Generic;

namespace CdDataBase
{
    public class Person
    {
        public string Name;
        public string Lastname;
        public List<Person> PersonList;
        public string PersonId { get; }
        
        private static IdGenerator _idGenerator = new IdGenerator();
        string _randomId = _idGenerator.GenerateId();

        public Person(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
            PersonId = _randomId;
        }
        
    }
}
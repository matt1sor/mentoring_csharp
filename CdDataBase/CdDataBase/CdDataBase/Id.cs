
using System;
using System.Collections.Generic;

namespace CdDataBase
{
    public class IdGenerator
    {
        private List<string> _idList = new List<string>();
        
        public string GenerateId()
        {
            string newId = Guid.NewGuid().ToString("N");
            
            while (_idList.Contains(newId))
            {
                 newId = Guid.NewGuid().ToString("N");
            }
            
            _idList.Add(newId);


            return newId;

        }
    }
}
using System;
using System.Collections.Generic;

namespace GTM.app.Game.GameEntities
{
    public class Commander : IDatObject
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public int BirthDay { get; set; }
        public int BirthMonth { get; set; }
        public int BirthYear { get; set; }
        public string History { get; set; }
        public List<string> RawData { get; set; }

        public void ConvertFromRawData()
        {
            throw new NotImplementedException();
        }
    }
}
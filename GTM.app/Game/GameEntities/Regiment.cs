using System;
using System.Collections.Generic;

namespace GTM.app.Game.GameEntities
{
    public class Regiment : IDatObject
    {
        public int ID { get; set; }
        public string RegimentName { get; set; }
        public int GroupID { get; set; }
        public int RegimentType { get; set; }
        public int CommanderID { get; set; }
        public int Manpower { get; set; }
        public string History { get; set; }
        public List<string> RawData { get; set; }
    }
}
using System.Collections.Generic;
using System.Diagnostics;

namespace GTM.app.Game.GameEntities
{
    public class MilitaryGroup : IDatObject
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        public List<string> RawData { get; set; }
    }
}
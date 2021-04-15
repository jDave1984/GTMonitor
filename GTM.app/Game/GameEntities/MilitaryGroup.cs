using System.Collections.Generic;
using System.Diagnostics;

namespace GTM.app.Game.GameEntities
{
    public class MilitaryGroup : IDatObject
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        public List<string> RawData { get; set; }

        public void ConvertFromRawData()
        {
            Debug.Print(RawData.Count.ToString());
            if (RawData.Count > 0)
            {
                ID = int.Parse(RawData[0]);
                GroupName = RawData[1];
            }
        }
    }
}
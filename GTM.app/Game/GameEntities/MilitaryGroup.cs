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
            Debug.Print(this.RawData.Count.ToString());
            if (this.RawData.Count > 0)
            {
                this.ID = int.Parse(this.RawData[0]);
                this.GroupName = this.RawData[1];
            }
        }
    }
}
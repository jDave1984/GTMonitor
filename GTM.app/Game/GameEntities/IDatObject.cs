using System.Collections.Generic;

namespace GTM.app.Game.GameEntities
{
    public interface IDatObject
    {
        List<string> RawData { get; set; }
        void ConvertFromRawData();
    }
}
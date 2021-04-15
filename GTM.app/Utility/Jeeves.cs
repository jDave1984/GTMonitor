using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace GTM.app.Utility
{
    public static class Jeeves
    {
        public static void PrintOutDebugList(List<string> text)
        {
            var builder = new StringBuilder();
            foreach (var t in text)
            {
                builder.Append($"{t}    |    ");
            }
            
            Debug.Print(builder.ToString());
        }
    }
}
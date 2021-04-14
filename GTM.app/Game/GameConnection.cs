using System.IO;
using System.Linq;
using System.Text;

namespace GTM.app.Game
{
    public static class GameConnection
    {
        public static string RootFolder { get; set; }

        public static string GetLastSave()
        {
            var fileToRead = $"{RootFolder}\\Config\\lastgame.dat";
            var text = File.ReadLines(fileToRead);
            var lastTwo = text.TakeLast(2);

            var builder = new StringBuilder($"{RootFolder}\\Campaigns");

            foreach (var s in lastTwo)
            {
                builder.Append($"\\{s}");
            }
            
            return builder.ToString().Replace("/",@"\");
        }
    }
}
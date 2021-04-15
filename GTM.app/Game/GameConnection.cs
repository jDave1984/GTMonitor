using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using GTM.app.Game.GameEntities;

namespace GTM.app.Game
{
    public static class GameConnection
    {
        /// <summary>
        ///     Default Root Folder for all game data
        /// </summary>
        public static string RootFolder { get; set; }

        /// <summary>
        ///     Gets or sets the folder that the last save was in
        /// </summary>
        private static string LastSaveFolder { get; set; }

        /// <summary>
        ///     Gets the File Path of the last game saved.
        /// </summary>
        /// <returns></returns>
        public static string GetLastSave()
        {
            var fileToRead = $"{RootFolder}\\Config\\lastgame.dat";
            var text = File.ReadLines(fileToRead);
            var lastTwo = text.TakeLast(2);

            var builder = new StringBuilder($"{RootFolder}\\Campaigns");

            foreach (var s in lastTwo) builder.Append($"\\{s}");

            var filePath = builder.ToString().Replace("/", @"\");
            LastSaveFolder = filePath;
            return filePath;
        }

        /// <summary>
        ///     Reads the "groups.dat" file in the last saved filepath to return a list of Military Gropus
        /// </summary>
        /// <returns></returns>
        public static List<MilitaryGroup> GetGroups()
        {
            var fileToRead = $"{LastSaveFolder}\\groups.dat";
            var groups = new List<MilitaryGroup>();
            var rowsFromFile = GetRawDataFromDatFile(fileToRead, 33);

            foreach (var rd in rowsFromFile)
                groups.Add(new MilitaryGroup
                {
                    ID = int.Parse(rd[0]),
                    GroupName = rd[1]
                });

            return groups;
        }

        public static List<Commander> GetCommanders()
        {
            var fileToRead = $"{LastSaveFolder}\\commanders.txt";
            var commanders = new List<Commander>();
            var rowsFromFile = GetRawDataFromDatFile(fileToRead, 63);

            foreach (var rd in rowsFromFile)
                commanders.Add(new Commander
                {
                    ID = int.Parse(rd[0]),
                    LastName = rd[1],
                    FirstName = rd[2],
                    FullName = rd[3],
                    BirthDay = int.Parse(rd[14]),
                    BirthMonth = int.Parse(rd[15]),
                    BirthYear = int.Parse(rd[16]),
                    History = rd[56]
                });

            return commanders;
        }

        /// <summary>
        ///     Gets a list of regiments
        /// </summary>
        /// <returns></returns>
        public static List<Regiment> GetRegiments()
        {
            var fileToRead = $"{LastSaveFolder}\\regiments.dat";
            var regiments = new List<Regiment>();
            var rowsFromFile = GetRawDataFromDatFile(fileToRead, 40);

            foreach (var rd in rowsFromFile)
                regiments.Add(new Regiment
                {
                    ID = int.Parse(rd[0]),
                    RegimentName = rd[1],
                    GroupID = int.Parse(rd[3]),
                    RegimentType = int.Parse(rd[4]),
                    CommanderID = int.Parse(rd[5]),
                    Manpower = int.Parse(rd[6]),
                    History = rd[31]
                });

            return regiments;
        }

        private static List<List<string>> GetRawDataFromDatFile(string fileName, int numberOfColumns)
        {
            var text = File.ReadLines(fileName);
            var counter = 0;
            var returnData = new List<List<string>>();
            var rawData = new List<string>();

            foreach (var s in text)
                if (counter > 0)
                {
                    rawData.Add(s);
                    counter++;

                    if (counter == numberOfColumns)
                    {
                        returnData.Add(new List<string>(rawData));

                        rawData.Clear();
                        counter = 1;
                    }
                }
                else
                {
                    counter++;
                }

            return returnData;
        }
    }
}
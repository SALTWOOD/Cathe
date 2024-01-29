using Cathe;
using Cathe.Helpers;
using Cathe.Saves;
using Newtonsoft.Json;

namespace Cathe.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Save save = new Save()
            {
                PlayerName = "SALTWOOD",
                PlayerSongHistory = new SongResultArray
                {
                    Results = new List<LevelResult>
                    {
                        new LevelResult(){ accuracy = 108, level = new Level(){ SongMetadata = new SongMetadata()
                        {
                            Artist = "S",
                            Chart = "S",
                            difficulty = Difficulty.Special,
                            Illustration = "S",
                            Level = 10,
                            Rating = 15.8,
                            Name = "S",
                        }}}
                    }
                },
                Recent = new SongResultArray
                {
                    Results = new List<LevelResult>
                    {
                        new LevelResult(){ accuracy = 108, level = new Level(){ SongMetadata = new SongMetadata()
                        {
                            Artist = "S",
                            Chart = "S",
                            difficulty = Difficulty.Special,
                            Illustration = "S",
                            Level = 10,
                            Rating = 15.8,
                            Name = "S",
                        }}}
                    }
                }
            };

            for (int i = 0; i < 27; i++)
            save.PlayerSongHistory.Results.Add(save.PlayerSongHistory.Results[0]);

            for (int i = 0; i < 4; i++)
            save.Recent.Results.Add(save.Recent.Results[0]);

            Console.WriteLine(save.GetPlayerRating());
            Console.WriteLine(save.Recent.GetRating(5));
        }
    }
}

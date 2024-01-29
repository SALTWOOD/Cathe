using Cathe.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cathe.Saves
{
    public class Save
    {
        public string PlayerName { get; set; } = "Guest";
        public Setting Setting { get; set; } = new Setting();
        public SongResultArray PlayerSongHistory { get; set; } = new SongResultArray();
        public SongResultArray Recent { get; set; } = new SongResultArray();

        public double GetPlayerRating()
        {
            double b28 = this.PlayerSongHistory.GetRating();
            double r5 = this.Recent.GetRating(5);
            return (b28 * 28 + r5 * 5) / (28 + 5);
        }
    }
}

using Cathe.Saves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cathe.Helpers
{
    public class SongResultArray
    {
        public List<LevelResult> Results { get; init; }

        public SongResultArray()
        {
            this.Results = new List<LevelResult>();
        }

        public SongResultArray(List<LevelResult> results)
        {
            this.Results = results;
        }

        public double GetRating(int count = 28)
        {
            var selectedLevels = this.Results.OrderBy(r => -r.Time).Take(count);
            return selectedLevels.Sum(r => r.Rating) / count;
        }
    }
}

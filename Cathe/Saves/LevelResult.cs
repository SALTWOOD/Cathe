using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cathe.Saves
{
    public class LevelResult
    {
        public required Level level { get; init; }
        public double accuracy { get; init; }
        public double Rating
        {
            get => Math.Pow((accuracy - 30) / 78, 1.5) * level.SongMetadata.Rating * 1.04;
        }
        public long Time { get; private set; } = DateTime.Now.Ticks;
    }
}

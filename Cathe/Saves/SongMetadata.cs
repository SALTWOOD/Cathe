using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cathe.Saves
{
    public class SongMetadata
    {
        public required string Name { get; set; }
        public required string Artist {  get; set; }
        public required Difficulty difficulty { get; set; }
        public required int Level { get; set; }
        public required double Rating { get; set; }
        public required string Chart { get; set; }
        public required string Illustration { get; set; }
    }
}

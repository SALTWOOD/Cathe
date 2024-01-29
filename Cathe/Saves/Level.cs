using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cathe.Saves
{
    public class Level
    {
        [JsonProperty(PropertyName = "uuid")]
        public Guid Id { get; set; }

        [JsonProperty(PropertyName = "difficulty")]
        public Difficulty Difficulty { get; set; }
        [JsonProperty(PropertyName = "metadata")]
        public required SongMetadata SongMetadata { get; set; }
    }
}

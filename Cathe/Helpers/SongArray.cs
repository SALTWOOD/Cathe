using Cathe.Saves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cathe.Helpers
{
    public class SongArray
    {
        private Song[] songs;

        public SongArray()
        {
            this.songs = new Song[0];
        }

        public SongArray(Song[] results)
        {
            this.songs = results;
        }
    }
}

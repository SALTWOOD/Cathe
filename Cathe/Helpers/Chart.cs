using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cathe.Helpers
{
    public class Chart
    {
        public Note[] notes = new Note[0];
        //public Animation[] animations = new Animation[0];
    }

    public class Note
    {
        public double time;
        public NoteType type;
        public int line;
        public double position;
    }

    public enum NoteType
    {
        Click,
        Catch,
        Kick,
        Hold
    }
}

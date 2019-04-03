using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Id3Cleaner
{
    class TrackData
    {
        public TrackData(string title, string path)
        {
            this.Title = title;
            this.FilePath = path;
        }

        public string Title { get; private set; }
        public string FilePath { get; private set; }
    }
}

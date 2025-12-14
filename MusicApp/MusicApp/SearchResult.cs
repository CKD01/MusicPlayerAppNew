using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class SearchResult
    {
        public int Index { get; set; }
        public string Display { get; set; }

        public override string ToString()
        {
            return Display;
        }
    }
}

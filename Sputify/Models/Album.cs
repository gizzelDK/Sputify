using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sputify.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string AlbumTitle { get; set; }
        public ICollection<Song> Songs  { get; set; }
    }
}

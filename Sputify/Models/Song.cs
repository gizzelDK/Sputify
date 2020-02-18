using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sputify.Models
{
    public class Song
    {
        public int SongID { get; set; }
        [StringLength(30)]
        public string SongName { get; set; }
        public Album? Album { get; set; }
        public int? TrackNumber { get; set; }
        public string SongPath { get; set; }

    }
}

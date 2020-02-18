using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sputify.Models
{
    public class Playlist
    {
        public int PlaylistID { get; set; }
        [StringLength(30)]
        public string PlaylistName { get; set; }
        public Collection Collection { get; set; }
    }
}

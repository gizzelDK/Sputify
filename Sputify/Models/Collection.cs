using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sputify.Models
{
    public class Collection
    {
        public int CollectionID { get; set; }
        public int PlayOrder { get; set; }
        public Song Song { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SightingsWebAPI2.DAL
{
    public class ZooAnimalSighting
    {
        public int Id { get; set; }

        public string Sighter { get; set; }
        public DateTime SightingDate { get; set; }
        public bool? IsSightingReliable { get; set; }

        // Navigation
        public virtual Animal Animal { get; set; }
    }


}

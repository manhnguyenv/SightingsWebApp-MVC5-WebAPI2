using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SightingsWebAPI2.DAL
{
    public class SightingDailyLog
    {
        public int Id { get; set; }

        public string Sighter { get; set; }
        public DateTime SightingDate { get; set; }

        // Navigation
        public virtual ICollection<ZooAnimalSighting> Sightings { get; set; }
    }
}

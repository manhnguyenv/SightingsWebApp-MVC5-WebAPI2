using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SightingsWebAPI2.Models
{
    public class DailyLogModel
    {
        public string Url { get; set; }
        public DateTime SightingDate { get; set; }
        public string Name { get; set; }
        public IEnumerable<ZooAnimalSightingModel> Sightings { get; set; } 
    }
}
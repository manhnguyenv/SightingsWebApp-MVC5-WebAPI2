using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SightingsWebAPI2.Models
{
    public class ZooAnimalSightingModel
    {
        public string Url { get; set; }

        public string Sighter { get; set; }
        public DateTime SightingDate { get; set; }
        public bool? IsSightingReliable { get; set; }

        // Navigation
        public virtual AnimalModel Animal { get; set; }
    }
}
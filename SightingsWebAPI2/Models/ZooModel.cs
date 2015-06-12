using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SightingsWebAPI2.Models
{
    public class ZooModel
    {
        public string Url { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string Zip { get; set; }
        public IEnumerable<AnimalModel> Animals { get; set; } 
    }
}
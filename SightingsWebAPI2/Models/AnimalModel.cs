using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SightingsWebAPI2.Models
{
    public class AnimalModel
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
        public string ZooUrl { get; set; }
    }
}
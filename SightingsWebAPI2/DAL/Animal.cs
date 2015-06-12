using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SightingsWebAPI2.DAL
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }

        public AnimalGroup Group { get; set; }

        // Navigation
        public virtual Zoo Zoo { get; set; }

    }
}

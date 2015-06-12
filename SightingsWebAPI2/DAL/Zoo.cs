using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SightingsWebAPI2.DAL
{
    public class Zoo
    {
        public Zoo()
        {
            Animals = new HashSet<Animal>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        // Navigation
        public virtual ICollection<Animal> Animals { get; set; }
    }
}

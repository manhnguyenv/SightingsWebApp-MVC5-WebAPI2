using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SightingsWebAPI2.DAL
{
    public class ZooSightingDemoDb : DbContext
    {
        public DbSet<Zoo> Zoos { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<ZooAnimalSighting> Sightings { get; set; }
        public DbSet<SightingDailyLog> DailyLogs { get; set; }

        public ZooSightingDemoDb()
            : base("SightingsConnection")
        {
            this.Configuration.LazyLoadingEnabled = false; 
        }

        public static ZooSightingDemoDb Create()
        {
            return new ZooSightingDemoDb();

        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
          //  modelBuilder.HasDefaultSchema("sightings");

            modelBuilder.Entity<Animal>().HasRequired(a => a.Zoo).WithMany(z => z.Animals);
            modelBuilder.Entity<SightingDailyLog>().HasMany(l => l.Sightings);
            modelBuilder.Entity<ZooAnimalSighting>().HasRequired(s => s.Animal);
        }

    }
}

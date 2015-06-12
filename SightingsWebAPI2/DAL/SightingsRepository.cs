using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SightingsWebAPI2.DAL
{
    public class SightingsRepository : ZooSightingDemoDb,  IRepository
    {
        public IQueryable<Zoo> GetAllZoos()
        {
            return this.Zoos;
        }

        public IQueryable<Zoo> GetAllZoosWithAnimals()
        {
            return this.Zoos
                .Include(z => z.Animals);
        }

        public Zoo Add(Zoo entity)
        {
            var item = this.Zoos.Add(entity);
            this.SaveChanges();
            return item;
        }

        public void Remove(Zoo entity)
        {
            this.Zoos.Remove(entity);
            this.SaveChanges();
        }

        public void RemoveZoo(int id)
        {
            var entity = (from z in this.Zoos
                          where z.Id == id
                          select z).Single();
            this.Zoos.Remove(entity);
            this.SaveChanges();
        }

        public async Task<Zoo> Update(Zoo entity)
        {
            this.Zoos.AddOrUpdate(entity);
            await this.SaveChangesAsync();
            return entity;
        }

        public IQueryable<Zoo> GetZoo()
        {
            throw new NotImplementedException();
        }

        public Zoo GetZoo(int id)
        {
            return this.Zoos
                .Include(z => z.Animals)
                .Single(z => z.Id == id);
        }

        public IQueryable<SightingDailyLog> GetDailyLogs(string userName)
        {
            return this.DailyLogs.Where(l => l.Sighter == userName);
        }

        public SightingDailyLog GetDailyLog(string userName, DateTime day)
        {
            var result = this.DailyLogs
                .OrderBy(l => l.SightingDate)
                .Include(l => l.Sightings)
                .Single(l => l.SightingDate == day);
            return result;
        }

        public ZooAnimalSighting GetDailyLogEntry(string userName, DateTime day, int id)
        {
            SightingDailyLog dailyLog = this.DailyLogs
                .Include(l => l.Sightings)
                .Single(l => l.SightingDate == day);

            ZooAnimalSighting sighting = dailyLog.Sightings.Single(s => s.Id == id);

            return sighting;
        }

        public SightingDailyLog Add(SightingDailyLog entity)
        {
            var item = this.DailyLogs.Add(entity);
            this.SaveChanges();
            return item;
        }

        public void Remove(SightingDailyLog entity)
        {
            this.DailyLogs.Remove(entity);
            this.SaveChanges();
        }

        public void RemoveDailyLog(int id)
        {
            var entity = (from z in this.DailyLogs
                          where z.Id == id
                          select z).Single();
            this.DailyLogs.Remove(entity);
            this.SaveChanges();
        }

        public async Task<SightingDailyLog> Update(SightingDailyLog entity)
        {
            this.DailyLogs.AddOrUpdate(entity);
            await this.SaveChangesAsync();
            return entity;
        }

        public IQueryable<SightingDailyLog> GetDailyLog()
        {
            throw new NotImplementedException();
        }

        public SightingDailyLog GetDailyLog(int id)
        {
            return this.DailyLogs
                //  .Include(d => d.)
                .Single(z => z.Id == id);
        }

        public IQueryable<Animal> GetAnimalsForZoo(int zooId)
        {
            IQueryable<Animal> entities = this.Animals
                .OrderBy(a => a.Name)
                .Include(a => a.Zoo)
                .Where(a => a.Zoo.Id == zooId);

            return entities;
        }

        public Animal Add(Animal entity)
        {
            var item = this.Animals.Add(entity);
            this.SaveChanges();
            return item;
        }

        public void Remove(Animal entity)
        {
            this.Animals.Remove(entity);
            this.SaveChanges();
        }

        public async void RemoveAnimal(int id)
        {
            var entity = (from z in this.Animals
                          where z.Id == id
                          select z).Single();
            this.Animals.Remove(entity);
            await this.SaveChangesAsync();
        }

        public async Task<Animal> Update(Animal entity)
        {
            this.Animals.AddOrUpdate(entity);
            await this.SaveChangesAsync();
            return entity;
        }

        public IQueryable<Animal> GetAnimal()
        {
            return this.Animals;
        }

        public Animal GetAnimal(int id)
        {
            return this.Animals.Include(a => a.Zoo)
                .Single(a => a.Id == id);
        }

        public void SaveAll()
        {
            base.SaveChanges();
        }


    }
}
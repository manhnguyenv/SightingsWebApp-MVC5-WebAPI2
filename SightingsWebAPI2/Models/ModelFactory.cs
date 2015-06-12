using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Web;
using System.Web.Http.Routing;
using SightingsWebAPI2.DAL;

namespace SightingsWebAPI2.Models
{
    public class ModelFactory
    {
        private readonly UrlHelper _urlHelper;
        private readonly IRepository _repository;
       

        public ModelFactory(HttpRequestMessage request, IRepository repo)
        {
            _urlHelper = new UrlHelper(request);
            _repository = repo;
        }

        public ZooModel Create(Zoo z)
        {
            return new ZooModel()
            {
                Url = _urlHelper.Link("Zoos", new {zooId = z.Id}),
                Name = z.Name,
                City = z.City,
                Animals = z.Animals.Select(a => Create(a))
            };
        }

        public AnimalModel Create(Animal a)
        {
            return new AnimalModel()
            {
                Url = _urlHelper.Link("Animals", new {zooid = a.Zoo.Id, id = a.Id}),
                Name = a.Name,
                Weight = a.Weight
            };
        }

        public DailyLogModel Create(SightingDailyLog a)
        {
            return new DailyLogModel()
            {
                Url = _urlHelper.Link("DailyLogs", new {dailylogid = a.SightingDate.ToString("yyyy-MM-dd")}),
                Name = a.Sighter,
                SightingDate = a.SightingDate
            };
        }

        public ZooAnimalSightingModel Create(ZooAnimalSighting s)
        {
            return new ZooAnimalSightingModel()
            {
                Url = _urlHelper.Link("Sightings", new {dailylogid = s.SightingDate.ToString("yyyy-MM-dd"), id = s.Id}),
                Sighter = s.Sighter,
                SightingDate = s.SightingDate
            };
        }

        public ZooAnimalSighting Parse(ZooAnimalSightingModel model)
        {
        //    try
          //  {
                var entry = new ZooAnimalSighting();
                if (model.IsSightingReliable != default(bool))
                {
                    entry.IsSightingReliable = model.IsSightingReliable;
                }
                if (model.Sighter.Length > 0)
                {
                    entry.Sighter = model.Sighter;
                }
                if (model.SightingDate != default(DateTime))
                {
                    entry.SightingDate = model.SightingDate;
                }
                var uri = new Uri(model.Animal.Url);
                var animalId = int.Parse(uri.Segments.Last());
                var animal = _repository.GetAnimal(animalId);

                entry.Animal = animal;

                return entry;
           // }
           // catch
           // {
           //     return null;
           // }
        }
    }
}

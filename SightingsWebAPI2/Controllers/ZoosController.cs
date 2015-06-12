using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SightingsWebAPI2.DAL;
using SightingsWebAPI2.Models;

namespace SightingsWebAPI2.Controllers
{
    public class ZoosController : BaseApiController
    {
        public ZoosController(IRepository repo)
            : base(repo)
        {
        }

        // GET: /api/sightings/zoos
        public IEnumerable<ZooModel> Get(bool includeAnimals = true)
        {
            IQueryable<Zoo> query;
            if (includeAnimals)
            {
                query = TheSightingsRepository.GetAllZoosWithAnimals();
            }
            else
            {
                query = TheSightingsRepository.GetAllZoos();
            }
            var results = query
                .OrderBy(z => z.City)
                .Take(25)
                .ToList()
                .Select(z => TheModelFactory.Create(z));

            return results;
        }
    }
}

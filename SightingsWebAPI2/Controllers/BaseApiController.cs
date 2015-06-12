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
    public abstract class BaseApiController : ApiController
    {
        private readonly IRepository _repository;

        private ModelFactory _modelFactory;

        protected BaseApiController(IRepository repository)
        {
            _repository = repository;
        }

        protected IRepository TheSightingsRepository
        {
            get { return _repository; }
        }

        protected ModelFactory TheModelFactory
        {
            get { return _modelFactory ?? (_modelFactory = new ModelFactory(this.Request, TheSightingsRepository)); }
        }
    }
}

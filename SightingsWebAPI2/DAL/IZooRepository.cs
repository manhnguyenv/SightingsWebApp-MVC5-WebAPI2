using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SightingsWebAPI2.DAL
{

    public interface IZooRepository : IBaseRepository<Zoo>
    {
        IQueryable<Zoo> GetAllZoos();
        IQueryable<Zoo> GetAllZoosWithAnimals();

        void RemoveZoo(int id);
        IQueryable<Zoo> GetZoo();
        Zoo GetZoo(int id);
    }


}

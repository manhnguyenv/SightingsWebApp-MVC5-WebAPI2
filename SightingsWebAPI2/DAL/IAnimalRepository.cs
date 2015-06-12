using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SightingsWebAPI2.DAL
{
    public interface IAnimalRepository : IBaseRepository<Animal>
    {
        IQueryable<Animal> GetAnimalsForZoo(int zooId);
        void RemoveAnimal(int id);
        IQueryable<Animal> GetAnimal();
        Animal GetAnimal(int id);
    }
}

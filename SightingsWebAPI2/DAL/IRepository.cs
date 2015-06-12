using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SightingsWebAPI2.DAL
{
    public interface IRepository : IZooRepository, IAnimalRepository, IDailyLogsRepository
    {
        void SaveAll();
    }
}

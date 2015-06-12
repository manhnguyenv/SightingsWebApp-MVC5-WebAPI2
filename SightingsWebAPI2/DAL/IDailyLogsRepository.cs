using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SightingsWebAPI2.DAL
{
    public interface IDailyLogsRepository : IBaseRepository<SightingDailyLog>
    {
        IQueryable<SightingDailyLog> GetDailyLogs(string userName);
        SightingDailyLog GetDailyLog(string userName, DateTime day);
        ZooAnimalSighting GetDailyLogEntry(string userName, DateTime day, int id);

        void RemoveDailyLog(int id);
        IQueryable<SightingDailyLog> GetDailyLog();
        SightingDailyLog GetDailyLog(int id);
    }
}

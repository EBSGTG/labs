using Labs.EF;
using Labs.Entities;
using Labs.Repositories.Interfaces;

namespace Labs.Repositories.Impl
{
    public class StatisticsRepository : BaseRepository<Statistics>, IStatisticsRepository
    {
        internal StatisticsRepository(SensorContext context) : base(context)
        {
        }
    }
}
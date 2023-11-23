using Labs.EF;
using Labs.Entities;
using Labs.Repositories.Interfaces;

namespace Labs.Repositories.Impl
{
    public class ScheduleRepository : BaseRepository<Schedule>, IScheduleRepository
    {
        internal ScheduleRepository(SensorContext context) : base(context)
        {
        }
    }
}
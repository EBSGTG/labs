using Labs.EF;
using Labs.Entities;
using Labs.Repositories.Interfaces;

namespace Labs.Repositories.Impl
{
    public class AlarmSystemRepository : BaseRepository<AlarmSystem>, IAlarmSystemRepository
    {
        internal AlarmSystemRepository(SensorContext context)
            : base(context)
        {
        }
    }
}
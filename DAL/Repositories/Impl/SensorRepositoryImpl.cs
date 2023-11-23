using Labs.EF;
using Labs.Entities;
using Labs.Repositories.Interfaces;

namespace Labs.Repositories.Impl
{
    public class SensorRepository : BaseRepository<Sensor>, ISensorRepository
    {
        internal SensorRepository(SensorContext context) : base(context)
        {
        }
    }
}
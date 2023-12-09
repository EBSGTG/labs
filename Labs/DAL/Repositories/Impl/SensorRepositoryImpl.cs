using Labs.EF;
using Labs.Entities;
using Labs.Repositories.Interfaces;

namespace Labs.Repositories.Impl
{
    public class SensorRepository : BaseRepository<Sensor>, ISensorRepository
    {
        private ISensorRepository _sensorRepositoryImplementation;

        internal SensorRepository(SensorContext context) : base(context)
        {
        }

        public object Find(Func<Sensor, bool> predicate, int pageNumber, int pageSize)
        {
            return _sensorRepositoryImplementation.Find(predicate, pageNumber, pageSize);
        }
    }
}
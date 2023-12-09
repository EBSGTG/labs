using Labs.EF;
using Labs.Entities;
using Labs.Repositories.Interfaces;

namespace Labs.Repositories.Impl
{
    public class MeasurementHistoryRepository : BaseRepository<MeasurementHistory>, IMeasurementHistoryRepository
    {
        internal MeasurementHistoryRepository(SensorContext context) : base(context)
        {
        }
    }
}
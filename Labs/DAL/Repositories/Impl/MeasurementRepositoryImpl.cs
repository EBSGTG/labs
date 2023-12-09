using Labs.EF;
using Labs.Entities;
using Labs.Repositories.Interfaces;

namespace Labs.Repositories.Impl
{
    public class MeasurementRepository : BaseRepository<Measurement>, IMeasurementRepository
    {
        internal MeasurementRepository(SensorContext context) : base(context)
        {
        }
    }
}
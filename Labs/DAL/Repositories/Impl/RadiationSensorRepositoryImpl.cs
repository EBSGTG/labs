using Labs.EF;
using Labs.Entities;
using Labs.Repositories.Interfaces;

namespace Labs.Repositories.Impl
{
    public class RadiationSensorRepository : BaseRepository<RadiationSensor>, IRadiationSensorRepository
    {
        internal RadiationSensorRepository(SensorContext context) : base(context)
        {
        }
    }
}
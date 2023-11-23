using Labs.EF;
using Labs.Entities;
using Labs.Repositories.Interfaces;

namespace Labs.Repositories.Impl
{
    public class AirQualitySensorRepository : BaseRepository<AirQualitySensor>, IAirQualitySensorRepository
    {
        internal AirQualitySensorRepository(SensorContext context)
            : base(context)
        {
        }
    }
}
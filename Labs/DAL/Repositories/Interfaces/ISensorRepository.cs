using Labs.Entities;

namespace Labs.Repositories.Interfaces;

public interface ISensorRepository : IRepository<Sensor>
{
    object Find(Func<Sensor, bool> predicate, int pageNumber, int pageSize);
}
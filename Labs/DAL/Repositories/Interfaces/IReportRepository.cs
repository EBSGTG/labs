using Labs.Entities;

namespace Labs.Repositories.Interfaces;

public interface IReportRepository : IRepository<Report>
{
    object Find(Func<Report, bool> predicate, int pageNumber, int pageSize);
}
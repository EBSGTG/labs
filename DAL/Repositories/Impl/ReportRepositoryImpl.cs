using Labs.EF;
using Labs.Entities;
using Labs.Repositories.Interfaces;

namespace Labs.Repositories.Impl
{
    public class ReportRepository : BaseRepository<Report>, IReportRepository
    {
        internal ReportRepository(SensorContext context) : base(context)
        {
        }
    }
}
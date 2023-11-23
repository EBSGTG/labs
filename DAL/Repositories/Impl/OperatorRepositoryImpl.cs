using Labs.EF;
using Labs.Entities;
using Labs.Repositories.Interfaces;

namespace Labs.Repositories.Impl
{
    public class OperatorRepository : BaseRepository<Operator>, IOperatorRepository
    {
        internal OperatorRepository(SensorContext context) : base(context)
        {
        }
    }
}
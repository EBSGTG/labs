using AutoMapper;
using Labs.BLL.DTO;
using Labs.BLL.Services.Interfaces;
using Labs.CLL.CLL.Security;
using Labs.CLL.CLL.Security.Identity;
using Labs.Entities;
using Labs.UnitOfWork;
using Operator = Labs.CLL.CLL.Security.Identity.Operator;


namespace Labs.BLL.Services.Impl
{


     public class ReportService 
        : IReportService
    {
        private IUnitOfWork _database;

        private int pageSize = 10;

        public ReportService(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            _database = unitOfWork;
        }


        /// <exception cref="MethodAccessException"></exception>
        public IEnumerable<ReportDTO> GetReports(int pageNumber)
        {
            var user = SecurityContext.GetUser();
            var userType = user.GetType();
            if (userType != typeof(Operator))
            {
                throw new MethodAccessException();
            }
            var userId = user.UserId;
            var reportsEntities = (IEnumerable<Report>)_database.Reports
                .Find(z => z.UserID == userId, pageNumber, pageSize); 
            var mapper = 
                new MapperConfiguration(
                    cfg => cfg.CreateMap<Report, ReportDTO>()
                    ).CreateMapper();
            var reportsDto = mapper.Map<IEnumerable<Report>, List<ReportDTO>>(reportsEntities);
            return reportsDto;
        }

        public  void AddReport(ReportDTO report)
        {
            var user = SecurityContext.GetUser();
            var userType = user.GetType();
            if (userType != typeof(Operator))
            {
                throw new MethodAccessException();
            }
            if (report == null)
            {
                throw new ArgumentNullException(nameof(report));
            }
            

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ReportDTO, Report>()).CreateMapper();
            var reportEntity = mapper.Map<ReportDTO, Report>(report);
            _database.Reports.Create(reportEntity);
            
        }


       
    }
}
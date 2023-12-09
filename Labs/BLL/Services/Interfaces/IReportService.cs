using Labs.BLL.DTO;

namespace Labs.BLL.Services.Interfaces
{
    public interface IReportService
    {
        IEnumerable<ReportDTO> GetReports(int page);
       
    }
    
    
}
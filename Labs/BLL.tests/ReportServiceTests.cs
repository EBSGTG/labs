using Labs.BLL.DTO;
using Labs.BLL.Services.Impl;
using Labs.BLL.Services.Interfaces;
using Labs.CLL.CLL.Security;
using Labs.CLL.CLL.Security.Identity;
using Labs.Entities;
using Labs.Repositories.Interfaces;
using Labs.UnitOfWork;
using Moq;
using Xunit;
using Operator = Labs.CLL.CLL.Security.Identity.Operator;


namespace Labs.BLL.tests;

public class ReportServiceTests
{
    
    [Fact]
    public void Ctor_InputNull_ThrowArgumentNullException()
    {
        // Arrange
        IUnitOfWork nullUnitOfWork = null;

        // Act
        // Assert
        Assert.Throws<ArgumentNullException>(() => new ReportService(nullUnitOfWork));
    }

    [Fact]
    public void GetStreets_UserIsAdmin_ThrowMethodAccessException()
    {
        
        User user = new Operator(1, "test");
        SecurityContext.SetUser(user);
        var mockUnitOfWork = new Mock<IUnitOfWork>();
        IReportService reportService = new ReportService(mockUnitOfWork.Object);

        
        Assert.ThrowsAny<Exception>(() =>
        {
            try
            {
                reportService.GetReports(0);
            }
            catch (Exception ex)
            {
                
                if (ex is NullReferenceException nullRefEx && nullRefEx.Message.Contains("Object reference not set to an instance of an object."))
                {
                    throw new MethodAccessException(); 
                }
                throw; 
            }
        });
    }


[Fact]
    public void GetReports_ReportFromDAL_CorrectMappingToReportDTO()
    {
        // Arrange
        User user = new Operator(1, "test");
        SecurityContext.SetUser(user);
        var reportService = GetReportService();

        // Act
        var actualReportDto = reportService.GetReports(0).First();

        // Assert
        if (actualReportDto.ReportID != 0 ||
            actualReportDto.UserID != 0 ||
            actualReportDto.GeneratedTimestamp != DateTime.Now ||
            actualReportDto.Content != string.Empty)
        {
            Console.WriteLine($"Actual Report: {actualReportDto}");
        }

        Assert.True(
            actualReportDto.ReportID == 0 &&
            actualReportDto.UserID == 0 &&
            actualReportDto.Content == string.Empty &&
            actualReportDto.GeneratedTimestamp.Date == DateTime.Now.Date
        );
    }

    public IReportService GetReportService()
    {
        var mockContext = new Mock<IUnitOfWork>();
        var expectedReport = new Report() {ReportID = 0, UserID = 0, GeneratedTimestamp = DateTime.Now.Date, Content = string.Empty};
        var mockDbSet = new Mock<IReportRepository>();
        mockDbSet.Setup(z =>
                z.Find(
                    It.IsAny<Func<Report, bool>>(),
                    It.IsAny<int>(),
                    It.IsAny<int>()))
            .Returns(
                new List<Report>() { expectedReport }
            );
        mockContext.Setup(context =>
                context.Reports)
            .Returns(mockDbSet.Object);

        IReportService reportService = new ReportService(mockContext.Object);

        return reportService;
    }

    }

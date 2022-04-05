namespace WebApplication2.Controllers
{
    public interface IReportService {
        Task<string[]> GetReports();
        Task<string[]> HandleReports(DateTime from, DateTime to);
    }

}

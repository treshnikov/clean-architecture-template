namespace WebApplication2.Controllers
{
    public interface IReportService {
        Task<string[]> Get();
        Task<string[]> GetBetween(DateTime from, DateTime to);
    }

}

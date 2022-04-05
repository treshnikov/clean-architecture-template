namespace WebApplication2.Controllers
{
    public class ReportService : IReportService
    {
        private readonly IDbContext dbContext;

        public ReportService(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<string[]> GetReports()
        {
            return Task.FromResult(new string[] { "report #1", "report #2" });
        }

        public Task<string[]> HandleReports(DateTime from, DateTime to)
        {
            return Task.FromResult(new string[] { "report #1", "report #2" });

        }
    }

}

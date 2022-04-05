using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    /// <summary>
    /// Controller demonstrates approach when business logic is concentrated in commands and queries that implement the CQRS pattern approach
    /// </summary>
    [Route("api/[controller]")]
    public class ReportsController : Controller
    {
        private readonly IReportService reportService;

        public ReportsController(IReportService reportService)
        {
            this.reportService = reportService;
        }

        // curl -X GET http://localhost:5075/api/reports
        [HttpGet]
        public async Task<ActionResult<string[]>> GetReports()
        {
            return Ok(await reportService.Get());
        }

        // curl -X GET http://localhost:5075/api/reports/2022-01-01/2022-02-02
        [HttpGet("{start}/{end}")]
        public async Task<ActionResult<string[]>> HandleReports(DateTime start, DateTime end)
        {
            if (!ModelState.IsValid)
            {
                throw new InvalidOperationException();
            }

            return Ok(await reportService.GetBetween(start, end));
        }
    }

}

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

        [HttpGet]
        public async Task<ActionResult<string[]>> GetReports()
        {
            return Ok(await reportService.GetReports());
        }

        [HttpPost]
        public async Task<ActionResult<string[]>> HandleReports(HandleReportsRequest request)
        {
            if (!ModelState.IsValid)
            {
                throw new InvalidOperationException();
            }

            return Ok(await reportService.HandleReports(request.From, request.To));
        }
    }

}

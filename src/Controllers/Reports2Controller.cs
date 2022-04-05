using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    /// <summary>
    /// Controller demonstrates a "service-based" approach when all business logic is located in some classes that implement service contracts 
    /// </summary>
    [Route("api/[controller]")]
    public class Reports2Controller : Controller
    {
        private readonly IMediator mediator;

        public Reports2Controller(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<string[]>> GetAllReports()
        {
            var request = new GetAllReportsRequest();
            var result = await mediator.Send(request);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<string[]>> SelectReportsByRule(HandleReportsRequest request)
        {
            var result = await mediator.Send(request);
            return Ok(result);
        }
    }
}

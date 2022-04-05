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

        // curl -X GET http://localhost:5075/api/reports2
        [HttpGet]
        public async Task<ActionResult<string[]>> Get()
        {
            var request = new GetAllReportsRequest();
            var result = await mediator.Send(request);
            return Ok(result);
        }

        // curl -X GET http://localhost:5075/api/reports2/2022-01-01/2022-02-02
        [HttpGet("{start}/{end}")]
        public async Task<ActionResult<string[]>> GetBetween(DateTime start, DateTime end)
        {
            var request = new GetReportsBetweenRequest(start, end);
            var result = await mediator.Send(request);
            return Ok(result);
        }
    }
}

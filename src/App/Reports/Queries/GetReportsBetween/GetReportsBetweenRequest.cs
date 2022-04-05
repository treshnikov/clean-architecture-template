using MediatR;

namespace WebApplication2.Controllers
{
    public class GetReportsBetweenRequest : IRequest<string[]>
    {
        public DateTime From { get; }
        public DateTime To { get; }

        public GetReportsBetweenRequest(DateTime from, DateTime to)
        {
            From = from;
            To = to;
        }

    }
}

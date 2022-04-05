using MediatR;

namespace WebApplication2.Controllers
{
    public class HandleReportsRequest : IRequest<string[]>
    {
        public DateTime From { get; }
        public DateTime To { get; }

        public HandleReportsRequest(DateTime from, DateTime to)
        {
            From = from;
            To = to;
        }

    }
}

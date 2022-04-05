using MediatR;

namespace WebApplication2.Controllers
{
    public class HandleReportsRequest : IRequest<string[]>
    {
        public DateTime From { get; }
        public DateTime To { get; }

        public HandleReportsRequest()
        {

        }

        public HandleReportsRequest(DateTime utcNow1, DateTime utcNow2)
        {
            From = utcNow1;
            To = utcNow2;
        }

    }
}

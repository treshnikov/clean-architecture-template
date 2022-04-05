using MediatR;

namespace WebApplication2.Controllers
{
    public class GetAllReportsRequest : IRequest<string[]>
    {
        public GetAllReportsRequest()
        {

        }
    }
}

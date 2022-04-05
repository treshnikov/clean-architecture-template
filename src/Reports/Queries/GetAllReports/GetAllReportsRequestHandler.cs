using MediatR;

namespace WebApplication2.Controllers
{
    internal class GetAllReportsRequestHandler : IRequestHandler<GetAllReportsRequest, string[]>
    {
        private readonly IDbContext dbContext;

        public GetAllReportsRequestHandler(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<string[]> Handle(GetAllReportsRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new string[] { "report #1", "report #2" });
        }
    }
}

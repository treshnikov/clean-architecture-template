using MediatR;

namespace WebApplication2.Controllers
{
    internal class GetReportsBetweenHandler : IRequestHandler<GetReportsBetweenRequest, string[]>
    {
        private readonly IDbContext dbContext;

        public GetReportsBetweenHandler(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<string[]> Handle(GetReportsBetweenRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new string[] { "report #1", "report #2" });
        }
    }
}

using MediatR;

namespace WebApplication2.Controllers
{
    internal class HandleReportsRequestHandler : IRequestHandler<HandleReportsRequest, string[]>
    {
        private readonly IDbContext dbContext;

        public HandleReportsRequestHandler(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<string[]> Handle(HandleReportsRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new string[] { "report #1", "report #2" });
        }
    }
}

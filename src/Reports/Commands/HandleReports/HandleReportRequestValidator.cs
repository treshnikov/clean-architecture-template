using FluentValidation;

namespace WebApplication2.Controllers
{
    public class HandleReportRequestValidator : AbstractValidator<HandleReportsRequest>
    {
        public HandleReportRequestValidator()
        {
            RuleFor(i => i.From).GreaterThanOrEqualTo(DateTime.UtcNow);
            RuleFor(i => i.To).GreaterThanOrEqualTo(DateTime.UtcNow);
        }
    }
}

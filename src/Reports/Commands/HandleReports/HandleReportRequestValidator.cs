using FluentValidation;

namespace WebApplication2.Controllers
{
    public class HandleReportRequestValidator : AbstractValidator<HandleReportsRequest>
    {
        public HandleReportRequestValidator()
        {
            RuleFor(i => i.From).GreaterThanOrEqualTo(new DateTime(1970, 01, 01));
            RuleFor(i => i.To).GreaterThanOrEqualTo(new DateTime(1970, 01, 01));
        }
    }
}

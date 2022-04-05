using FluentValidation;

namespace WebApplication2.Controllers
{
    public class GetReportsBetweenRequestValidator : AbstractValidator<GetReportsBetweenRequest>
    {
        public GetReportsBetweenRequestValidator()
        {
            RuleFor(i => i.From).GreaterThanOrEqualTo(new DateTime(1970, 01, 01));
            RuleFor(i => i.To).GreaterThanOrEqualTo(new DateTime(1970, 01, 01));
        }
    }
}

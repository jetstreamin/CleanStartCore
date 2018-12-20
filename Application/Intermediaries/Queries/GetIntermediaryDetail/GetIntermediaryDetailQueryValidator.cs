using FluentValidation;

namespace Application.Intermediaries.Queries.GetIntermediaryDetail
{
    public class GetIntermediaryDetailQueryValidator : AbstractValidator<GetIntermediaryDetailQuery>
    {
        public GetIntermediaryDetailQueryValidator()
        {
            RuleFor(v => v.Id).NotEmpty().Length(5);
        }
    }
}

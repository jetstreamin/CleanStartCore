using FluentValidation;
using FluentValidation.Validators;

namespace Application.Intermediaries.Commands.UpdateIntermediary
{
    public class UpdateIntermediaryCommandValidator : AbstractValidator<UpdateIntermediaryCommand>
    {

        public UpdateIntermediaryCommandValidator()
        {
            RuleFor(x => x.Id).MaximumLength(5).NotEmpty();
            RuleFor(x => x.Address).MaximumLength(60);
            RuleFor(x => x.City).MaximumLength(15);
            RuleFor(x => x.Name).MaximumLength(40).NotEmpty();
            RuleFor(x => x.ContactName).MaximumLength(30);
            RuleFor(x => x.ContactTitle).MaximumLength(30);
            RuleFor(x => x.Country).MaximumLength(15);
            RuleFor(x => x.Fax).MaximumLength(24).NotEmpty();
            RuleFor(x => x.Phone).MaximumLength(24).NotEmpty();
            RuleFor(x => x.PostalCode).MaximumLength(10);
            RuleFor(x => x.Region).MaximumLength(15);

            RuleFor(c => c.Phone)
                .Must(HasUSPhoneLine)
                .When(c => c.Country == "United States")
                .WithMessage("Intermediaries in the US are required have a phone or fax number beginning with +1 for the Country Code.");
        }

        private static bool HasUSPhoneLine(UpdateIntermediaryCommand model, string phoneValue, PropertyValidatorContext ctx)
        {
            return model.Phone.StartsWith("1") || model.Fax.StartsWith("1");
        }

    }
}

using FluentValidation;

namespace Recruiter.Application.DTOs.Candidates.Validators;

public class ICandidateDtoValidator : AbstractValidator<ICandidateDto>
{
    public ICandidateDtoValidator()
    {
        RuleFor(c => c.Name).NotEmpty().WithMessage("{PropertyName} is required  ");
    }
}
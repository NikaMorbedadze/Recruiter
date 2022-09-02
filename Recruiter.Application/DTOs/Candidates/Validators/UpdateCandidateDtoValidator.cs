using FluentValidation;
using Microsoft.Win32.SafeHandles;

namespace Recruiter.Application.DTOs.Candidates.Validators;

public class UpdateCandidateDtoValidator : AbstractValidator<CandidateDto>
{
    public UpdateCandidateDtoValidator()
    {
        Include(new ICandidateDtoValidator());
        RuleFor(c => c.Id).NotNull().WithMessage("{PropertyName} must be present");
    }
}
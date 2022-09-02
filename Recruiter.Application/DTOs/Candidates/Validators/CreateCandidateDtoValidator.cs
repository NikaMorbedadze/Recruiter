using FluentValidation;

namespace Recruiter.Application.DTOs.Candidates.Validators;

public class CreateCandidateDtoValidator : AbstractValidator<CreateCandidateDto>
{
    public CreateCandidateDtoValidator()
    {
        Include(new ICandidateDtoValidator());
    }
}
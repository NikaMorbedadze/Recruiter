using MediatR;
using Recruiter.Application.DTOs.Candidates;

namespace Recruiter.Application.Features.Candidates.Requests.Commands;

public class UpdateCandidateCommand : IRequest<Unit>
{
    public CandidateDto CandidateDto { get; set; }
}
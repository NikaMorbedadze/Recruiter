using MediatR;
using Recruiter.Application.DTOs.Candidates;

namespace Recruiter.Application.Features.Candidates.Requests.Commands;

public class CreateCandidateCommand : IRequest<int>
{
    public CandidateDto? CandidateDto { get; set; }
}
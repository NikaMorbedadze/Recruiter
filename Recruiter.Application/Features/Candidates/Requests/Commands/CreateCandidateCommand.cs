using MediatR;
using Recruiter.Application.DTOs.Candidates;
using Recruiter.Application.Responses;

namespace Recruiter.Application.Features.Candidates.Requests.Commands;

public class CreateCandidateCommand : IRequest<BaseCommandResponses>
{
    public CreateCandidateDto? CandidateDto { get; set; }
}
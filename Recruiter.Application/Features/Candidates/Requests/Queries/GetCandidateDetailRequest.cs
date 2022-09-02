using MediatR;
using Recruiter.Application.DTOs.Candidates;

namespace Recruiter.Application.Features.Candidates.Requests.Queries;

public class GetCandidateDetailRequest : IRequest<CandidateDto>
{
    public int Id { get; set; }
}
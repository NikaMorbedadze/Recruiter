using MediatR;
using Recruiter.Application.DTOs.Candidate;

namespace Recruiter.Application.Features.Candidate.Requests.Queries;

public class GetCandidateDetailRequest : IRequest<CandidateDto>
{
    public int Id { get; set; }
}
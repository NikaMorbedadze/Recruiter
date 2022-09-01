using MediatR;
using Recruiter.Application.DTOs.Candidate;

namespace Recruiter.Application.Features.Candidate.Requests.Queries;

public class GetCandidateListRequest : IRequest<List<CandidateDto>>
{
}
using MediatR;
using Recruiter.Application.DTOs.Candidates;

namespace Recruiter.Application.Features.Candidates.Requests.Queries;

public class GetCandidateListRequest : IRequest<List<CandidateDto>>
{
}
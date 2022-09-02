using MediatR;

namespace Recruiter.Application.Features.Candidates.Requests.Commands;

public class DeleteCandidateCommand : IRequest
{
    public int Id { get; set; }
}
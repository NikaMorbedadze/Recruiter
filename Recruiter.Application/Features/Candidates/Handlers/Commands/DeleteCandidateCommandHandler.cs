using AutoMapper;
using MediatR;
using Recruiter.Application.Contracts.Persistence;
using Recruiter.Application.Features.Candidates.Requests.Commands;

namespace Recruiter.Application.Features.Candidates.Handlers.Commands;

public class DeleteCandidateCommandHandler : IRequestHandler<DeleteCandidateCommand>
{
    private readonly ICandidateRepository _candidateRepository;
    private readonly IMapper _mapper;

    public DeleteCandidateCommandHandler(ICandidateRepository candidateRepository, IMapper mapper)
    {
        _candidateRepository = candidateRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(DeleteCandidateCommand request, CancellationToken cancellationToken)
    {
        var candidate = await _candidateRepository.Get(request.Id);
        await _candidateRepository.Delete(candidate);
        return Unit.Value;
    }
}
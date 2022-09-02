using AutoMapper;
using MediatR;
using Recruiter.Application.Contracts.Persistence;
using Recruiter.Application.Features.Candidates.Requests.Commands;
using Recruiter.Domain;

namespace Recruiter.Application.Features.Candidates.Handlers.Commands;

public class CreateCandidateCommandHandler : IRequestHandler<CreateCandidateCommand, int>
{
    private readonly ICandidateRepository _candidateRepository;
    private readonly IMapper _mapper;

    public CreateCandidateCommandHandler(ICandidateRepository candidateRepository, IMapper mapper)
    {
        _candidateRepository = candidateRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateCandidateCommand request, CancellationToken cancellationToken)
    {
        var candidate = _mapper.Map<Candidate>(request.CandidateDto);
        candidate = await _candidateRepository.Add(candidate);
        return candidate.Id;
    }
}
using AutoMapper;
using MediatR;
using Recruiter.Application.Contracts.Persistence;
using Recruiter.Application.Features.Candidates.Requests.Commands;

namespace Recruiter.Application.Features.Candidates.Handlers.Commands;

public class UpdateCandidateCommandHandler : IRequestHandler<UpdateCandidateCommand, Unit>
{
    private readonly ICandidateRepository _candidateRepository;
    private readonly IMapper _mapper;

    public UpdateCandidateCommandHandler(ICandidateRepository candidateRepository, IMapper mapper)
    {
        _candidateRepository = candidateRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateCandidateCommand request, CancellationToken cancellationToken)
    {
        var candidate = await _candidateRepository.Get(request.CandidateDto.Id);
        _mapper.Map(request.CandidateDto, candidate);
        await _candidateRepository.Update(candidate);
        return Unit.Value;
    }
}
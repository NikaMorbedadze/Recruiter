using AutoMapper;
using MediatR;
using Recruiter.Application.Contracts.Persistence;
using Recruiter.Application.DTOs.Candidate;
using Recruiter.Application.Features.Candidate.Requests.Queries;

namespace Recruiter.Application.Features.Candidate.Handlers.Queries;

public class GetCandidateDetailRequestHandler : IRequestHandler<GetCandidateDetailRequest, CandidateDto>
{
    private readonly ICandidateRepository _candidateRepository;
    private readonly IMapper _mapper;

    public GetCandidateDetailRequestHandler(ICandidateRepository candidateRepository, IMapper mapper)
    {
        _candidateRepository = candidateRepository;
        _mapper = mapper;
    }

    public async Task<CandidateDto> Handle(GetCandidateDetailRequest request, CancellationToken cancellationToken)
    {
        var candidate = await _candidateRepository.Get(request.Id);
        return _mapper.Map<CandidateDto>(candidate);
    }
}
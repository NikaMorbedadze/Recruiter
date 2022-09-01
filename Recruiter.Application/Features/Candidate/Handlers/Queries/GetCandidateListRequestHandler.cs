﻿using AutoMapper;
using MediatR;
using Recruiter.Application.Contracts.Persistence;
using Recruiter.Application.DTOs.Candidate;
using Recruiter.Application.Features.Candidate.Requests.Queries;

namespace Recruiter.Application.Features.Candidate.Handlers.Queries;

public class GetCandidateListRequestHandler : IRequestHandler<GetCandidateListRequest, List<CandidateDto>>
{
    private readonly ICandidateRepository _candidateRepository;
    private readonly IMapper _mapper;

    public GetCandidateListRequestHandler(ICandidateRepository candidateRepository, IMapper mapper)
    {
        _candidateRepository = candidateRepository;
        _mapper = mapper;
    }

    public async Task<List<CandidateDto>> Handle(GetCandidateListRequest request, CancellationToken cancellationToken)
    {
        var candidate = await _candidateRepository.GetAll();
        return _mapper.Map<List<CandidateDto>>(candidate);
    }
}
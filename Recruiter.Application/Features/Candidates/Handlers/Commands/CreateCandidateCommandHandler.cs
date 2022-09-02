using AutoMapper;
using MediatR;
using Recruiter.Application.Contracts.Persistence;
using Recruiter.Application.DTOs.Candidates.Validators;
using Recruiter.Application.Exceptions;
using Recruiter.Application.Features.Candidates.Requests.Commands;
using Recruiter.Application.Responses;
using Recruiter.Domain;

namespace Recruiter.Application.Features.Candidates.Handlers.Commands;

public class CreateCandidateCommandHandler : IRequestHandler<CreateCandidateCommand, BaseCommandResponses>
{
    private readonly ICandidateRepository _candidateRepository;
    private readonly IMapper _mapper;

    public CreateCandidateCommandHandler(ICandidateRepository candidateRepository, IMapper mapper)
    {
        _candidateRepository = candidateRepository;
        _mapper = mapper;
    }

    public async Task<BaseCommandResponses> Handle(CreateCandidateCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateCandidateDtoValidator();
        var response = new BaseCommandResponses();
        var validationResult = await validator.ValidateAsync(request.CandidateDto);

        if (!validationResult.IsValid)
        {
            response.Success = false;
            response.Message = "Creation Failed";
            response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
        }

        var candidate = _mapper.Map<Candidate>(request.CandidateDto);
        candidate = await _candidateRepository.Add(candidate);

        response.Success = true;
        response.Message = "Creation Successful";
        response.Id = candidate.Id;
        return response;
    }
}
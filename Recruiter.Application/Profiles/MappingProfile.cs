using AutoMapper;
using Recruiter.Application.DTOs.Candidates;
using Recruiter.Domain;

namespace Recruiter.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Candidate, CandidateDto>().ReverseMap();
    }
}
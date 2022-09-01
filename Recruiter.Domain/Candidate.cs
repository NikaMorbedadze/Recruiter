using Recruiter.Domain.Common;

namespace Recruiter.Domain;

public class Candidate : BaseDomainEntity
{
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? CurrentPosition { get; set; }
    public string? ExpectedSalary { get; set; }
    public string? YearExperience { get; set; }
    public string? LinkedIn { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? CurrentLocation { get; set; }
    public string? CurrentCompany { get; set; }
    public string? CandidateReference { get; set; }
    public string? ProfileType { get; set; }
}
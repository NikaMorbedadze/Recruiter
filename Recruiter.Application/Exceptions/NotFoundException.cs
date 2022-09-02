using System.Linq.Expressions;

namespace Recruiter.Application.Exceptions;

public class NotFoundException : ApplicationException
{
    public NotFoundException(string message, object key) : base($"{message}, {key} was not found ")
    {
    }
}
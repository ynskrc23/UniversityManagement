using MediatR;

namespace NTierArchitecture.Business.Features.Instructors.UpdateInstructor;

public sealed record UpdateInstructorCommand(
    Guid Id,
    string LastName,
    string FirstMidName,
    DateTime HireDate) : IRequest;
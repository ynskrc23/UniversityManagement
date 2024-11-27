using MediatR;

namespace NTierArchitecture.Business.Features.Instructors.CreateInstructor;

public sealed record CreateInstructorCommand(
    string LastName,
    string FirstMidName,
    DateTime HireDate) : IRequest<Unit>;
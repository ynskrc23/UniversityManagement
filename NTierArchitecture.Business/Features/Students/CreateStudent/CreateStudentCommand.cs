using MediatR;

namespace NTierArchitecture.Business.Features.Students.CreateStudent;
public sealed record CreateStudentCommand(
    string LastName, 
    string FirstMidName,
    DateTime EnrollmentDate) : IRequest<Unit>;


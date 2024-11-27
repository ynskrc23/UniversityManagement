using MediatR;

public sealed record UpdateStudentCommand(
    Guid Id,
    string LastName,
    string FirstMidName,
    DateTime EnrollmentDate) : IRequest;

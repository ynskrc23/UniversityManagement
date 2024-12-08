using MediatR;

namespace NTierArchitecture.Business.Features.Departments.CreateDepartment;

public sealed record CreateDepartmentCommand(
    string Name,
    decimal Budget,
    DateTime StartDate,
    Guid InstructorId) : IRequest<Unit>;

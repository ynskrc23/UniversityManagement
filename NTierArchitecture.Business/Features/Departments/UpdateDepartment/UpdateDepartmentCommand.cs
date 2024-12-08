using MediatR;

namespace NTierArchitecture.Business.Features.Departments.UpdateDepartment;

public sealed record UpdateDepartmentCommand(
    Guid Id,
    string Name,
    decimal Budget,
    DateTime StartDate,
    Guid InstructorId
    ) : IRequest;
using MediatR;

namespace NTierArchitecture.Business.Features.Departments.RemoveDepartmentById;

public sealed record RemoveDepartmentByIdCommand(
    Guid Id) : IRequest;


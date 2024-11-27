using MediatR;

namespace NTierArchitecture.Business.Features.Students.RemoveStudentById;

public sealed record RemoveStudentByIdCommand(
    Guid Id) : IRequest;


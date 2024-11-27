using MediatR;

namespace NTierArchitecture.Business.Features.Instructors.RemoveInstructorById;

public sealed record RemoveInstructorByIdCommand(
    Guid Id) : IRequest;


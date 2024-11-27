using MediatR;
using Microsoft.EntityFrameworkCore;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Entities.Repositories;

namespace NTierArchitecture.Business.Features.Instructors.GetInstructors;

public sealed record GetInstructorsQuery() : IRequest<List<Instructor>>;

internal sealed class GetInstructorsQueryHandler : IRequestHandler<GetInstructorsQuery, List<Instructor>>
{
    private readonly IInstructorRepository _InstructorRepository;

    public GetInstructorsQueryHandler(IInstructorRepository InstructorRepository)
    {
        _InstructorRepository = InstructorRepository;
    }

    public async Task<List<Instructor>> Handle(GetInstructorsQuery request, CancellationToken cancellationToken)
    {
        return await _InstructorRepository.GetAll()
            .OrderBy(p => p.FirstMidName)
            .ToListAsync(cancellationToken);
    }
}
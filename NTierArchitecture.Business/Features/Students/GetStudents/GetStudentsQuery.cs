using MediatR;
using Microsoft.EntityFrameworkCore;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Entities.Repositories;

namespace NTierArchitecture.Business.Features.Students.GetStudents;

public sealed record GetStudentsQuery() : IRequest<List<Student>>;

internal sealed class GetStudentsQueryHandler : IRequestHandler<GetStudentsQuery, List<Student>>
{
    private readonly IStudentRepository _StudentRepository;

    public GetStudentsQueryHandler(IStudentRepository StudentRepository)
    {
        _StudentRepository = StudentRepository;
    }

    public async Task<List<Student>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
    {
        return await _StudentRepository.GetAll()
            .OrderBy(p => p.FirstMidName)
            .ToListAsync(cancellationToken);
    }
}

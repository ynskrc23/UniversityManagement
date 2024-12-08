using MediatR;
using Microsoft.EntityFrameworkCore;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Entities.Repositories;

namespace NTierArchitecture.Business.Features.Departments.GetDepartments;

public sealed record GetDepartmentsQuery() : IRequest<List<Department>>;

internal sealed class GetDepartmentsQueryHandler : IRequestHandler<GetDepartmentsQuery, List<Department>>
{
    private readonly IDepartmentRepository _DepartmentRepository;

    public GetDepartmentsQueryHandler(IDepartmentRepository DepartmentRepository)
    {
        _DepartmentRepository = DepartmentRepository;
    }

    public async Task<List<Department>> Handle(GetDepartmentsQuery request, CancellationToken cancellationToken)
    {
        return await _DepartmentRepository.GetAll()
            .OrderBy(p => p.Name)
            .ToListAsync(cancellationToken);
    }
}
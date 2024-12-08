using AutoMapper;
using MediatR;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Entities.Repositories;

namespace NTierArchitecture.Business.Features.Departments.CreateDepartment;

internal sealed class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, Unit>
{
    private readonly IDepartmentRepository _DepartmentRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CreateDepartmentCommandHandler(IUnitOfWork unitOfWork, IDepartmentRepository DepartmentRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _DepartmentRepository = DepartmentRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
    {
        Department Department = _mapper.Map<Department>(request);

        await _DepartmentRepository.AddAsync(Department, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}


using MediatR;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Entities.Repositories;


namespace NTierArchitecture.Business.Features.Departments.RemoveDepartmentById;

internal sealed class RemoveDepartmentByIdCommandHandler : IRequestHandler<RemoveDepartmentByIdCommand>
{
    private readonly IDepartmentRepository _DepartmentRepository;
    private readonly IUnitOfWork _unitOfWork;
    public RemoveDepartmentByIdCommandHandler(IDepartmentRepository DepartmentRepository, IUnitOfWork unitOfWork)
    {
        _DepartmentRepository = DepartmentRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoveDepartmentByIdCommand request, CancellationToken cancellationToken)
    {
        Department Department = await _DepartmentRepository.GetByIdAsync(p => p.Id == request.Id, cancellationToken);
        if (Department is null)
        {
            throw new ArgumentException("Departman bulunamadı!");
        }

        _DepartmentRepository.Remove(Department);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}


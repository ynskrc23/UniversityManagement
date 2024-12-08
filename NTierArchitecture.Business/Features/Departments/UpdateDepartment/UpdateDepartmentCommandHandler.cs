using AutoMapper;
using MediatR;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Entities.Repositories;

namespace NTierArchitecture.Business.Features.Departments.UpdateDepartment;

internal sealed class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand>
{
    private readonly IDepartmentRepository _DepartmentRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateDepartmentCommandHandler(IDepartmentRepository DepartmentRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _DepartmentRepository = DepartmentRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
    {
        Department Department = await _DepartmentRepository.GetByIdAsync(p => p.Id == request.Id, cancellationToken);
        if (Department is null)
        {
            throw new ArgumentException("Departman bulunamadı!");
        }

        _mapper.Map(request, Department);

        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}

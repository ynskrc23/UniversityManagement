using AutoMapper;
using MediatR;
using NTierArchitecture.Business.Features.Students.CreateStudent;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Entities.Repositories;

namespace NTierArchitecture.Business.Features.Students.CreateStudent;

internal sealed class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Unit>
{
    private readonly IStudentRepository _StudentRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CreateStudentCommandHandler(IUnitOfWork unitOfWork, IStudentRepository StudentRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _StudentRepository = StudentRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
    {
        Student Student = _mapper.Map<Student>(request);

        await _StudentRepository.AddAsync(Student, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}

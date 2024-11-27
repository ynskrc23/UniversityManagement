using AutoMapper;
using MediatR;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Entities.Repositories;

namespace NTierArchitecture.Business.Features.Instructors.CreateInstructor;

internal sealed class CreateInstructorCommandHandler : IRequestHandler<CreateInstructorCommand, Unit>
{
    private readonly IInstructorRepository _InstructorRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CreateInstructorCommandHandler(IUnitOfWork unitOfWork, IInstructorRepository InstructorRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _InstructorRepository = InstructorRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(CreateInstructorCommand request, CancellationToken cancellationToken)
    {
        Instructor Instructor = _mapper.Map<Instructor>(request);

        await _InstructorRepository.AddAsync(Instructor, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}

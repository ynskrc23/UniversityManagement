using AutoMapper;
using MediatR;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Entities.Repositories;

namespace NTierArchitecture.Business.Features.Instructors.UpdateInstructor;

internal sealed class UpdateInstructorCommandHandler : IRequestHandler<UpdateInstructorCommand>
{
    private readonly IInstructorRepository _InstructorRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateInstructorCommandHandler(IInstructorRepository InstructorRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _InstructorRepository = InstructorRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task Handle(UpdateInstructorCommand request, CancellationToken cancellationToken)
    {
        Instructor Instructor = await _InstructorRepository.GetByIdAsync(p => p.Id == request.Id, cancellationToken);
        if (Instructor is null)
        {
            throw new ArgumentException("Eğitmen bulunamadı!");
        }

        _mapper.Map(request, Instructor);

        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}

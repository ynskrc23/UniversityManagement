using MediatR;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Entities.Repositories;


namespace NTierArchitecture.Business.Features.Instructors.RemoveInstructorById;

internal sealed class RemoveInstructorByIdCommandHandler : IRequestHandler<RemoveInstructorByIdCommand>
{
    private readonly IInstructorRepository _InstructorRepository;
    private readonly IUnitOfWork _unitOfWork;
    public RemoveInstructorByIdCommandHandler(IInstructorRepository InstructorRepository, IUnitOfWork unitOfWork)
    {
        _InstructorRepository = InstructorRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoveInstructorByIdCommand request, CancellationToken cancellationToken)
    {
        Instructor Instructor = await _InstructorRepository.GetByIdAsync(p => p.Id == request.Id, cancellationToken);
        if (Instructor is null)
        {
            throw new ArgumentException("Eğitmen bulunamadı!");
        }

        _InstructorRepository.Remove(Instructor);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}


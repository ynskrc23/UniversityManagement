using MediatR;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Entities.Repositories;

namespace NTierArchitecture.Business.Features.Students.RemoveStudentById;

internal sealed class RemoveStudentByIdCommandHandler : IRequestHandler<RemoveStudentByIdCommand>
{
    private readonly IStudentRepository _StudentRepository;
    private readonly IUnitOfWork _unitOfWork;
    public RemoveStudentByIdCommandHandler(IStudentRepository StudentRepository, IUnitOfWork unitOfWork)
    {
        _StudentRepository = StudentRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoveStudentByIdCommand request, CancellationToken cancellationToken)
    {
        Student Student = await _StudentRepository.GetByIdAsync(p => p.Id == request.Id, cancellationToken);
        if (Student is null)
        {
            throw new ArgumentException("Öğrenci bulunamadı!");
        }

        _StudentRepository.Remove(Student);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}

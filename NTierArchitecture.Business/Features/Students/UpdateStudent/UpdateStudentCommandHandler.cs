using AutoMapper;
using MediatR;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Entities.Repositories;

namespace NTierArchitecture.Business.Features.Students.UpdateStudent;

internal sealed class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand>
{
    private readonly IStudentRepository _StudentRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateStudentCommandHandler(IStudentRepository StudentRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _StudentRepository = StudentRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
    {
        Student Student = await _StudentRepository.GetByIdAsync(p => p.Id == request.Id, cancellationToken);
        if (Student is null)
        {
            throw new ArgumentException("Öğrenci bulunamadı!");
        }

        _mapper.Map(request, Student);

        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
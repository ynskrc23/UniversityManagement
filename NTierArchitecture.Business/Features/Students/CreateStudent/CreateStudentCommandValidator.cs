using FluentValidation;

namespace NTierArchitecture.Business.Features.Students.CreateStudent;

public sealed class CreateStudentCommandValidator : AbstractValidator<CreateStudentCommand>
{
    public CreateStudentCommandValidator()
    {
        RuleFor(p => p.LastName).NotEmpty().WithMessage("Öğrenci soyadı boş olamaz");
        RuleFor(p => p.LastName).NotNull().WithMessage("Öğrenci soyadı boş olamaz");
        RuleFor(p => p.LastName).MinimumLength(3).WithMessage("Öğrenci soyadı en az 3 karakter olmalıdır");
        RuleFor(p => p.FirstMidName).NotNull().WithMessage("Öğrenci adı boş olamaz");
        RuleFor(p => p.FirstMidName).NotEmpty().WithMessage("Öğrenci adı boş olamaz");
        RuleFor(p => p.LastName).MinimumLength(2).WithMessage("Öğrenci adı en az 2 karakter olmalıdır");
    }
}


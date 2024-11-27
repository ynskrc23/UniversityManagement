using FluentValidation;

namespace NTierArchitecture.Business.Features.Instructors.CreateInstructor;

public sealed class CreateInstructorCommandValidator : AbstractValidator<CreateInstructorCommand>
{
    public CreateInstructorCommandValidator()
    {
        RuleFor(p => p.LastName).NotEmpty().WithMessage("Eğitmen soyadı boş olamaz");
        RuleFor(p => p.LastName).NotNull().WithMessage("Eğitmen soyadı boş olamaz");
        RuleFor(p => p.LastName).MinimumLength(3).WithMessage("Eğitmen soyadı en az 3 karakter olmalıdır");
        RuleFor(p => p.FirstMidName).NotNull().WithMessage("Eğitmen adı boş olamaz");
        RuleFor(p => p.FirstMidName).NotEmpty().WithMessage("Eğitmen adı boş olamaz");
        RuleFor(p => p.LastName).MinimumLength(2).WithMessage("Eğitmen adı en az 2 karakter olmalıdır");
    }
}

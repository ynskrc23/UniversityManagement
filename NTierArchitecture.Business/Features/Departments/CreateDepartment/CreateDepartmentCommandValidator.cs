using FluentValidation;
using NTierArchitecture.Business.Features.Departments.CreateDepartment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Features.Departments.CreateDepartment;


public sealed class CreateDepartmentCommandValidator : AbstractValidator<CreateDepartmentCommand>
{
    public CreateDepartmentCommandValidator()
    {
        RuleFor(p => p.Name).NotEmpty().WithMessage("Departman adı boş olamaz");
        RuleFor(p => p.Name).NotNull().WithMessage("Departman adı boş olamaz");
        RuleFor(p => p.Name).MinimumLength(3).WithMessage("Departman adı en az 3 karakter olmalıdır");
        RuleFor(p => p.InstructorId).NotEmpty().WithMessage("Eğitmen boş olamaz");
        RuleFor(p => p.InstructorId).NotNull().WithMessage("Eğitmen boş olamaz");
    }
}
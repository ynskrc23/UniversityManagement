using AutoMapper;
using NTierArchitecture.Business.Features.Departments.CreateDepartment;
using NTierArchitecture.Business.Features.Departments.UpdateDepartment;
using NTierArchitecture.Business.Features.Instructors.CreateInstructor;
using NTierArchitecture.Business.Features.Instructors.UpdateInstructor;
using NTierArchitecture.Business.Features.Students.CreateStudent;
using NTierArchitecture.Business.Features.Students.UpdateStudent;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Mapping;
internal sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateStudentCommand, Student>();
        CreateMap<UpdateStudentCommand, Student>();
        CreateMap<CreateInstructorCommand, Instructor>();
        CreateMap<UpdateInstructorCommand, Instructor>();
        CreateMap<CreateDepartmentCommand, Department>();
        CreateMap<UpdateDepartmentCommand, Department>();
    }
}

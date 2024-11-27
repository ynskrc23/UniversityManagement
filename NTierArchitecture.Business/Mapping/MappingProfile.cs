using AutoMapper;
using NTierArchitecture.Business.Features.Categories.CreateCategory;
using NTierArchitecture.Business.Features.Categories.UpdateCategory;
using NTierArchitecture.Business.Features.Instructors.CreateInstructor;
using NTierArchitecture.Business.Features.Instructors.UpdateInstructor;
using NTierArchitecture.Business.Features.Products.CreateProduct;
using NTierArchitecture.Business.Features.Products.UpdateProduct;
using NTierArchitecture.Business.Features.Students.CreateStudent;
using NTierArchitecture.Business.Features.Students.UpdateStudent;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Mapping;
internal sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateProductCommand, Product>();
        CreateMap<UpdateProductCommand, Product>();
        CreateMap<CreateCategoryCommand, Category>();
        CreateMap<UpdateCategoryCommand, Category>();
        CreateMap<CreateStudentCommand, Student>();
        CreateMap<UpdateStudentCommand, Student>();
        CreateMap<CreateInstructorCommand, Instructor>();
        CreateMap<UpdateInstructorCommand, Instructor>();
    }
}

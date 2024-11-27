using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;
using NTierArchitecture.Entities.Repositories;

namespace NTierArchitecture.DataAccess.Repositories;

internal sealed class InstructorRepository : Repository<Instructor>, IInstructorRepository
{
    public InstructorRepository(ApplicationDbContext context) : base(context)
    {
    }
}

using NTierArchitecture.Entities.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace NTierArchitecture.Entities.Models
{
    public sealed class OfficeAssignment : Entity
    {
        public Guid InstructorId { get; set; }
        public string Location { get; set; }
        public Instructor Instructor { get; set; }
    }
}

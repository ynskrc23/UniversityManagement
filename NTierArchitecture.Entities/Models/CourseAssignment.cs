using NTierArchitecture.Entities.Abstractions;

namespace NTierArchitecture.Entities.Models
{
    public sealed class CourseAssignment : Entity
    {
        public Guid InstructorId { get; set; }
        public Guid CourseId { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}

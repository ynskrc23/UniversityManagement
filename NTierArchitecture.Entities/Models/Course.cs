using NTierArchitecture.Entities.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace NTierArchitecture.Entities.Models
{
    public sealed class Course : Entity
    {
        public string Title { get; set; }
        public int Credits { get; set; }
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}

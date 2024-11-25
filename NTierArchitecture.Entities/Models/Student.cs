using NTierArchitecture.Entities.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace NTierArchitecture.Entities.Models
{
    public sealed class Student : Entity
    {
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

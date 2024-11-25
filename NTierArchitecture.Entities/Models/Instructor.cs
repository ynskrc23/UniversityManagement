using NTierArchitecture.Entities.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace NTierArchitecture.Entities.Models
{
    public sealed class Instructor : Entity
    {
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        public OfficeAssignment OfficeAssignment { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace StudentsApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Range(1, 12)]
        public int Grade { get; set; }

        [StringLength(1)]
        public string? Section { get; set; }
    }
}

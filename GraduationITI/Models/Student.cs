using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraduationITI.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters.")]
        [MinLength(3, ErrorMessage = "Please Enter a Valid Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Birthdate is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "National ID is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "National ID must be exactly 10 digits.")]
        public string NationalId { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - Birthdate.Year;

                if (Birthdate.Date > today.AddYears(-age))
                {
                    age--;
                }

                return age;
            }
        }
    }
}

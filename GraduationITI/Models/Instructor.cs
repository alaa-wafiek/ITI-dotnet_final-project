using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraduationITI.Models
{       public class Instructor
        {
            public int Id { get; set; }

            [Required(ErrorMessage = "Name is required.")]
            [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters.")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Birthdate is required.")]
            [DataType(DataType.Date)]
            public DateTime Birthdate { get; set; }

            [Required(ErrorMessage = "Phone number is required.")]
            [Phone(ErrorMessage = "Invalid phone number.")]
            public string PhoneNumber { get; set; }

            [Required(ErrorMessage = "Email is required.")]
            [EmailAddress(ErrorMessage = "Invalid email address.")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Salary is required.")]
            [Range(0, double.MaxValue, ErrorMessage = "Salary must be a positive value.")]
            public decimal Salary { get; set; }

            public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        }
    }


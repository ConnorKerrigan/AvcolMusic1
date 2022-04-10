using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AvcolMusic1.Models
{
    public class Teacher
    {
        public string TeacherID { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "The name entered is too long.")]
        [RegularExpression(@"^[A-Za-z]*$", ErrorMessage = "Only letters can be used")]
        public string Surname { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "The name entered is too long.")]
        [RegularExpression(@"^[A-Za-z]*$", ErrorMessage = "Only letters can be used")]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        public ICollection<Class> Classes { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;            // For model validation attributes
namespace Student.Models
{
}
    public class Student
    {
        // Model Validation. The model is annotated after this
        [Required(ErrorMessage = "Id must be passed")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength =20, ErrorMessage ="Name length must be 2 to 50")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is required")]
        [Range(1, 17, ErrorMessage ="Age must be between 1 to 17")]
        public int Age{ get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email{ get; set; }
}
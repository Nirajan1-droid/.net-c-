using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace WebApplication_Form__Nirajan.Models
{
    public class Student
    {
        [Required]
        public int id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Name length should be within 2 and 60")]
        public string Name { get; set; }
        
        public Student() { }
        public Student(int Id, string Name)
        {
            this.id = Id;
            this.Name = Name;
            

        }
    }
}
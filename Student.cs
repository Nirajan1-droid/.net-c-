using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{

    [Table("StudentTable")]
    public class Student
    {

        [Key]
        public int id { get; set; } 
        public string Name { get; set; }

    }
}
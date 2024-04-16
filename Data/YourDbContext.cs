using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication_Form__Nirajan.Models;

public class YourDbContext : DbContext
{
    public YourDbContext(DbContextOptions<YourDbContext> options) : base(options) { }

    public DbSet<Student> StudentTables { get; set; }  // Assuming "Student" matches your class name
}

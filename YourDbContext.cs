using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

public class YourDbContext : DbContext
{
    public YourDbContext(DbContextOptions<YourDbContext> options) : base(options) { }

    public DbSet<Student> StudentTables { get; set; }  // Assuming "Student" matches your class name
}

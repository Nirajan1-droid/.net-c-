using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using System.IO;
using Microsoft.EntityFrameworkCore;
namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        private readonly YourDbContext _context;

        public StudentController(YourDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Submit(Student userInfo)
        {
            try
            {
                await _context.StudentTables1.AddAsync(userInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Detail", userInfo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error saving student information: " + ex.Message);
            }
        }


        public async Task<IActionResult> Detail(Student userInfo)
        {
            var studentsName = await _context.StudentTables1.ToListAsync();
            await Console.Out.WriteLineAsync(studentsName.ToString());
            return View(userInfo);
        }
    }
}

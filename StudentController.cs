using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

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
        public IActionResult Submit(Student userInfo)
        {
            try
            {
                _context.StudentTables.Add(userInfo);
                _context.SaveChanges();
                return RedirectToAction("Detail", userInfo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error saving student information: " + ex.Message);
            }
        }

        public IActionResult Detail(Student userInfo)
        {
            return View(userInfo);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        private readonly YourDbContext _context;  // Assume your DbContext is named "YourDbContext"

        public StudentController(YourDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Student/Submit
        [HttpPost]
        public IActionResult Submit(Student userInfo)
        {
            try
            {
                // Insert student information into the database
                _context.Details.Add(userInfo);
                _context.SaveChanges();

                // Redirect to Detail action with the student information
                return RedirectToAction("Detail", userInfo);
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during database interaction
                // Log the error, display an error message, etc.
                return StatusCode(500, "Error saving student information");
            }
        
        }

    // GET: /Student/Detail
    public IActionResult Detail(Student userInfo)
        {
            return View(userInfo);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
 
using WebApplication_Form__Nirajan.Models;

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
                await _context.StudentTables.AddAsync(userInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Student");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error saving student information: " + ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Detail(Student userInfo)
        {
            var studentsName = await _context.StudentTables.ToListAsync();
            await Console.Out.WriteLineAsync(studentsName.ToString());
            return View(studentsName);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id) //id=1
        {
            var student = await _context.StudentTables.FindAsync(id);//find that

            return View(student);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Student student)
        {
            try
            {

                if (student is null)
                {
                    return BadRequest("Request is empty");
                }


                var studentidfind = await _context.StudentTables.FindAsync(student.id);
                if (studentidfind is not null)
                {
                    studentidfind.Name = student.Name;
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Details", "Student");
                }
                else
                {
                    return BadRequest("sdfdsf");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error saving student information: " + ex.Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Delete(Student student)
        {
            var Id_no_to_delete = await _context.StudentTables.AsNoTracking().FirstOrDefaultAsync(x => x.id == student.id);
            if (Id_no_to_delete is null)
            {
                Console.WriteLine("id no to delete" + Id_no_to_delete);
                return BadRequest("Nothing to delete bro");
            }
            else
            {
                //Id_no_to_delete.Name = Id_no_to_delete.Name;
                _context.StudentTables.Remove(student);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Detail", "Student");
        }

    }
}
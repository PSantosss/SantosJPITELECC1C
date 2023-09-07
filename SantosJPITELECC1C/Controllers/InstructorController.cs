using Microsoft.AspNetCore.Mvc;
using SantosJPITELECC1C.Models;
namespace SantosJPITELECC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>();
        {
            new Instructor()
            {
                InstructorName = "Gabriel Montano", DateHired = DateTime.Now, InstructorEmail = "gdmontano@ust.edu.ph", Rank = "Instructor"
            },
        new Instructor()
            {
                InstructorName = "Gabriel Montano", DateHired = DateTime.Now, InstructorEmail = "gdmontano@ust.edu.ph", Rank = "Instructor"
            },
    }
        public IActionResult Index()
        {

            return View(InstructorList);
        }
    }
}

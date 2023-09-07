using Microsoft.AspNetCore.Mvc;
using SantosJPITELECC1C.Models;

namespace SantosJPITELECC1C.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult Index()
        {
            Student st = new Student();
            st.StudentID = 2021154564;
            st.StudentName = "Paolo Santos";
            st.DateEnrolled = DateTime.Parse("30/08/2023");
            st.Course = Course.BSIT;
            st.Email = "josepaolo.santos.cics@ust.edu.ph";

            ViewBag.student = st;
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using StudentTeacherDemoWEBApplication.Data;
using StudentTeacherDemoWEBApplication.Models;

namespace StudentTeacherDemoWEBApplication.Controllers
{
    public class GraduateController : Controller
    {
        private readonly StudCourseDBContext _context;

        public GraduateController(StudCourseDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Graduation> graduations= _context.tbl_graduation.ToList();
            return View(graduations);
        }

        public IActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Graduation graduation)
        {
            _context.tbl_graduation.Add(graduation);
            _context.SaveChanges();
            return RedirectToAction("Index");            
        }

    }
}

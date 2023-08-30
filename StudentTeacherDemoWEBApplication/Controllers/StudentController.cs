using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentTeacherDemoWEBApplication.Data;

namespace StudentTeacherDemoWEBApplication.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudCourseDBContext _studCourseDBContext;

        public StudentController(StudCourseDBContext studCourseDBContext)
        {
            _studCourseDBContext = studCourseDBContext;
        }

        public IActionResult Index()
        {
            var result = _studCourseDBContext.tbl_student.ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _studCourseDBContext.tbl_teacher.Where(x => x.TID == id).FirstOrDefaultAsync();
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _studCourseDBContext.tbl_teacher.Where(x => x.TID == id).FirstOrDefaultAsync();
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var result = await _studCourseDBContext.tbl_teacher.Where(x => x.TID == id).FirstOrDefaultAsync();
            return View(result);
        }
    }
}

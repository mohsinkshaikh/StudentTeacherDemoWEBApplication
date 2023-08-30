using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;
using StudentTeacherDemoWEBApplication.Data;
using StudentTeacherDemoWEBApplication.Models;

namespace StudentTeacherDemoWEBApplication.Controllers
{
    public class TeacherController : Controller
    {
        private readonly StudCourseDBContext _studCourseDBContext;

        public TeacherController(StudCourseDBContext studCourseDBContext)
        {
            _studCourseDBContext = studCourseDBContext;
        }

        public IActionResult Index()
        {
            var result = _studCourseDBContext.tbl_teacher.ToList();
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

        [HttpPost]
        public async Task<IActionResult> Create(Teacher teacher)
        {
            await _studCourseDBContext.tbl_teacher.AddAsync(teacher);
            await _studCourseDBContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Teacher teacher)
        {
            //var result = await _studCourseDBContext.tbl_course.Where(x => x.CourseID == id).FirstOrDefaultAsync();
            _studCourseDBContext.tbl_teacher.Update(teacher);
            await _studCourseDBContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Teacher teacher)
        {
            //var result = await _studCourseDBContext.tbl_course.Where(x => x.CourseID == id).FirstOrDefaultAsync();
            _studCourseDBContext.tbl_teacher.Remove(teacher);
            await _studCourseDBContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

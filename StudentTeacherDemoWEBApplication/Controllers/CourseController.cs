using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentTeacherDemoWEBApplication.Data;
using StudentTeacherDemoWEBApplication.Models;

namespace StudentTeacherDemoWEBApplication.Controllers
{
    public class CourseController : Controller
    {
        private readonly StudCourseDBContext _studCourseDBContext;

        public CourseController(StudCourseDBContext studCourseDBContext)
        {
            _studCourseDBContext = studCourseDBContext;
        }

        public async Task<IActionResult> Index()
        {
            var result =await _studCourseDBContext.tbl_course.ToListAsync();
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
            var result = await _studCourseDBContext.tbl_course.Where(x => x.CourseID == id).FirstOrDefaultAsync();
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _studCourseDBContext.tbl_course.Where(x => x.CourseID == id).FirstOrDefaultAsync();
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id) 
        {
            var result = await _studCourseDBContext.tbl_course.Where(x => x.CourseID == id).FirstOrDefaultAsync();
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Courses courses)
        {
            await _studCourseDBContext.tbl_course.AddAsync(courses);
            await _studCourseDBContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Courses courses)
        {
            //var result = await _studCourseDBContext.tbl_course.Where(x => x.CourseID == id).FirstOrDefaultAsync();
            _studCourseDBContext.tbl_course.Update(courses);
            await _studCourseDBContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Courses courses)
        {
            //var result = await _studCourseDBContext.tbl_course.Where(x => x.CourseID == id).FirstOrDefaultAsync();
            _studCourseDBContext.tbl_course.Remove(courses);
            await _studCourseDBContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}

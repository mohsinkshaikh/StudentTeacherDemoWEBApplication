using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentTeacherDemoWEBApplication.Data;
using StudentTeacherDemoWEBApplication.Models;
using System.Threading.Tasks.Dataflow;

namespace StudentTeacherDemoWEBApplication.Controllers
{
    public class PostGraduateController : Controller
    {
        private readonly StudCourseDBContext _context;

        public PostGraduateController(StudCourseDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<PostGraduation> postgraduations = _context.tbl_post_graduation.ToList();
            var items= _context.tbl_graduation.ToList();

            ViewBag.ItemList = new SelectList(items,"GradID","GradName");

            return View(postgraduations);
        }

        [HttpGet]
        public IActionResult GetGraduation()
        {           
          
            return View();
        }

        public IActionResult GetGraduationByID(int id)
        {
            var gradByID = _context.tbl_graduation.Where(x => x.GradID == id).FirstOrDefault();
                return Json(gradByID);
        }

        public IActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Create(PostGraduation postgrad)
        {
            _context.tbl_post_graduation.Add(postgrad);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

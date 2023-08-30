using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using StudentTeacherDemoWEBApplication.Data;
using StudentTeacherDemoWEBApplication.Models;

namespace StudentTeacherDemoWEBApplication.Controllers
{
    public class CountriesController : Controller
    {
        private readonly StudCourseDBContext _studCourseDBContext;

        public CountriesController(StudCourseDBContext studCourseDBContext)
        {
            _studCourseDBContext = studCourseDBContext;
        }

        public IActionResult Index()
        {
            var result = _studCourseDBContext.tbl_country.ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _studCourseDBContext.tbl_country.Where(x => x.ID == id).FirstOrDefault();
            return View(result);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {           
            var result = _studCourseDBContext.tbl_country.Where(x => x.ID == id).FirstOrDefault();           
            return View(result);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = _studCourseDBContext.tbl_country.Where(x => x.ID == id).FirstOrDefault();
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Country country)
        {
           
                _studCourseDBContext.tbl_country.Add(country);
                _studCourseDBContext.SaveChanges();
                return RedirectToAction("Index");
           
        }

        [HttpPost]
        public IActionResult Edit(Country country)
        {
            
                    _studCourseDBContext.tbl_country.Update(country);
                    _studCourseDBContext.SaveChanges();
                    return RedirectToAction("Index");
                 
        }

        [HttpPost]
        public IActionResult Delete(Country country)
        {  
               var result= _studCourseDBContext.tbl_country.Remove(country);
                _studCourseDBContext.SaveChanges();
                return RedirectToAction("Index");                       
        }

    }
}

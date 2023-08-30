using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;
using StudentTeacherDemoWEBApplication.Data;
using StudentTeacherDemoWEBApplication.Models;
using StudentTeacherDemoWEBApplication.ViewModel;

namespace StudentTeacherDemoWEBApplication.Controllers
{
    public class StatesController : Controller
    {
        private readonly StudCourseDBContext _studCourseDBContext;

        public StatesController(StudCourseDBContext studCourseDBContext)
        {
            _studCourseDBContext = studCourseDBContext;
        }

        public Country GetCountryDataById(int id)
        {
            Country country;
            country = _studCourseDBContext.tbl_country.Where(x => x.ID == id).FirstOrDefault();
            return country;
        }

        public IActionResult Index()
        {
            List<State> StateList = _studCourseDBContext.tbl_state.ToList();          

            return View(StateList);
        }
        [HttpGet]
        public JsonResult GetCountry()
        {
            var subcat = _studCourseDBContext.tbl_country.ToList();
            return new JsonResult(subcat);
        }

        public JsonResult GetState(int id)
        {
            var subcat = _studCourseDBContext.tbl_state.Where(x => x.ID == id).FirstOrDefault();
            return new JsonResult(subcat);
        }

        public IActionResult Create()
        {
           
            return View();
        }

        public IActionResult Edit(int id)
        {
            Country country = GetCountryDataById(id);
            return new JsonResult(country);
        }
        public IActionResult Detail(int id)
        {
            Country country = GetCountryDataById(id);
            return new JsonResult(country);
        }
        public IActionResult Delete(int id)
        {
            Country country = GetCountryDataById(id);
            return new JsonResult(country);
        }
    }
}

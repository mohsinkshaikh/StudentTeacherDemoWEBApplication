using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentTeacherDemoWEBApplication.Data;
using StudentTeacherDemoWEBApplication.Models;

namespace StudentTeacherDemoWEBApplication.Controllers
{
    public class CatProdController : Controller
    {
        private readonly StudCourseDBContext _studCourseDBContext;

        public CatProdController(StudCourseDBContext studCourseDBContext)
        {
            _studCourseDBContext = studCourseDBContext;
        }

        public IActionResult Index()
        {
            var cat = _studCourseDBContext.tbl_category.ToList();

            var prod = new List<Product>();

            //var prod = _studCourseDBContext.tbl_product.ToList();

            /*ar prod = _studCourseDBContext.tbl_product.ToList();*/

            ViewBag.categories = new SelectList(cat, "ID", "CategoryName");
            ViewBag.products = new SelectList(prod, "ID", "ProductName");
            return View();
        }

        public JsonResult GetCategory()
        {
            var result = _studCourseDBContext.tbl_category.ToList();
            return new JsonResult(result);
        }

        public JsonResult GetProductIdByCategoryId(int categoryID)
        {
            List<Product > result = _studCourseDBContext.tbl_product.Where(x => x.category.ID == categoryID).ToList();
            return new JsonResult(result);
        }
    }
}

using Items.Entity;
using DepartmentItems.Repository;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Application.Controllers
{
    public class IndexController : Controller
    {
        DeptRespository indexController;

        public IndexController()
        {
            indexController = new DeptRespository();
        }
        // GET: Index
        
            public ActionResult Index()
            {
                IEnumerable<Products> products = indexController.GetAllProducts();
                TempData["products"] = products;
                ViewData["product"] = products;
                ViewBag.products = products;
                return View();

            }
        
        public void RedirectMethod()
        {
            Response.RedirectToRoute("Index");   
           
        }
    }
}
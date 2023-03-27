using Microsoft.AspNetCore.Mvc;
using UNITOFWORK.Models;
using UNITOFWORK.Repository;

namespace UNITOFWORK.Controllers
{
    public class ProductController : Controller
    {
        private IUnitOfWork unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var listProduct = unitOfWork.Products.GetProducts();
            return View(listProduct);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.Products.AddProduct(product);
                    unitOfWork.SaveChange();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                throw;
            }
            return View();
        }
    }
}

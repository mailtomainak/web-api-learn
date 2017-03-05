using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using models;
using System.Threading.Tasks;
using repository;
namespace mvc_front_app.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository _repository;
        public ProductController()
        {
             _repository = new ProductRepository();
        }
        // GET: Product
        public async Task<ActionResult> Index()
        {
            return View();
        }

        // GET: Product/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public async Task<ActionResult> Create()
        {
           
            return View();
        }
        public async Task<PartialViewResult> CreatePartial()
        {
            return PartialView("Create_Partial");
        }
        // POST: Product/Add
        [HttpPost]
        [HandleError]
        public async Task<ActionResult> Add(Product product)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                    if (TempData["Products"] != null)
                    {
                        var prodList = TempData["Products"] as List<Product>;
                        prodList.Add(product);
                        TempData["Products"] = prodList;
                    }
                    else
                    {
                        var prodList = new List<Product>();
                        prodList.Add(product);
                        TempData["Products"] = prodList;
                    }

                _repository.SaveTempProduct(product);
                return RedirectToAction("Create");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        // POST: Product/Create
        [HttpPost]
        public async Task<ActionResult> Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

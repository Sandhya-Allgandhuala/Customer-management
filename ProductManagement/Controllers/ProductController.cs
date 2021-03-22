using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PM_Services.Services.serviceinterfaces;
using PM_Services.ViewModel;

namespace ProductManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices product;

        public ProductController(IProductServices Product)
        {
            product = Product;
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductDTO Newproduct)
        {
            if (product.SaveProductData(Newproduct) == true)
            {
                return RedirectToAction("ListProduct");
            }
            return View();
        }

        [HttpGet]
        public IActionResult ListProduct()
        {
            return View(product.GetProductData());
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            return View(product.GetProductbyId(id));
        }

        [HttpPost]
        public IActionResult EditProduct(ProductDTO Product)
        {
            if (product.UpdateProductData(Product) == true)
            {
               return RedirectToAction("ListProduct");
            }

            return View();
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            return View(product.GetProductbyId(id));
        }

        [HttpPost]
        public IActionResult DeleteProduct(ProductDTO Product)
        {
            if (product.DeleteProductData(Product) == true)
            {
                return RedirectToAction("ListProduct");
            }

            return View();
        }

        [HttpGet]
        public IActionResult ProductDetails(int id)
        {
            return View(product.GetProductbyId(id));
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobilyaShowRoom.Models;
namespace MobilyaShowRoom.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

        var products = Repository.AllProduct();
            ViewBag.Title = "Products";
            return View(products);
        }

        public IActionResult GetProductDetail()
        {
            var products = Repository.AllProduct();
            Product resultProduct = null;
            int id =Convert.ToInt32(ControllerContext.RouteData.Values["ID"]);
            foreach (var product in products)
            {
                if (product.ID == id) 
                {
                    resultProduct = product;
                    break;
                }
            }
            ViewBag.Product = resultProduct;
          
            ViewBag.Tİtle = resultProduct.ProductName + "Ürün Detay Bilgisi";
            return View();
        }

    }
}

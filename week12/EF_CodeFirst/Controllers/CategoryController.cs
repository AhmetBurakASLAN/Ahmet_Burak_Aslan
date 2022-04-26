using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models.Context;
using EF_CodeFirst.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EF_CodeFirst.Controllers
{
    
    public class CategoryController : Controller
    {
         private readonly Library6Context  _context;
         
         public CategoryController(Library6Context context)
         {
             _context= context;
         }
       
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        

         public IActionResult Create( )
        {
        
            return View();
        }

            [HttpPost]
        public IActionResult Create(Category category)
        
        {
                _context.Add(category);
                _context.SaveChanges();

            return RedirectToAction("index");
        }

         public IActionResult Delete(int id)
         {
             var category = _context.Categories.Find(id);
           return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var deletedCategory = _context.Categories.Find(id);
            _context.Categories.Remove(deletedCategory);
        _context.SaveChanges();
         return RedirectToAction("Index");




    }
}
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers
=======
using EF_CodeFirst.Models.Context;
using EF_CodeFirst.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EF_CodeFirst.Controllers
>>>>>>> 10d74529ebaea9dfbee832cf407b9536a430d162
{
    
    public class CategoryController : Controller
    {
<<<<<<< HEAD
       
        public IActionResult Index()
        {
            return View();
=======
         private readonly Library6Context  _context;
         
         public CategoryController(Library6Context context)
         {
             _context= context;
         }
       
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
>>>>>>> 10d74529ebaea9dfbee832cf407b9536a430d162
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

<<<<<<< HEAD
        public IActionResult Delete()
        {
            return View();
        }
    }
=======
        

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
>>>>>>> 10d74529ebaea9dfbee832cf407b9536a430d162
}
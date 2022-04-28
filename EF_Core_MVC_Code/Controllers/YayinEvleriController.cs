using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EF_Core_MVC_Code.Models;

namespace EF_Core_MVC_Code.Controllers
{
 
    public class YayinEvleriController : Controller
    {
        private readonly KutuphaneSabahContext _context;
        public YayinEvleriController(KutuphaneSabahContext context)
        {
            _context = context;
            //Bu aşamadan sonra yani nesne ilk üretildiği andan itibaren _context değişkeni
            //benim modelimi temsil ediyor olacak.
            //Bu sayede, KutuphaneSabahContext'i temsil edecek.
        }
        public IActionResult Index()
        {
            
            return View(_context.Yayinevleris.ToList());
        }

        //GET - Kitap türü detayını göster.
        public IActionResult Details(int id)
        {
            var yayinevleri = _context.Yayinevleris.Find(id);
            return View(yayinevleri);
        }

        //GET - Düzenlenecek kitabın bilgilerini göster
        public IActionResult Edit(int id)
        {
            var yayienvleri = _context.Turlers.Find(id);
            return View(yayienvleri);
        }

        [HttpPost]
        public IActionResult Edit(Yayinevleri yayinevleri)
        {
            if (ModelState.IsValid)
            {
                _context.Update(yayinevleri); //Bu satır sadece contexti günceller. Veritabanına işlem yapmaz.
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        //Silinecek türün detay sayfasını açar.
        public IActionResult Delete(int id)
        {
            var yayinevleri = _context.Turlers.Find(id);
            return View(yayinevleri);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekYayinevleri = _context.Turlers.Find(id);
            _context.Turlers.Remove(silinecekYayinevleri);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

         public IActionResult Create(int id)
        {
            var yayinevleri = _context.Turlers.Find(id);
            return View(yayinevleri);
        }

        [HttpPost]
        public IActionResult Create(Yayinevleri yayinevleri)
        {
            _context.Add(yayinevleri);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
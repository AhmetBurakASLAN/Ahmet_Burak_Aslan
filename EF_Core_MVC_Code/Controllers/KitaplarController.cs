using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_Core_MVC_Code.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EF_Core_MVC_Code.Controllers
{
    
    public class KitaplarController : Controller
    {
       private readonly KutuphaneSabahContext _context;
        public KitaplarController(KutuphaneSabahContext context)
        {
            _context = context;
            //Bu aşamadan sonra yani nesne ilk üretildiği andan itibaren _context değişkeni
            //benim modelimi temsil ediyor olacak.
            //Bu sayede, KutuphaneSabahContext'i temsil edecek.
        }
        public IActionResult Index()
        {
            
            return View(_context.Kitaplars.ToList());
        }

        //GET - Kitap türü detayını göster.
        public IActionResult Details(string id)
        {
        
            var seciliKitap = _context.Kitaplars
            .Include(k=>k.Tur)
            .Include(k=>k.YayinEvi)
            .Include(k=>k.Yazar)
            .First(sk=> sk.Isbn==id);

            return View(seciliKitap);
        }
            public IActionResult Edit(string id)
            {
              var seciliKitap=_context.Kitaplars.Find(id);
              ViewData["Tur"]=new SelectList(_context.Turlers,"Id","TurAd", seciliKitap.TurId);
              ViewData["Yazar"]=new SelectList(_context.Yazarlars,"Id","AdSoyad", seciliKitap.YazarId);
              ViewData["YayinEvi"]=new SelectList(_context.Yayinevleris,"Id","Ad", seciliKitap.YayinEviId);

              return View (seciliKitap);



            }

            [HttpPost]
            public IActionResult Edit(Kitaplar kitap)
            {
                _context.Update(kitap);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }



        //GET - Düzenlenecek kitabın bilgilerini göster
        // public IActionResult Edit(int id)
        // {
        //     var kitaplar = _context.Kitaplars.Find(id);
        //     return View(kitaplar);
        // }

        // [HttpPost]
        // public IActionResult Edit(Kitaplar kitaplar)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.Update(kitaplar); //Bu satır sadece contexti günceller. Veritabanına işlem yapmaz.
        //         _context.SaveChanges();
        //     }
        //     return RedirectToAction("Index");
        // }

        // //Silinecek türün detay sayfasını açar.
        // public IActionResult Delete(int id)
        // {
        //     var kitaplar = _context.Turlers.Find(id);
        //     return View(kitaplar);
        // }

        // [HttpPost, ActionName("Delete")]
        // public IActionResult DeleteConfirmed(int id)
        // {
        //     var silinecekKitaplar = _context.Kitaplars.Find(id);
        //     _context.Kitaplars.Remove(silinecekKitaplar);
        //     _context.SaveChanges();
        //     return RedirectToAction("Index");
        // }

        //  public IActionResult Create(int id)
        // {
        //     var kitaplar = _context.Turlers.Find(id);
        //     return View(kitaplar);
        // }

        // [HttpPost]
        // public IActionResult Create(Kitaplar kitaplar)
        // {
        //     _context.Add(kitaplar);  
        //     _context.SaveChanges();
        //     return RedirectToAction("Index");
        // }
    }
}
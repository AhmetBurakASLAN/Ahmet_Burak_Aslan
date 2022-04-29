using DatabaseImageProject.Models.Concrete;
using DatabaseImageProject.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseImageProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var product = new ProductDAL();

            
            
            return View(product.GetAll());
        }
        public IActionResult UploadImage()
        {//Birazdan resmin yüklenmesi işlemlerini tamamlayıp,
            //buraya döneceğiz.
            //Döndük, hiç değişmemişsin.
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/");
            var imageList = Directory.GetFiles(path);

            List<UploadImageModel> uploadImages = new List<UploadImageModel>();

            foreach (var image in imageList)
            {
                FileInfo fileInfo = new FileInfo(image);
                UploadImageModel model = new UploadImageModel();
                model.FullName = image.Substring(image.IndexOf("wwwroot")).Replace("wwwroot", string.Empty);
                model.FileName = fileInfo.Name;
                model.Size = fileInfo.Length / 1024;
                uploadImages.Add(model);
            }

            return View(uploadImages);
        }

        [HttpPost]
        public IActionResult UploadImage(IFormFile file)
        {
            if (file != null)
            {
                string imageExtension = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid() + imageExtension;
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}");

                var stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
            }

            return RedirectToAction("UploadImage");
        }
    }
}

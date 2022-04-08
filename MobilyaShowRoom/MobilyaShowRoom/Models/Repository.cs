using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilyaShowRoom.Models
{
    public static class Repository
    {
        public static List<Product> AllProduct()
        {
            var products = new List<Product>
            {
                new Product{ID=540,ProductName="Sürgülü Kapılı Dolap1",ProductDetail="Sürgülü Kapılı Dolap Aynalı Model1",Price=4500,Image="./img/11.jpg"},
                new Product{ID=545,ProductName="Sürgülü Kapılı Dolap2",ProductDetail="Sürgülü Kapılı Dolap Aynalı Model2",Price=5500,Image="./img/2.jpg"},
                new Product{ID=640,ProductName="Sürgülü Kapılı Dolap3",ProductDetail="Sürgülü Kapılı Dolap Aynalı Model3",Price=6500,Image="./img/3.jpg"},
                new Product{ID=340,ProductName="Sürgülü Kapılı Dolap4",ProductDetail="Sürgülü Kapılı Dolap Aynalı Model4",Price=7500,Image="./img/4.jpg"},
                new Product{ID=510,ProductName="Sürgülü Kapılı Dolap5",ProductDetail="Sürgülü Kapılı Dolap Aynalı Model5",Price=8500,Image="./img/5.jpg"},
                new Product{ID=590,ProductName="Sürgülü Kapılı Dolap6",ProductDetail="Sürgülü Kapılı Dolap Aynalı Model6",Price=9500,Image="./img/6.jpg"},
              
            };
            return products;
        }
    }
}

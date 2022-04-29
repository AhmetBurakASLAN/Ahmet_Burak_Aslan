using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace Models.Entities
=======
namespace EF_CodeFirst.Models.Entities
>>>>>>> 10d74529ebaea9dfbee832cf407b9536a430d162
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Book> Books { get; set; }
         public bool IsDeleted { get; set; }

    }
}
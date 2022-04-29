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
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int BookYearOfPublication { get; set; }
        public int BookEditionNumber { get; set; }
        public int BookNumberOfPages { get; set; }
        public int BookQuantity { get; set; }
         public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        
    }
}
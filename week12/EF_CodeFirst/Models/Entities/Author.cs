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
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public DateTime AuthorDateOfBirth { get; set; }
        public bool IsDeleted { get; set; }
        public List<Book> Books { get; set; }
    }
}
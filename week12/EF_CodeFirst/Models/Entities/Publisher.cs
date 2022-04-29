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
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string PublisherCity { get; set; }
        public string PublisherMail { get; set; }
        public List<Book> Books { get; set; }
         public bool IsDeleted { get; set; }
    }
}
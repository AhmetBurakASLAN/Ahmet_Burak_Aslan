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
    public class Member
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public DateTime MeemberDateOfBirth { get; set; }
        public string MemberPhoneNumber { get; set; }
        public string MemberMail { get; set; }
        public DateTime MemberJoinDate { get; set; }
        public string MemberJob { get; set; }
         public bool IsDeleted { get; set; }
        
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProject.models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
       
       public virtual ICollection<CPhone> CPhones { get; set; }
          = new List<CPhone>();
        public virtual ICollection<Order> Orders { get; set; }
         = new HashSet<Order>();
        
    }
}

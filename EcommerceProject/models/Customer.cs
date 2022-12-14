using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProject.models
{
    public class Customer
    {
        public int Id { get; set; }
        public byte[] image { get; set; }

        public string FullName { get; set; }
        [ForeignKey("Registeration")]
        [Required]

        public string UserName { get; set; }
        public Registeration Registeration { get; set; }
        [Required]
        public string Address { get; set; }

        [ForeignKey("Cart")]
        public int? cartID { get; set; }
        public Cart Cart { get; set; }

        public virtual ICollection<CPhone> CPhones { get; set; }
          = new List<CPhone>();
        public virtual ICollection<Order> Orders { get; set; }
         = new HashSet<Order>();
        
    }
}

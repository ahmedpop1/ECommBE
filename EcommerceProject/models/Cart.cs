using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProject.models
{
    public class Cart
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<CartItems> Items { get; set; }
          = new HashSet<CartItems>();
    }
}

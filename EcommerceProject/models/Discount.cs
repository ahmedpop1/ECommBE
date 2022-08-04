using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProject.models
{
    public class Discount
    {
        public int Id { get; set; }

        public float DiscountValue { get; set; }
        public virtual ICollection<Product> Products { get; set; } 
            = new HashSet<Product>(); 
    }
}

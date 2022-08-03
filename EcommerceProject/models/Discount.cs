using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProject.models
{
    public class Discount
    {
        public int Id { get; set; }

        public decimal DiscountValue { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}

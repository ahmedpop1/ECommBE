using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceProject.models
{
    public class CartItems
    {
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
    }
}

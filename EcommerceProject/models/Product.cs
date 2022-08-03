using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace EcommerceProject.models

{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("Brand")]
        public int? BrandID { get; set; }
        public Brand Brand { get; set; }
        [ForeignKey("Category")]
        public int CatID { get; set; }
        public Category Category { get; set; }
        public bool Availability { get; set; }
        [ForeignKey("discount")]
        public System.Nullable<int> DiscountID { get; set; }
        public virtual Discount discount { get; set; }
        public virtual ICollection<OrderDetials> OrderDetials { get; set; }
         = new HashSet<OrderDetials>();
        public virtual ICollection<CartItems> Items { get; set; }
          = new HashSet<CartItems>();



    }
}

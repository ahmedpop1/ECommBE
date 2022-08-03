    using System.ComponentModel.DataAnnotations.Schema;
namespace EcommerceProject.models

{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? BrandID { get; set; }
        public int CatID { get; set; }
        public bool Availability { get; set; }
        [ForeignKey("discount")]
        public System.Nullable<int> DiscountID { get; set; }
        public virtual Discount discount { get; set; }



    }
}

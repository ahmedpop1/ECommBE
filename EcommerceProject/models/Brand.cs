using System.Collections.Generic;

namespace EcommerceProject.models
{
    public class Brand
    {
        public int id { get; set; }
        public string BName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
         = new HashSet<Product>();
    }
}

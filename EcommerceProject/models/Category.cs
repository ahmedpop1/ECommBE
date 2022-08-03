using System.Collections.Generic;

namespace EcommerceProject.models
{
    public class Category
    {
        public int id { get; set; }
        public int CatName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
         = new HashSet<Product>();   
    }
}

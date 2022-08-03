using Microsoft.EntityFrameworkCore;

namespace EcommerceProject.models
{
    public class EcommerceContext:DbContext
    {
        public EcommerceContext(DbContextOptions options):base(options)
        {
                
        }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Product> Products{ get; set; }

    }
}

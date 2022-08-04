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
        public virtual DbSet<Customer> Customers{ get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItems> Items { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetials> Detials { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Registeration> Registerations { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetials>().HasKey(ww => new { ww.OrderId, ww.ProductId });
            modelBuilder.Entity<CartItems>().HasKey(ww => new { ww.CartId, ww.productID });
            //modelBuilder.Entity<Customer>()
            //.HasOne<Registeration>(s => s.Registeration)
            //.WithOne(ad => ad.customer)
            //.HasForeignKey<StudentAddress>(ad => ad.AddressOfStudentId);

        }

    }
}

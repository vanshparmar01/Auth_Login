using Auth_Login.Models;
//using Auth_Login.Models.UserLogin;
using Microsoft.EntityFrameworkCore;

namespace Auth_Login.Data
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options)
        {


        }
        public DbSet<Signup> signup {  get; set; }

        public DbSet<UserLogin> login { get; set; }
        public DbSet<ProductModel> product { get; set; }
        public DbSet<ShoppingCartViewModel> shoppingcart { get; set; }
        public DbSet<ShoppingCartItem> cartitem { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ProductModel>()
                .Property(p => p.OldPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ShoppingCartItem>()
           .Property(p => p.Price)
           .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ShoppingCartViewModel>()
                .Property(p => p.OrderTotal)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ShoppingCartViewModel>()
                .Property(p => p.Shipping)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ShoppingCartViewModel>()
                .Property(p => p.Subtotal)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ShoppingCartViewModel>()
                .Property(p => p.Tax)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
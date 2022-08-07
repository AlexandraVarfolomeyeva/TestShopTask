using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShopTask.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext()
    : base("data source=.\\SQLEXPRESS;initial catalog=Shop;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ProductsInShop> ProductsInShop { get; set; }
        public DbSet<GiftCard> GiftCards { get; set; }
        public DbSet<GiftCardItem> GiftCardItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GiftCard>()
                .HasMany(s => s.GiftCardItems)
                .WithRequired(e => e.GiftCard)
                .HasForeignKey(e => e.GiftCardId);

            modelBuilder.Entity<Product>()
                .HasMany(c => c.GiftCardItems)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductId);
            
            modelBuilder.Entity<Product>()
                .HasMany(c => c.ProductsInShop)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductId);
            
            modelBuilder.Entity<Shop>()
                .HasMany(c => c.ProductsInShop)
                .WithRequired(e => e.Shop)
                .HasForeignKey(e => e.ShopId);
        }
    }
}

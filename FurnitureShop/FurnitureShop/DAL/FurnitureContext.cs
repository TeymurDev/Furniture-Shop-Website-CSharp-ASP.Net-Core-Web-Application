using FurnitureShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FurnitureShop.DAL
{
    public class FurnitureContext : IdentityDbContext<FurnitureUser>
    {
        public FurnitureContext(DbContextOptions<FurnitureContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Bathroom", CategoryImage = "bathroom.png" },
                new Category { Id = 2, Name = "Livingroom", CategoryImage = "livingroom.png" },
                new Category { Id = 3, Name = "Bedroom", CategoryImage = "bedroom.png" },
                new Category { Id = 4, Name = "Kitchen", CategoryImage = "kitchen.png" }
            );

            modelBuilder.Entity<Product>().HasData(
             new Product { Id = 1, Name = "Green Kitchen Chair", Price = 150, HasDiscount = true, DiscountedPrice = 100, Height = 508, Width = 128, Length = 58, CategoryId = 4 },
             new Product { Id = 2, Name = "Orange Kitchen Chair", Price = 130, HasDiscount = true, DiscountedPrice = 90, Height = 408, Width = 118, Length = 40, CategoryId = 4 },
             new Product { Id = 3, Name = "Yellow Kitchen Chair", Price = 100, HasDiscount = true, DiscountedPrice = 80, Height = 510, Width = 111, Length = 30, CategoryId = 4 },
             new Product { Id = 4, Name = "Livingroom Chair", Price = 250, HasDiscount = false, DiscountedPrice = 0, Height = 500, Width = 128, Length = 58, CategoryId = 2 },
             new Product { Id = 5, Name = "Comfortable Bathroom Chair", Price = 200, HasDiscount = true, DiscountedPrice = 180, Height = 508, Width = 128, Length = 58, CategoryId = 1 },
             new Product { Id = 6, Name = "Green Bedroom Chair", Price = 160, HasDiscount = false, DiscountedPrice = 0, Height = 508, Width = 128, Length = 58, CategoryId = 3 },
             new Product { Id = 7, Name = "Bathroom Chair", Price = 70, HasDiscount = false, DiscountedPrice = 0, Height = 508, Width = 128, Length = 58, CategoryId = 1 },
             new Product { Id = 8, Name = "Red Kitchen Chair", Price = 170, HasDiscount = true, DiscountedPrice = 140, Height = 508, Width = 128, Length = 58, CategoryId = 4 }
         );

            modelBuilder.Entity<Image>().HasData(
       new Image { Id = 1, MainImage = "product_1.png", ProductId = 1 },
       new Image { Id = 2, MainImage = "product_1.png", ProductId = 1 },
       new Image { Id = 3, MainImage = "product_1.png", ProductId = 1 },
       new Image { Id = 4, MainImage = "product_1.png", ProductId = 1 },
       new Image { Id = 5, MainImage = "product_2.png", ProductId = 2 },
       new Image { Id = 6, MainImage = "product_2.png", ProductId = 2 },
       new Image { Id = 7, MainImage = "product_2.png", ProductId = 2 },
       new Image { Id = 8, MainImage = "product_2.png", ProductId = 2 },
       new Image { Id = 9, MainImage = "product_3.png", ProductId = 3 },
       new Image { Id = 10, MainImage = "product_3.png", ProductId = 3 },
       new Image { Id = 11, MainImage = "product_3.png", ProductId = 3 },
       new Image { Id = 12, MainImage = "product_3.png", ProductId = 3 },
       new Image { Id = 13, MainImage = "product_4.png", ProductId = 4 },
       new Image { Id = 14, MainImage = "product_4.png", ProductId = 4 },
       new Image { Id = 15, MainImage = "product_4.png", ProductId = 4 },
       new Image { Id = 16, MainImage = "product_4.png", ProductId = 4 },
       new Image { Id = 17, MainImage = "product_5.png", ProductId = 5 },
       new Image { Id = 18, MainImage = "product_5.png", ProductId = 5 },
       new Image { Id = 19, MainImage = "product_5.png", ProductId = 5 },
       new Image { Id = 20, MainImage = "product_5.png", ProductId = 5 },
       new Image { Id = 21, MainImage = "product_6.png", ProductId = 6 },
       new Image { Id = 22, MainImage = "product_6.png", ProductId = 6 },
       new Image { Id = 23, MainImage = "product_6.png", ProductId = 6 },
       new Image { Id = 24, MainImage = "product_6.png", ProductId = 6 },
       new Image { Id = 25, MainImage = "product_7.png", ProductId = 7 },
       new Image { Id = 26, MainImage = "product_7.png", ProductId = 7 },
       new Image { Id = 27, MainImage = "product_7.png", ProductId = 7 },
       new Image { Id = 28, MainImage = "product_7.png", ProductId = 7 },
       new Image { Id = 29, MainImage = "product_8.png", ProductId = 8 },
       new Image { Id = 30, MainImage = "product_8.png", ProductId = 8 },
       new Image { Id = 31, MainImage = "product_8.png", ProductId = 8 },
       new Image { Id = 32, MainImage = "product_8.png", ProductId = 8 }
   );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
    }
}

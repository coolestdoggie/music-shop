using Microsoft.EntityFrameworkCore;
using MusicShop.Models.Models;

namespace MusicShop.DataAccess.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Keyboards",
                    DisplayOrder = 31
                },
                new Category
                {
                    Id = 2,
                    Name = "Guitars",
                    DisplayOrder = 32
                },
                new Category
                {
                    Id = 3,
                    Name = "Drums and Percussion",
                    DisplayOrder = 33
                },
                new Category
                {
                    Id = 4,
                    Name = "String Instruments",
                    DisplayOrder = 34
                },
                new Category
                {
                    Id = 5,
                    Name = "Bass Guitars",
                    DisplayOrder = 35
                },
                new Category
                {
                    Id = 6,
                    Name = "Microphones",
                    DisplayOrder = 36
                },
                new Category
                {
                    Id = 7,
                    Name = "Headphones",
                    DisplayOrder = 37
                },
                new Category
                {
                    Id = 8,
                    Name = "Accessories",
                    DisplayOrder = 38
                }
                );
        
                modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Piano",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    CategoryId = 1,
                    ImageUrl = "",
                    ListPrice = 99
                },
                new Product
                {
                    Id = 2,
                    Name = "Electro guitar",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    CategoryId = 2,
                    ImageUrl = "",
                    ListPrice = 40
                },
                new Product
                {
                    Id = 3,
                    Name = "Drums",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    CategoryId = 3,
                    ImageUrl = "",
                    ListPrice = 55
                },
                new Product
                {
                    Id = 4,
                    Name = "Cello",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    CategoryId = 4,
                    ImageUrl = "\"C:\\Users\\coole\\Downloads\\39-min.png\"",
                    ListPrice = 70
                }
                );
        }

    }
}

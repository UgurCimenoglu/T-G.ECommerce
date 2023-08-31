using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using T_G.ECommerce.Core.Entities;
using T_G.ECommerce.Entities.Concrete;

namespace T_G.ECommerce.DataAccess.Context
{
    public class ECommerceDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TGECommerce;Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Guid laptopGuid = Guid.NewGuid();
            Guid bookGuid = Guid.NewGuid();
            Guid shoeGuid = Guid.NewGuid();
            Guid cosmeticGuid = Guid.NewGuid();
            Guid furnitureGuid = Guid.NewGuid();


            modelBuilder.Entity<Category>().HasData(
                new Category { Id = laptopGuid, Name = "Laptop", CreatedDate = DateTime.Now, UpdatedDate = null },
                new Category { Id = bookGuid, Name = "Book", CreatedDate = DateTime.Now, UpdatedDate = null },
                new Category { Id = shoeGuid, Name = "Shoe", CreatedDate = DateTime.Now, UpdatedDate = null },
                new Category { Id = cosmeticGuid, Name = "Cosmetic", CreatedDate = DateTime.Now, UpdatedDate = null },
                new Category { Id = furnitureGuid, Name = "Furniture", CreatedDate = DateTime.Now, UpdatedDate = null }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), CategoryId = laptopGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Laptop 1", Price = 7999, Stock = 500, Description = "Laptop description", Rating = 4.2M },
                new Product() { Id = Guid.NewGuid(), CategoryId = laptopGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Laptop 2", Price = 8999, Stock = 400, Description = "Laptop description", Rating = 4.3M },
                new Product() { Id = Guid.NewGuid(), CategoryId = laptopGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Laptop 3", Price = 9999, Stock = 300, Description = "Laptop description", Rating = 4.6M },
                new Product() { Id = Guid.NewGuid(), CategoryId = laptopGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Laptop 4", Price = 10999, Stock = 250, Description = "Laptop description", Rating = 3.7M },
                new Product() { Id = Guid.NewGuid(), CategoryId = laptopGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Laptop 5", Price = 11999, Stock = 350, Description = "Laptop description", Rating = 4.3M },
                new Product() { Id = Guid.NewGuid(), CategoryId = laptopGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Laptop 6", Price = 12999, Stock = 570, Description = "Laptop description", Rating = 4.5M },
                new Product() { Id = Guid.NewGuid(), CategoryId = laptopGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Laptop 7", Price = 13999, Stock = 670, Description = "Laptop description", Rating = 2.8M },
                new Product() { Id = Guid.NewGuid(), CategoryId = laptopGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Laptop 8", Price = 14999, Stock = 580, Description = "Laptop description", Rating = 3.6M },
                new Product() { Id = Guid.NewGuid(), CategoryId = laptopGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Laptop 9", Price = 15999, Stock = 940, Description = "Laptop description", Rating = 4.7M },
                new Product() { Id = Guid.NewGuid(), CategoryId = laptopGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Laptop 10", Price = 16999, Stock = 130, Description = "Laptop description", Rating = 4.2M },

                new Product() { Id = Guid.NewGuid(), CategoryId = bookGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Book 1", Price = 50, Stock = 500, Description = "Book description", Rating = 4.2M },
                new Product() { Id = Guid.NewGuid(), CategoryId = bookGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Book 2", Price = 60, Stock = 400, Description = "Book description", Rating = 4.3M },
                new Product() { Id = Guid.NewGuid(), CategoryId = bookGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Book 3", Price = 70, Stock = 300, Description = "Book description", Rating = 4.6M },
                new Product() { Id = Guid.NewGuid(), CategoryId = bookGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Book 4", Price = 75, Stock = 250, Description = "Book description", Rating = 3.7M },
                new Product() { Id = Guid.NewGuid(), CategoryId = bookGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Book 5", Price = 25, Stock = 350, Description = "Book description", Rating = 4.3M },
                new Product() { Id = Guid.NewGuid(), CategoryId = bookGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Book 6", Price = 20, Stock = 570, Description = "Book description", Rating = 4.5M },
                new Product() { Id = Guid.NewGuid(), CategoryId = bookGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Book 7", Price = 130, Stock = 670, Description = "Book description", Rating = 2.8M },
                new Product() { Id = Guid.NewGuid(), CategoryId = bookGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Book 8", Price = 250, Stock = 580, Description = "Book description", Rating = 3.6M },
                new Product() { Id = Guid.NewGuid(), CategoryId = bookGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Book 9", Price = 300, Stock = 940, Description = "Book description", Rating = 4.7M },
                new Product() { Id = Guid.NewGuid(), CategoryId = bookGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Book 10", Price = 199, Stock = 130, Description = "Book description", Rating = 4.2M },

            new Product() { Id = Guid.NewGuid(), CategoryId = shoeGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Shoe 1", Price = 500, Stock = 500, Description = "Shoe description", Rating = 4.2M },
            new Product() { Id = Guid.NewGuid(), CategoryId = shoeGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Shoe 2", Price = 600, Stock = 400, Description = "Shoe description", Rating = 4.3M },
            new Product() { Id = Guid.NewGuid(), CategoryId = shoeGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Shoe 3", Price = 700, Stock = 300, Description = "Shoe description", Rating = 4.6M },
            new Product() { Id = Guid.NewGuid(), CategoryId = shoeGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Shoe 4", Price = 750, Stock = 250, Description = "Shoe description", Rating = 3.7M },
            new Product() { Id = Guid.NewGuid(), CategoryId = shoeGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Shoe 5", Price = 250, Stock = 350, Description = "Shoe description", Rating = 4.3M },
            new Product() { Id = Guid.NewGuid(), CategoryId = shoeGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Shoe 6", Price = 200, Stock = 570, Description = "Shoe description", Rating = 4.5M },
            new Product() { Id = Guid.NewGuid(), CategoryId = shoeGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Shoe 7", Price = 1300, Stock = 670, Description = "Shoe description", Rating = 2.8M },
            new Product() { Id = Guid.NewGuid(), CategoryId = shoeGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Shoe 8", Price = 2500, Stock = 580, Description = "Shoe description", Rating = 3.6M },
            new Product() { Id = Guid.NewGuid(), CategoryId = shoeGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Shoe 9", Price = 3000, Stock = 940, Description = "Shoe description", Rating = 4.7M },
            new Product() { Id = Guid.NewGuid(), CategoryId = shoeGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Shoe 10", Price = 1990, Stock = 130, Description = "Shoe description", Rating = 4.2M },

            new Product() { Id = Guid.NewGuid(), CategoryId = cosmeticGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Cosmetic 1", Price = 100, Stock = 500, Description = "Cosmetic description", Rating = 4.2M },
            new Product() { Id = Guid.NewGuid(), CategoryId = cosmeticGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Cosmetic 2", Price = 70, Stock = 400, Description = "Cosmetic description", Rating = 4.3M },
            new Product() { Id = Guid.NewGuid(), CategoryId = cosmeticGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Cosmetic 3", Price = 80, Stock = 300, Description = "Cosmetic description", Rating = 4.6M },
            new Product() { Id = Guid.NewGuid(), CategoryId = cosmeticGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Cosmetic 4", Price = 40, Stock = 250, Description = "Cosmetic description", Rating = 3.7M },
            new Product() { Id = Guid.NewGuid(), CategoryId = cosmeticGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Cosmetic 5", Price = 150, Stock = 350, Description = "Cosmetic description", Rating = 4.3M },
            new Product() { Id = Guid.NewGuid(), CategoryId = cosmeticGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Cosmetic 6", Price = 200, Stock = 570, Description = "Cosmetic description", Rating = 4.5M },
            new Product() { Id = Guid.NewGuid(), CategoryId = cosmeticGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Cosmetic 7", Price = 300, Stock = 670, Description = "Cosmetic description", Rating = 2.8M },
            new Product() { Id = Guid.NewGuid(), CategoryId = cosmeticGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Cosmetic 8", Price = 200, Stock = 580, Description = "Cosmetic description", Rating = 3.6M },
            new Product() { Id = Guid.NewGuid(), CategoryId = cosmeticGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Cosmetic 9", Price = 300, Stock = 940, Description = "Cosmetic description", Rating = 4.7M },
            new Product() { Id = Guid.NewGuid(), CategoryId = cosmeticGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Cosmetic 10", Price = 190, Stock = 130, Description = "Cosmetic description", Rating = 4.2M },

            new Product() { Id = Guid.NewGuid(), CategoryId = furnitureGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Furniture 1", Price = 1000, Stock = 500, Description = "Furniture description", Rating = 4.2M },
            new Product() { Id = Guid.NewGuid(), CategoryId = furnitureGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Furniture 2", Price = 700, Stock = 400, Description = "Furniture description", Rating = 4.3M },
            new Product() { Id = Guid.NewGuid(), CategoryId = furnitureGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Furniture 3", Price = 800, Stock = 300, Description = "Furniture description", Rating = 4.6M },
            new Product() { Id = Guid.NewGuid(), CategoryId = furnitureGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Furniture 4", Price = 450, Stock = 250, Description = "Furniture description", Rating = 3.7M },
            new Product() { Id = Guid.NewGuid(), CategoryId = furnitureGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Furniture 5", Price = 1550, Stock = 350, Description = "Furniture description", Rating = 4.3M },
            new Product() { Id = Guid.NewGuid(), CategoryId = furnitureGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Furniture 6", Price = 2050, Stock = 570, Description = "Furniture description", Rating = 4.5M },
            new Product() { Id = Guid.NewGuid(), CategoryId = furnitureGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Furniture 7", Price = 3500, Stock = 670, Description = "Furniture description", Rating = 2.8M },
            new Product() { Id = Guid.NewGuid(), CategoryId = furnitureGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Furniture 8", Price = 2500, Stock = 580, Description = "Furniture description", Rating = 3.6M },
            new Product() { Id = Guid.NewGuid(), CategoryId = furnitureGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Furniture 9", Price = 3500, Stock = 940, Description = "Furniture description", Rating = 4.7M },
            new Product() { Id = Guid.NewGuid(), CategoryId = furnitureGuid, CreatedDate = DateTime.Now, UpdatedDate = null, Name = "Furniture 10", Price = 1950, Stock = 130, Description = "Furniture description", Rating = 4.2M }
            );

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var datas = ChangeTracker.Entries<Entity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            var datas = ChangeTracker.Entries<Entity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }
            return base.SaveChanges();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Data
{
    public class ShopOnlineDbContext:DbContext
    {
        public ShopOnlineDbContext(DbContextOptions<ShopOnlineDbContext> options):base(options)
        { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Products
            //Beauty Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "CeraVe - Gel de curatare",
                Description = "Gel de curatare de la CeraVe pentru tenul sensibil.",
                ImageURL = "/Images/Beauty/Beauty1.jpg",
                Price = 40,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "CeraVe - Crema hidratanta",
                Description = "Crema hidratanta de la CeraVe pentru ten uscat.",
                ImageURL = "/Images/Beauty/Beauty2.jpg",
                Price = 50,
                Qty = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Avene - SPF",
                Description = "Crema cu factor de protectie 50 de la Avene.",
                ImageURL = "/Images/Beauty/Beauty3.png",
                Price = 70,
                Qty = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Spray Victoria Secrets",
                Description = "Spray parfumat de corp de la Victoria Secrets.",
                ImageURL = "/Images/Beauty/Beauty4.jpg",
                Price = 100,
                Qty = 60,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "SVR - SPF",
                Description = "Crema cu factor de protectie 50 de la SVR.",
                ImageURL = "/Images/Beauty/Beauty5.jpg",
                Price = 50,
                Qty = 85,
                CategoryId = 1

            });
            //Electronics Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Casti JBL",
                Description = "Casti JBL roz",
                ImageURL = "/Images/Electronic/Electronics1.jpg",
                Price = 350,
                Qty = 120,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Casti JBL",
                Description = "Casti JBL negre",
                ImageURL = "/Images/Electronic/Electronics2.jpg",
                Price = 400,
                Qty = 200,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Casti JBL",
                Description = "Casti JBL mov",
                ImageURL = "/Images/Electronic/Electronics3.jpg",
                Price = 350,
                Qty = 300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Aparat Canon",
                Description = "Aparat profesional Canon",
                ImageURL = "/Images/Electronic/Electronic4.jpg",
                Price = 3000,
                Qty = 20,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Instant Camera",
                Description = "Camera de facut poze instant",
                ImageURL = "/Images/Electronic/Electronic5.jpg",
                Price = 500,
                Qty = 15,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Camera instant Canon",
                Description = "Camera de facut poze instant Canon",
                ImageURL = "/Images/Electronic/technology6.jpg",
                Price = 400,
                Qty = 60,
                CategoryId = 3
            });
            //Furniture Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Canapea roz",
                Description = "Canapea eleganta roz",
                ImageURL = "/Images/Furniture/Furniture1.jpg",
                Price = 5000,
                Qty = 212,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Canapea bej",
                Description = "Canapea sufragerie bej",
                ImageURL = "/Images/Furniture/Furniture2.jpg",
                Price = 2550,
                Qty = 112,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Canapea roz",
                Description = "Canapea sufragerie roz",
                ImageURL = "/Images/Furniture/Furniture3.jpg",
                Price = 3000,
                Qty = 90,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Canapea neagra",
                Description = "Canapea eleganta neagra",
                ImageURL = "/Images/Furniture/Furniture4.jpg",
                Price = 1200,
                Qty = 95,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Canapea alba",
                Description = "Canapea alba pentru hol",
                ImageURL = "/Images/Furniture/Furniture6.jpg",
                Price = 1500,
                Qty = 100,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Canapea albastra",
                Description = "Canapea albastra pentru hol/sufragerie",
                ImageURL = "/Images/Furniture/Furniture7.jpg",
                Price = 2000,
                Qty = 73,
                CategoryId = 2
            });
            //Shoes Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Nike Adidasi roz",
                Description = "Nike shoes roz pentru femei",
                ImageURL = "/Images/Shoes/Shoes1.jpg",
                Price = 250,
                Qty = 50,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Nike Adidasi albi",
                Description = "Nike shoes albi pentru femei",
                ImageURL = "/Images/Shoes/Shoes2.jpg",
                Price = 150,
                Qty = 60,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Nike Adidasi roz inchis",
                Description = "Nike shoes roz inchis pentru femei",
                ImageURL = "/Images/Shoes/Shoes3.jpg",
                Price = 200,
                Qty = 70,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "Nike Adidasi roz",
                Description = "Nike pinky shoes pentru femei",
                ImageURL = "/Images/Shoes/Shoes4.jpg",
                Price = 120,
                Qty = 120,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "Nike Adidasi alb si verde",
                Description = "Nike shoes albi cu logo verde pentru femei",
                ImageURL = "/Images/Shoes/Shoes5.jpg",
                Price = 200,
                Qty = 100,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "Nike Adidasi portocalii",
                Description = "Nike shoes roz cu portocaliu pentru femei",
                ImageURL = "/Images/Shoes/Shoes6.jpg",
                Price = 500,
                Qty = 150,
                CategoryId = 4
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Andrei"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Ana"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Beauty"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Furniture"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Electronics"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Shoes"
            });
        }
    
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

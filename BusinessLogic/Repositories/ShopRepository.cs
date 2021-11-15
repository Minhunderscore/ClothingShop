using ClothingShop.BusinessLogic.Repositories.Interfaces;
using ClothingShop.Entity.Data;
using ClothingShop.Entity.Entities;
using System;
using System.Linq;

namespace ClothingShop.BusinessLogic.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private readonly ShopContext _db;

        public ShopRepository(ShopContext db)
        {
            _db = db;
        }

        public void Testing()
        {
            _db.Product.Add(new Product
            {
                ProductId = 999999,
                Name = "T-shirt",
                Image = "some img",
                Price = 50000,
                Discount = 10.5m,
                Description = "some description",
                CreateTime = DateTime.Now,
                LastModified = DateTime.Now
            });

            _db.SaveChanges();

            Console.WriteLine("ok");

            _db.Product.ToList().ForEach(p =>
            {
                Console.WriteLine("ok");
                Console.WriteLine(p.ProductId);
                Console.WriteLine(p.Name);
            });
        }
    }
}
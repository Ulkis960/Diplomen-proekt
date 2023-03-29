using Motorex.Abstraction;
using Motorex.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Motorex.Domain;

namespace Motorex.Services
{
    public class MotorService : IMotorService
    {
        private readonly ApplicationDbContext _context;

        public MotorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Create(string model, int brandId, int categoryId, string typeEngine, string picture, int quantity, decimal price, decimal discount)
        {
            Motor item = new Motor
            {
                MotorName = model,
                Brand = _context.Brands.Find(brandId),
                Category = _context.Categories.Find(categoryId),
                Picture = picture,
                Quantity = quantity,
                Price = price,
                Discount = discount
            };
            _context.Motors.Add(item);
            return _context.SaveChanges() != 0;
        }

        public Motor GetProductById(int productId)
        {
            return _context.Motors.Find(productId);
        }

        public List<Motor> GetProducts()
        {
            List<Motor> Motors = _context.Motors.ToList();
            return Motors;
        }

        public List<Motor> GetProducts(string searchStringCategoryName, string searchStringBrandName)
        {
            List<Motor> motors = _context.Motors.ToList();

            if (!String.IsNullOrEmpty(searchStringCategoryName) && !String.IsNullOrEmpty(searchStringBrandName))
            {
                motors = motors.Where(x => x.Category.CategoryName.ToLower().Contains(searchStringCategoryName.ToLower())
                && x.Brand.BrandName.ToLower().Contains(searchStringBrandName)).ToList();
            }
            else if (!String.IsNullOrEmpty(searchStringCategoryName))
            {
                motors = motors.Where(x => x.Category.CategoryName.ToLower().Contains(searchStringCategoryName.ToLower())).ToList();
            }
            else if (!String.IsNullOrEmpty(searchStringBrandName))
            {
                motors = motors.Where(x => x.Brand.BrandName.ToLower().Contains(searchStringBrandName)).ToList();
            }

            return motors;
        }

        public bool RemoveById(int productId)
        {
            var motor = GetProductById(productId);
            if (motor == default(Motor))
            { return false; }

            _context.Remove(motor);
            return _context.SaveChanges() != 0;
        }

        public bool Update(int MotorId, string model, int brandId, int categoryId, string typeEngine, string picture, int quantity, decimal price, decimal discount)
        {
            var product = GetProductById(MotorId);
            if (product == default(Motor))
            { return false; }
            product.MotorName = model;

            product.BrandId = brandId;
            product.CategoryId = categoryId;

            product.Brand = _context.Brands.Find(brandId);
            product.Category = _context.Categories.Find(categoryId);

            product.Picture = picture;
            product.Quantity = quantity;
            product.Price = price;
            product.Discount = discount;

            _context.Update(product);
            return _context.SaveChanges() != 0;
        }      
    }
}

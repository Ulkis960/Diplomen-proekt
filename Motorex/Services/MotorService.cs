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
            throw new NotImplementedException();
        }

        public Motor GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Motor> GetProducts()
        {
            throw new NotImplementedException();
        }

        public List<Motor> GetProducts(string searchStringCategoryName, string searchStringBrandName)
        {
            throw new NotImplementedException();
        }

        public bool RemoveById(int productId)
        {
            throw new NotImplementedException();
        }

        public bool Update(int Id, string model, int brandId, int categoryId, string typeEngine, string picture, int quantity, decimal price, decimal discount)
        {
            throw new NotImplementedException();
        }      
    }
}

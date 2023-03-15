using Motorex.Abstraction;
using Motorex.Data;
using Motorex.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Motorex.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.Find(categoryId);
        }
        public List<Category> GetCategories()
        {
            List<Category> categories = _context.Categories.ToList();
            return categories;
        }
        public List<Motor> GetProductsByCategory(int categoryId)
        {
            return _context.Motors
                .Where(x => x.CategoryId == categoryId)
                .ToList();
        }
    }
}

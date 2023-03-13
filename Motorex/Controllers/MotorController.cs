using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motorex.Abstraction;
using Motorex.Domain;
using Motorex.Models.Brand;
using Motorex.Models.Category;
using Motorex.Models.Motor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopDemo.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class ProductController : Controller
    {
        private readonly IMotorService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;

        public ProductController(IMotorService productService, ICategoryService categoryService, IBrandService brandService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _brandService = brandService;
        }

        [AllowAnonymous]
        public ActionResult Index(string searchStringCategoryName, string searchStringBrandName)
        {
            List<MotorIndexVM> products = _productService.GetProducts(searchStringCategoryName, searchStringBrandName)
                .Select(product => new MotorIndexVM
                {
                    Id = product.Id,
                    Model = product.MotorName,
                    BrandId = product.BrandId,
                    Brand = product.Brand.BrandName,
                    CategoryId = product.CategoryId,
                    Category = product.Category.CategoryName,
                    Picture = product.Picture,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    Discount = product.Discount,
                }).ToList();
            return this.View(products);
        }
        public ActionResult Create()
        {
            var product = new MotorCreateVM();
            product.Brands = _brandService.GetBrands()
                .Select(x => new BrandPairVM()
                {
                    Id = x.Id,
                    Name = x.BrandName
                }).ToList();
            product.Categories = _categoryService.GetCategories()
                .Select(x => new CategoryPairVM()
                {
                    Id = x.Id,
                    Name = x.CategoryName
                }).ToList();
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] MotorCreateVM product)
        {
            if (ModelState.IsValid)
            {
                var createdId = _productService.Create(product.Model,
                    product.Brand, product.CategoryId, product.Picture,
                    product.Quantity, product.Price, product.Discount);

                if ((bool)createdId)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            Motor product = _productService.GetProductById(id);
            if (product == null)
            { return NotFound(); }

            MotorEditVM updatedProduct = new MotorEditVM()
            {
                Id = product.Id,
                Model = product.Model,
                Brand = product.BrandId,
                CategoryId = product.CategoryId,
                Picture = product.Picture,
                Quantity = product.Quantity,
                Price = product.Price,
                Discount = product.Discount
            };

            updatedProduct.Brands = _brandService.GetBrands()
                .Select(b => new BrandPairVM()
                {
                    Id = b.Id,
                    Name = b.BrandName
                }).ToList();

            updatedProduct.Categories = _categoryService.GetCategories()
                .Select(c => new CategoryPairVM()
                {
                    Id = c.Id,
                    Name = c.CategoryName
                }).ToList();
            return View(updatedProduct);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MotorEditVM product)
        {
            if (ModelState.IsValid)
            {
                var updated = _productService.Update(id, product.Model, product.Brand,
                    product.CategoryId, product.Picture, product.Quantity,
                    product.Price, product.Discount);

                if ((bool)updated)
                {
                    return this.RedirectToAction("Index");
                }
            }
            return View(product);
        }

        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            Motor item = _productService.GetProductById(id);
            if (item == null)
            {
                return NotFound();
            }
            MotorDetailsVM product = new MotorDetailsVM()
            {
                Id = item.Id,
                Model = item.Model,
                BrandId = item.BrandId,
                Brand = item.Brand.BrandName,
                CategoryId = item.CategoryId,
                Category = item.Category.CategoryName,
                Picture = item.Picture,
                Quantity = item.Quantity,
                Price = item.Price,
                Discount = item.Discount
            };
            return View(product);
        }

        public ActionResult Delete(int id)
        {
            Motor product = _productService.GetProductById(id);
            if (product == null)
            { return NotFound(); }

            MotorDeleteVM productDelete = new MotorDeleteVM()
            {
                Id = product.Id,
                Model = product.Model,
                BrandId = product.BrandId,
                Brand = product.Brand.BrandName,
                CategoryId = product.CategoryId,
                Category = product.Category.CategoryName,
                Picture = product.Picture,
                Quantity = product.Quantity,
                Price = product.Price,
                Discount = product.Discount
            };
            return View(productDelete);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var deleted = _productService.RemoveById(id);
            if (deleted)
            {
                return this.RedirectToAction("Index");
            }
            else { return View(); }
        }
    }
}

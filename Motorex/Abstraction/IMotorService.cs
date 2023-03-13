﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Motorex.Domain;


namespace Motorex.Abstraction
{
    public interface IMotorService
    {
        bool Create(int Id, int model, string brandId, int categoryId, string typeEngine, string picture, int quantity, decimal price, decimal discount);
        bool Update(int Id, int model, string brand, int categoryId, string typeEngine, string picture, int quantity, decimal price, decimal discount);
        List<Motor> GetProducts();
        Motor GetProductById(int productId);
        bool RemoveById(int productId);
        List<Motor> GetProducts(string searchStringCategoryName, string searchStringBrandName);
        object Update(int id, string model, int brand, int categoryId, string picture, int quantity, decimal price, decimal discount);
        object Create(string model, int brand, int categoryId, string picture, int quantity, decimal price, decimal discount);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Motorex.Domain;

namespace Motorex.Abstraction
{
    public interface IBrandService
    {
        List<Brand> GetBrands();
        Brand GetBrandById(int categoryId);
        List<Motor> GetProductsByBrand(int categoryId);
    }
}

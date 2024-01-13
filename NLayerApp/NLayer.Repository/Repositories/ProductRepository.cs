﻿using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using NLayer.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsWithCayegory()
        {
            //Eager Loading 
            //* Datayı çekerken kategorilerin alınması
            return await _context.Products.Include(X=>X.Category).ToListAsync();
        }
    }
}

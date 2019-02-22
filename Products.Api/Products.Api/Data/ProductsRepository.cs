using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Products.Api.DTO;
using Products.Api.Models;

namespace Products.Api.Data
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly DataContext _context;
        public ProductsRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Guid> AddProduct(ProductCreateInputModel model)
        {
            Product product = new Product
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Price = (decimal)model.Price
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }

        public async Task<bool> DeleteProduct(Guid Id)
        {
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == Id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Product> GetProduct(Guid Id)
        {
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == Id);
            return product;
        }

        public async Task<List<Product>> GetProducts()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return products;
        }

        public async Task<bool> UpdateProduct(ProductUpdateInputModel model)
        {
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == model.Id);
            product.Name = model.Name;
            product.Price = (decimal)model.Price;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

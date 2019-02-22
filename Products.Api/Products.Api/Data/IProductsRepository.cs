using Products.Api.DTO;
using Products.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Api.Data
{
    public interface IProductsRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(Guid Id);
        Task<Guid> AddProduct(ProductCreateInputModel model);
        Task<bool> UpdateProduct(ProductUpdateInputModel model);
        Task<bool> DeleteProduct(Guid Id);
    }
}

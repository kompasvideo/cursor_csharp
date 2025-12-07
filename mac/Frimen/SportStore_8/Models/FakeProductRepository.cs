using System.Collections.Generic;
using System.Linq;
namespace SportStore_08.Models;
public class FakeProductRepository : IProductRepository
{
    public IQueryable<Product> Products => new List<Product>
    {
        new Product { ProductId = 1, Name = "Football", Price = 25},
        new Product { ProductId = 2, Name = "Surf board", Price = 179},
        new Product { ProductId = 3, Name = "Running shoes", Price = 95},
    }.AsQueryable<Product>();
}
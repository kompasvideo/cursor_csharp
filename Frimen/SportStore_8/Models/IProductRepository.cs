using System.Linq;

namespace SportStore_08.Models;
public interface IProductRepository
{
    IQueryable<Product> Products { get; }
}
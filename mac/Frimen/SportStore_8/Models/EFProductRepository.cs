using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SportStore_08.Models;
public class EFProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;
    public EFProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public IQueryable<Product> Products => _context.Products;
}
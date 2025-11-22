using Microsoft.EntityFrameworkCore;
namespace SportStore_08.Models;
public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}
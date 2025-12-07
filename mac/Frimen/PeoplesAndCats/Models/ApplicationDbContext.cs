using Microsoft.EntityFrameworkCore;
namespace PeoplesAndCats.Models;
public class ApplicationDbContext : DbContext
{
    public DbSet<People> Peoples { get; set; }
    public DbSet<Cat> Cats { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}
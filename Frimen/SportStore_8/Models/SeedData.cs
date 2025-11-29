using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SportStore_08.Models;
public static class SeedData
{
    public static void EnsurePopulated(IApplicationBuilder app)
    {
        ApplicationDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();
        if (context.Database.GetPendingMigrations().Any())
        {
            context.Database.Migrate();
        }
        if (!context.Products.Any())
        {
            context.Products.AddRange(
                new Product { 
                  Name = "Kayak",
                  Description = "A boat for one person",
                  Category = "Watersports",
                  Price = 275 },
                new Product { 
                  Name = "Lifejacket",
                  Description = "Protective and fashionable",
                  Category = "Watersports",
                  Price = 48.95m },
                new Product { 
                  Name = "Soccer ball", 
                  Description = "FIFA-approved size and weight",
                  Category = "Soccer",
                  Price = 19.50m },
                new Product { 
                  Name = "Corner flags",
                  Description = "Give your playing field a professional touch",
                  Category = "Soccer",
                  Price = 34.95m },
                new Product { 
                  Name = "Stadium",
                  Description = "Flat-packed 35,000-seat stadium",
                  Category = "Soccer",
                  Price = 79500 },
                new Product { 
                  Name = "Thinking cap",
                  Description = "Improve your brain efficiency by 75%",
                  Category = "Chess",
                  Price = 16 },
                new Product { 
                  Name = "Unsteady Chair",
                  Description = "Secretly give your opponent a disadvantage",
                  Category = "Chess",
                  Price = 29.95m },
                new Product { 
                  Name = "Human Chess Board",
                  Description = "A fun game for the whole family",
                  Category = "Chess",
                  Price = 75 },
                new Product { 
                  Name = "Bling-Bling King",
                  Description = "Gold-plated, diamond-studded King",
                  Category = "Chess",
                  Price = 1200 }
            );
            context.SaveChanges();
        }
    }
}
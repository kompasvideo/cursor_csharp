using Microsoft.EntityFrameworkCore;

namespace PeoplesAndCats.Models;
public static class SeedData
{
  public static void EnsurePopulated(IApplicationBuilder app)
    {
        ApplicationDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();
        if (context.Database.GetPendingMigrations().Any())
        {
            context.Database.Migrate();
        }
        if (!context.Peoples.Any())
        {
          var peoples = new List<People>();
          peoples.Add(
            new People {
               Name = "John Doe", 
               Age = 30 });
          peoples.Add(
            new People {
               Name = "Jane Doe", 
               Age = 25
            });
          var cats = new List<Cat>();
          var cat1 = new Cat {
            Name = "Cat_1",
            Age = 1
          };
          var cat2 = new Cat {
            Name = "Cat_2",
            Age = 2
          };
          var cat3 = new Cat {
            Name = "Cat_3",
            Age = 3
          };
          cats.Add(cat1);
          cats.Add(cat2);
          cats.Add(cat3);
          peoples[0].Cats.Add(cat1);
          peoples[1].Cats.Add(cat2);
          peoples[1].Cats.Add(cat3);
          context.Peoples.AddRange(peoples);
          context.Cats.AddRange(cats);
          context.SaveChanges();
        }
    }
}
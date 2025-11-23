using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeoplesAndCats.Models;

namespace PeoplesAndCats.Controllers;

public class PeopleController : Controller
{
     private readonly IPeopleRepository _repository;
     private readonly ApplicationDbContext context;

    public PeopleController(IPeopleRepository repository,
        ApplicationDbContext applicationDbContext)
    {
        _repository = repository;
        context = applicationDbContext;
    }

    public IActionResult Index()
    {
        var cats = context.Peoples
            .Include(u => u.Cats)
            .ToList();
        return View(cats);
    }
}

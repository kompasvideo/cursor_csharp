using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PeoplesAndCats.Models;

namespace PeoplesAndCats.Controllers;

public class PeopleController : Controller
{
    private readonly ILogger<PeopleController> _logger;
     private readonly IPeopleRepository _repository;
     private readonly ApplicationDbContext context;

    public PeopleController(IPeopleRepository repository, ApplicationDbContext applicationDbContext)
    {
        _repository = repository;
        context = applicationDbContext;
    }

    public IActionResult Index()
    {
        var cats = context.Peoples
            .ToList();
        return View(_repository.Peoples);
    }
}

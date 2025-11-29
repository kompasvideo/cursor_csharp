using Microsoft.AspNetCore.Mvc;
using SportStore_08.Models;

namespace SportStore_08.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository _repository;

    public ProductController(IProductRepository repository)
    {
        _repository = repository;
    }

    public ViewResult List()
    {
        return View(_repository.Products);
    }
}


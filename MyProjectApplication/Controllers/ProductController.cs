using Microsoft.AspNetCore.Mvc;
using MyProjectApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace MyProjectApplication.Controllers;

public class ProductController : Controller
{
    private readonly DataDb _context;

    public ProductController(DataDb context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        // Извлекаем список продуктов из базы данных
        var products = await _context.Products.ToListAsync();

        // Возвращаем список продуктов во View
        return View(products);
    }
}
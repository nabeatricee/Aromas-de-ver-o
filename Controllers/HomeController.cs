using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aromas_verão.Models;
using App.Context;
using App.Models;


namespace aromas_verão.Controllers;

public class HomeController : Controller
{

    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        ProdutoBannerViewModel viewModel = new ProdutoBannerViewModel
        {
            ListaProdutos = _context.Produtos.Where(p => p.MaisVendidos).ToList(),
            ListaBanners = _context.Banners.ToList()
        };
        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

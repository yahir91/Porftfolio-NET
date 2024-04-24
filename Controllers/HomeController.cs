using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using portfolio.Models;

namespace portfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    private List<Proyecto> ObtenerProyectos()
    {
        return new List<Proyecto>() { new Proyecto{
            Titulo = "Amazon",
            Descripcion = "E-commerce",
            Link = "",
            ImagenURL= ""
        }};
    }

    public IActionResult Index()
    {
        var proyectos = ObtenerProyectos();

        var modelo = new HomeIndexViewModel()
        {
            Proyectos = proyectos
        };
        return View(modelo);
    }


    public IActionResult Proyectos()
    {
        var proyectos = ObtenerProyectos();
        return View(proyectos);
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

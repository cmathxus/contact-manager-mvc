using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ContactManagerMvc.Models;

namespace ContactManagerMvc.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

}

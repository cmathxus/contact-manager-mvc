using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ContactManagerMvc.Models;

namespace ContactManagerMvc.Controllers;

public class ContatoController : Controller {
    public IActionResult Index () {
        return View();
    }

    public IActionResult Criar() {
        return View();
    }

    public IActionResult Editar() {
        return View();
    }

    public IActionResult ApagarConfirmacao() {
        return View();
    }
}

    
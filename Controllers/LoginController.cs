using VolandoYa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace VolandoYa.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        

        //te envia a la vista del login y es la primera que te envia
        public IActionResult Index()
        {
            return View();
        }

        //llega cuando se envia el formulario
        [HttpPost]
        public ActionResult Login(String user, String password)
        {
            String usuarioEncontrado = DataBase.buscarUsuario(user, password);

            if (usuarioEncontrado == null)
            {
                ModelState.AddModelError("user", "El usuario no existe ó ingreso datos inválidos");
                return View(nameof(Index));
            }
            else if (usuarioEncontrado == "user" && usuarioEncontrado == "password")
            {
                return View("Views/Home/Index.cshtml");
            }

            return View("Views/Home/Index.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using VolandoYa.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace VolandoYa.Controllers
{
    public class RegisterController : Controller
    {

        private readonly VolandoYaContext _context;

        public RegisterController(VolandoYaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult success()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // POST: RegisterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,user,email,password")] User usuario)
        {
            if (ModelState.IsValid)
            {
                var existe = _context.Usuarios.Any(usu => usu.user == usuario.user);
                if (existe)
                {
                    return View();
                }
                else
                {
                    _context.Add(usuario);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(success));
                }

            }
            return View(usuario);
        }

    }
}

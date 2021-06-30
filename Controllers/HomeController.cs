using VolandoYa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace VolandoYa.Controllers
{
    public class HomeController : Controller
    {
        private readonly VolandoYaContext _context;

        public HomeController(VolandoYaContext context)
        {
            _context = context;
        }
        // GET: HomeController
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vuelos.ToListAsync());
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

    }
}

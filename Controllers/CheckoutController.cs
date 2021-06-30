using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VolandoYa.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: CheckoutController
        public ActionResult Index(int ID)
        {
            return View();
        }


        // POST: CheckoutController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}

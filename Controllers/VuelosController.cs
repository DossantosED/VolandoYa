using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VolandoYa.Models;

namespace VolandoYa.Controllers
{
    public class VuelosController : Controller
    {
        private readonly VolandoYaContext _context;

        public VuelosController(VolandoYaContext context)
        {
            _context = context;
        }

        // GET: Vueloes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vuelos.ToListAsync());
        }

        // GET: Vueloes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vuelo = await _context.Vuelos
                .FirstOrDefaultAsync(m => m.id == id);
            if (vuelo == null)
            {
                return NotFound();
            }

            return View(vuelo);
        }

        // GET: Vueloes/Create
        public IActionResult Create()
        {
            this.CompletarViewBag(new Vuelo());
            return View();
        }

        public void CompletarViewBag(Vuelo vuelo)

        {
            ViewBag.traerAerolineas = _context.Aerolineas.ToList();
            ViewBag.traerDestinos = _context.Destinos.ToList();
            if (vuelo.Aerolinea != null)
                vuelo.id = vuelo.Aerolineas.id;
            if (vuelo.Destino != null)
                vuelo.id = vuelo.Destinos.id;
        }


        // POST: Vueloes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Destino,Aerolinea,Fecha_salida,Fecha_Vuelta,Lugares_Disponibles,Precio")] Vuelo vuelo)
        {
            if (ModelState.IsValid)
            {
                //vuelo.Aerolinea = _context.Aerolineas.FirstOrDefault(o => o.id == vuelo.idAerolinea);
                //vuelo.Destino = _context.Destinos.FirstOrDefault(o => o.id == vuelo.idDestino);
                _context.Add(vuelo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //this.CompletarViewBag(vuelo);
            return View(vuelo);
        }

        // GET: Vueloes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vuelo = await _context.Vuelos.FindAsync(id);
            if (vuelo == null)
            {
                return NotFound();
            }
            this.CompletarViewBag(new Vuelo());
            return View(vuelo);
        }

        // POST: Vueloes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Destino,Aerolinea,Fecha_salida,Fecha_Vuelta,Lugares_Disponibles,Precio")] Vuelo vuelo)
        {
            if (id != vuelo.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vuelo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VueloExists(vuelo.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vuelo);
        }

        // GET: Vueloes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vuelo = await _context.Vuelos
                .FirstOrDefaultAsync(m => m.id == id);
            if (vuelo == null)
            {
                return NotFound();
            }

            return View(vuelo);
        }

        // POST: Vueloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vuelo = await _context.Vuelos.FindAsync(id);
            _context.Vuelos.Remove(vuelo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VueloExists(int id)
        {
            return _context.Vuelos.Any(e => e.id == id);
        }
    }
}

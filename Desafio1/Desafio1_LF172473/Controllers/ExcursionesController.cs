using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Desafio1_LF172473.Data;
using Desafio1_LF172473.Models;
using System.Runtime.ExceptionServices;

namespace Desafio1_LF172473.Controllers
{
    public class ExcursionesController : Controller
    {
        private readonly ExcursionesContext _context;

        public ExcursionesController(ExcursionesContext context)
        {
            _context = context;
        }

        // GET: Excursiones
        public async Task<IActionResult> Index(string pais,string tipo , string min, string max)
        {
            _context.Database.EnsureCreated();
            var excursiones = from p in _context.Excursiones
                            select p;

            if (!String.IsNullOrEmpty(pais))
                excursiones = excursiones.Where(s => s.Pais.Contains(pais));
            if (!String.IsNullOrEmpty(tipo))
                if(tipo != "Todos")
                    excursiones = excursiones.Where(s => s.TipoDestino == tipo);
            if (String.IsNullOrEmpty(min))
                min = "0";
            if (String.IsNullOrEmpty(max))
                max = "1000";
            excursiones = excursiones.Where(s => s.CostoxPersona >= Double.Parse(min));
            excursiones = excursiones.Where(s => s.CostoxPersona <= Double.Parse(max));

            return excursiones != null ?
                View(await excursiones.ToListAsync()) :
                Problem("Entity set 'ExcursionesContext.Excursiones'  is null.");
        }

        // GET: Excursiones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Excursiones == null)
            {
                return NotFound();
            }

            var excursiones = await _context.Excursiones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (excursiones == null)
            {
                return NotFound();
            }

            return View(excursiones);
        }

        // GET: Excursiones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Excursiones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Lugar,Descripcion,CostoxPersona,Img1,Img2,Img3,Recomendacion1,Recomendacion2,Recomendacion3,Pais,TipoDestino")] Excursiones excursiones)
        {
            if (ModelState.IsValid)
            {
                _context.Add(excursiones);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(excursiones);
        }

        // GET: Excursiones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Excursiones == null)
            {
                return NotFound();
            }

            var excursiones = await _context.Excursiones.FindAsync(id);
            if (excursiones == null)
            {
                return NotFound();
            }
            return View(excursiones);
        }

        // POST: Excursiones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Lugar,Descripcion,CostoxPersona,Img1,Img2,Img3,Recomendacion1,Recomendacion2,Recomendacion3,Pais,TipoDestino")] Excursiones excursiones)
        {
            if (id != excursiones.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(excursiones);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExcursionesExists(excursiones.Id))
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
            return View(excursiones);
        }

        // GET: Excursiones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Excursiones == null)
            {
                return NotFound();
            }

            var excursiones = await _context.Excursiones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (excursiones == null)
            {
                return NotFound();
            }

            return View(excursiones);
        }

        // POST: Excursiones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Excursiones == null)
            {
                return Problem("Entity set 'ExcursionesContext.Excursiones'  is null.");
            }
            var excursiones = await _context.Excursiones.FindAsync(id);
            if (excursiones != null)
            {
                _context.Excursiones.Remove(excursiones);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExcursionesExists(int id)
        {
          return (_context.Excursiones?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

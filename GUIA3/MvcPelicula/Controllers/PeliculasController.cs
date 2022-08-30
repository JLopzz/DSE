using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcPelicula.Data;
using MvcPelicula.Models;

namespace MvcPelicula.Controllers
{
    public class PeliculasController : Controller
    {
        private readonly MvcPeliculaContext _context;

        public PeliculasController(MvcPeliculaContext context)
        {
            _context = context;
        }

        // GET: Peliculas
        public async Task<IActionResult> Index(string buscarString,string generoPelicula,string precioPelicula)
        {
            _context.Database.EnsureCreated(); //Se agrego porque no generaba automaticamente la BD

            var GeneroLst = new List<string>();
            var GeneroQry = from d in _context.Pelicula
                            orderby d.Genero
                            select d.Genero;

            GeneroLst.AddRange(GeneroQry.Distinct());
            ViewData["generoPelicula"] = new SelectList(GeneroLst);
            var peliculas = from p in _context.Pelicula
                            select p;

            var price = from p in _context.Pelicula
                        select p.Precio;

            if (!String.IsNullOrEmpty(buscarString))
            {
                peliculas = peliculas.Where(s => s.Titulo.Contains(buscarString));
            }
            if (!string.IsNullOrEmpty(generoPelicula))
            {
                peliculas = peliculas.Where(x => x.Genero == generoPelicula);
            }
            //Agregado para busqueda por precio
            if (!string.IsNullOrEmpty(precioPelicula))
            {
                peliculas = peliculas.Where(x => x.Precio == Decimal.Parse(precioPelicula));
            }

            var peliV = (from p in _context.Pelicula
                         join d in _context.Director
                         on p.Id equals d.IdPelicula
                         select new peliDirector{
                         Id = p.Id,
                         Titulo = p.Titulo,
                         Lanzamiento = p.Lanzamiento,
                         Genero = p.Genero,
                         Productor = p.Productor,
                         Director = d.Nombre});
            //Debug.WriteLine(peliV.ToListAsync());
            return View(await peliV.ToListAsync());



            /*  Metodo para busqueda por Nombre de pelicula  */
            //var peliculas = from p in _context.Pelicula
            //               select p;

            //if(!String.IsNullOrEmpty(buscarString))
            //{
            //    peliculas = peliculas.Where(s => s.Titulo.Contains(buscarString));
            //}
            //return View(await peliculas.ToListAsync());

            /*  metodo original, venia por defecto  */
            //return _context.Pelicula != null ? 
            //    View(await _context.Pelicula.ToListAsync()) :
            //    Problem("Entity set 'MvcPeliculaContext.Pelicula'  is null.");
        }

        [HttpPost]
        public string Index(FormCollection fc, string buscarString)
        {
            return "<h3> From [HttpPost] Index: " + buscarString + "</h3>";
        }

        // GET: Peliculas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pelicula == null)
            {
                return NotFound();
            }

            var pelicula = await _context.Pelicula
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pelicula == null)
            {
                return NotFound();
            }

            return View(pelicula);
        }

        // GET: Peliculas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Peliculas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Lanzamiento,Genero,Precio,Calificacion")] Pelicula pelicula)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pelicula);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pelicula);
        }

        // GET: Peliculas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pelicula == null)
            {
                return NotFound();
            }

            var pelicula = await _context.Pelicula.FindAsync(id);
            if (pelicula == null)
            {
                return NotFound();
            }
            return View(pelicula);
        }

        // POST: Peliculas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Lanzamiento,Genero,Precio,Calificacion")] Pelicula pelicula)
        {
            if (id != pelicula.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pelicula);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PeliculaExists(pelicula.Id))
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
            return View(pelicula);
        }

        // GET: Peliculas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pelicula == null)
            {
                return NotFound();
            }

            var pelicula = await _context.Pelicula
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pelicula == null)
            {
                return NotFound();
            }

            return View(pelicula);
        }

        // POST: Peliculas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pelicula == null)
            {
                return Problem("Entity set 'MvcPeliculaContext.Pelicula'  is null.");
            }
            var pelicula = await _context.Pelicula.FindAsync(id);
            if (pelicula != null)
            {
                _context.Pelicula.Remove(pelicula);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PeliculaExists(int id)
        {
          return (_context.Pelicula?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

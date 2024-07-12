using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Almacen_ASP.Models;

namespace Almacen_ASP.Controllers
{
    public class AlertumsController : Controller
    {
        private readonly AlmacenHamburgueseriaContext _context;

        public AlertumsController(AlmacenHamburgueseriaContext context)
        {
            _context = context;
        }

        // GET: Alertums
        public async Task<IActionResult> Index()
        {
            var almacenHamburgueseriaContext = _context.Alerta.Include(a => a.IdProductoNavigation);
            return View(await almacenHamburgueseriaContext.ToListAsync());
        }

        // GET: Alertums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alertum = await _context.Alerta
                .Include(a => a.IdProductoNavigation)
                .FirstOrDefaultAsync(m => m.IdAlerta == id);
            if (alertum == null)
            {
                return NotFound();
            }

            return View(alertum);
        }

        // GET: Alertums/Create
        public IActionResult Create()
        {
            ViewData["IdProducto"] = new SelectList(_context.Productos, "IdProducto", "IdProducto");
            return View();
        }

        // POST: Alertums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAlerta,IdProducto,Mensaje")] Alertum alertum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alertum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdProducto"] = new SelectList(_context.Productos, "IdProducto", "IdProducto", alertum.IdProducto);
            return View(alertum);
        }

        // GET: Alertums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alertum = await _context.Alerta.FindAsync(id);
            if (alertum == null)
            {
                return NotFound();
            }
            ViewData["IdProducto"] = new SelectList(_context.Productos, "IdProducto", "IdProducto", alertum.IdProducto);
            return View(alertum);
        }

        // POST: Alertums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAlerta,IdProducto,Mensaje")] Alertum alertum)
        {
            if (id != alertum.IdAlerta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alertum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlertumExists(alertum.IdAlerta))
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
            ViewData["IdProducto"] = new SelectList(_context.Productos, "IdProducto", "IdProducto", alertum.IdProducto);
            return View(alertum);
        }

        // GET: Alertums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alertum = await _context.Alerta
                .Include(a => a.IdProductoNavigation)
                .FirstOrDefaultAsync(m => m.IdAlerta == id);
            if (alertum == null)
            {
                return NotFound();
            }

            return View(alertum);
        }

        // POST: Alertums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alertum = await _context.Alerta.FindAsync(id);
            if (alertum != null)
            {
                _context.Alerta.Remove(alertum);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlertumExists(int id)
        {
            return _context.Alerta.Any(e => e.IdAlerta == id);
        }
    }
}

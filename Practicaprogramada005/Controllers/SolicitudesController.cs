using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Practicaprogramada005.Models;

namespace Practicaprogramada005.Controllers
{
    public class SolicitudesController : Controller
    {
        private readonly pract05Context _context;

        public SolicitudesController(pract05Context context)
        {
            _context = context;
        }

        // GET: Solicitudes
        public async Task<IActionResult> Index()
        {
            var pract05Context = _context.Solicitudes.Include(s => s.Servicios);
            return View(await pract05Context.ToListAsync());
        }

        // GET: Solicitudes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Solicitudes == null)
            {
                return NotFound();
            }

            var solicitude = await _context.Solicitudes
                .Include(s => s.Servicios)
                .FirstOrDefaultAsync(m => m.SolicitudesId == id);
            if (solicitude == null)
            {
                return NotFound();
            }

            return View(solicitude);
        }

        // GET: Solicitudes/Create
        public IActionResult Create()
        {
            ViewData["ServiciosId"] = new SelectList(_context.Servicios, "ServiciosId", "ServiciosId");
            return View();
        }

        // POST: Solicitudes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SolicitudesId,ServiciosId,Idusuario,Datsauto1,Datsauto2,Datsauto3,Datsauto4,Estadode")] Solicitude solicitude)
        {
            solicitude.Idusuario = User.Identity.Name;
            if (solicitude.Estadode != null)
            {
                _context.Add(solicitude);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ServiciosId"] = new SelectList(_context.Servicios, "ServiciosId", "ServiciosId", solicitude.ServiciosId);
            return View(solicitude);
        }

        // GET: Solicitudes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Solicitudes == null)
            {
                return NotFound();
            }

            var solicitude = await _context.Solicitudes.FindAsync(id);
            if (solicitude == null)
            {
                return NotFound();
            }
            ViewData["ServiciosId"] = new SelectList(_context.Servicios, "ServiciosId", "ServiciosId", solicitude.ServiciosId);
            return View(solicitude);
        }

        // POST: Solicitudes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SolicitudesId,ServiciosId,Idusuario,Datsauto1,Datsauto2,Datsauto3,Datsauto4,Estadode")] Solicitude solicitude)
        {
            if (id != solicitude.SolicitudesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitude);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitudeExists(solicitude.SolicitudesId))
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
            ViewData["ServiciosId"] = new SelectList(_context.Servicios, "ServiciosId", "ServiciosId", solicitude.ServiciosId);
            return View(solicitude);
        }

        // GET: Solicitudes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Solicitudes == null)
            {
                return NotFound();
            }

            var solicitude = await _context.Solicitudes
                .Include(s => s.Servicios)
                .FirstOrDefaultAsync(m => m.SolicitudesId == id);
            if (solicitude == null)
            {
                return NotFound();
            }

            return View(solicitude);
        }

        // POST: Solicitudes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Solicitudes == null)
            {
                return Problem("Entity set 'pract05Context.Solicitudes'  is null.");
            }
            var solicitude = await _context.Solicitudes.FindAsync(id);
            if (solicitude != null)
            {
                _context.Solicitudes.Remove(solicitude);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolicitudeExists(int id)
        {
          return (_context.Solicitudes?.Any(e => e.SolicitudesId == id)).GetValueOrDefault();
        }
    }
}


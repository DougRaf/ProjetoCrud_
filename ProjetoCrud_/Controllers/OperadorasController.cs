using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoCrud_.Data;
using ProjetoCrud_.Models;

namespace ProjetoCrud_.Controllers
{
    public class OperadorasController : Controller
    {
        private readonly Contexto _context;

        public OperadorasController(Contexto context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Operadoras.ToListAsync());
        }

        // GET: Operadoras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Operadoras == null)
            {
                return NotFound();
            }

            var operadoras = await _context.Operadoras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operadoras == null)
            {
                return NotFound();
            }

            return View(operadoras);
        }

        // GET: Operadoras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Operadoras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Operadora")] Operadoras operadoras)
        {
            if (ModelState.IsValid)
            {
                _context.Add(operadoras);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(operadoras);
        }

        // GET: Operadoras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Operadoras == null)
            {
                return NotFound();
            }

            var operadoras = await _context.Operadoras.FindAsync(id);
            if (operadoras == null)
            {
                return NotFound();
            }
            return View(operadoras);
        }

        // POST: Operadoras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Operadora")] Operadoras operadoras)
        {
            if (id != operadoras.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(operadoras);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperadorasExists(operadoras.Id))
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
            return View(operadoras);
        }

        // GET: Operadoras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Operadoras == null)
            {
                return NotFound();
            }

            var operadoras = await _context.Operadoras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operadoras == null)
            {
                return NotFound();
            }

            return View(operadoras);
        }

        // POST: Operadoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Operadoras == null)
            {
                return Problem("Entity set 'Contexto.Operadoras'  is null.");
            }
            var operadoras = await _context.Operadoras.FindAsync(id);
            if (operadoras != null)
            {
                _context.Operadoras.Remove(operadoras);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OperadorasExists(int id)
        {
          return (_context.Operadoras?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

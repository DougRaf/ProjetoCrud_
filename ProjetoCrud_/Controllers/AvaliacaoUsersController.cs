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
    public class AvaliacaoUsersController : Controller
    {
        private readonly Contexto _context;

        public AvaliacaoUsersController(Contexto context)
        {
            _context = context;
        }

        // GET: AvaliacaoUsers
        public async Task<IActionResult> Index()
        {
              return _context.AvaliacaoUser != null ? 
                          View(await _context.AvaliacaoUser.ToListAsync()) :
                          Problem("Entity set 'Contexto.AvaliacaoUser'  is null.");
        }

        // GET: AvaliacaoUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AvaliacaoUser == null)
            {
                return NotFound();
            }

            var avaliacaoUser = await _context.AvaliacaoUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (avaliacaoUser == null)
            {
                return NotFound();
            }

            return View(avaliacaoUser);
        }

        // GET: AvaliacaoUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AvaliacaoUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Avaliação")] AvaliacaoUser avaliacaoUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(avaliacaoUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(avaliacaoUser);
        }

        // GET: AvaliacaoUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AvaliacaoUser == null)
            {
                return NotFound();
            }

            var avaliacaoUser = await _context.AvaliacaoUser.FindAsync(id);
            if (avaliacaoUser == null)
            {
                return NotFound();
            }
            return View(avaliacaoUser);
        }

        // POST: AvaliacaoUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Avaliação")] AvaliacaoUser avaliacaoUser)
        {
            if (id != avaliacaoUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(avaliacaoUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AvaliacaoUserExists(avaliacaoUser.Id))
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
            return View(avaliacaoUser);
        }

        // GET: AvaliacaoUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AvaliacaoUser == null)
            {
                return NotFound();
            }

            var avaliacaoUser = await _context.AvaliacaoUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (avaliacaoUser == null)
            {
                return NotFound();
            }

            return View(avaliacaoUser);
        }

        // POST: AvaliacaoUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AvaliacaoUser == null)
            {
                return Problem("Entity set 'Contexto.AvaliacaoUser'  is null.");
            }
            var avaliacaoUser = await _context.AvaliacaoUser.FindAsync(id);
            if (avaliacaoUser != null)
            {
                _context.AvaliacaoUser.Remove(avaliacaoUser);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AvaliacaoUserExists(int id)
        {
          return (_context.AvaliacaoUser?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniversityProject.Data;
using UniversityProject.Models;


namespace UniversityProject.Controllers
{
    public class CurriculosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CurriculosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Curriculos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Curriculo.Include(c => c.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Curriculos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Curriculo == null)
            {
                return NotFound();
            }

            var curriculo = await _context.Curriculo
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.CurriculoID == id);
            if (curriculo == null)
            {
                return NotFound();
            }

            return View(curriculo);
        }

        // GET: Curriculos/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "ID", "ID");
            return View();
        }

        // POST: Curriculos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598
        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CurriculoID,FirstName,LastName,PhoneNumber,Address,City,PostalCode,Estate,Objetive,UsuarioId")] Curriculo curriculo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(curriculo);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                ViewData["UsuarioId"] = new SelectList(_context.Usuario, "ID", "ID", curriculo.UsuarioId);
                return View(curriculo);
            }
            catch (Exception ex)
            {
                // Registre a exceção para fins de depuração.
                // Você pode usar o mecanismo de log ou simplesmente exibi-la no console.
                Console.WriteLine(ex);
                Console.WriteLine("ERRO");
              
                // Redirecione para uma página de erro ou faça outra ação adequada em caso de exceção.
                // Por exemplo, você pode redirecionar para uma página de erro personalizada.
                return View("Erro"); // Página de erro personalizada
            }
        }
        // GET: Curriculos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Curriculo == null)
            {
                return NotFound();
            }

            var curriculo = await _context.Curriculo.FindAsync(id);
            if (curriculo == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "ID", "ID", curriculo.UsuarioId);
            return View(curriculo);
        }

        // POST: Curriculos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CurriculoID,FirstName,LastName,PhoneNumber,Address,City,PostalCode,Estate,Objetive,UsuarioId")] Curriculo curriculo)
        {
            if (id != curriculo.CurriculoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(curriculo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CurriculoExists(curriculo.CurriculoID))
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
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "ID", "ID", curriculo.UsuarioId);
            return View(curriculo);
        }

        // GET: Curriculos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Curriculo == null)
            {
                return NotFound();
            }

            var curriculo = await _context.Curriculo
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.CurriculoID == id);
            if (curriculo == null)
            {
                return NotFound();
            }

            return View(curriculo);
        }

        // POST: Curriculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Curriculo == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Curriculo'  is null.");
            }
            var curriculo = await _context.Curriculo.FindAsync(id);
            if (curriculo != null)
            {
                _context.Curriculo.Remove(curriculo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CurriculoExists(int id)
        {
          return (_context.Curriculo?.Any(e => e.CurriculoID == id)).GetValueOrDefault();
        }
    }
}

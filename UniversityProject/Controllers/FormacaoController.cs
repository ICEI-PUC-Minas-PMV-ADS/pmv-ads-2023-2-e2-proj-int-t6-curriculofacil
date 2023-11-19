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
    public class FormacaoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormacaoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Formacao
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Formacao.Include(f => f.Curriculo);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Formacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Formacao == null)
            {
                return NotFound();
            }

            var formacao = await _context.Formacao
                .Include(f => f.Curriculo)
                .FirstOrDefaultAsync(m => m.FormacaoID == id);
            if (formacao == null)
            {
                return NotFound();
            }

            return View(formacao);
        }

        // GET: Formacao/Create
        public IActionResult Create()
        {
            ViewData["CurriculoID"] = new SelectList(_context.Curriculo, "CurriculoID", "Address");
            return View();
        }

        // POST: Formacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FormacaoID,InstDeEnsino,Estado,Diploma,CampoDeEstudo,Situacao,DataInicio,DataTermino,CurriculoID")] Formacao formacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CurriculoID"] = new SelectList(_context.Curriculo, "CurriculoID", "Address", formacao.CurriculoID);
            return View(formacao);
        }

        // GET: Formacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Formacao == null)
            {
                return NotFound();
            }

            var formacao = await _context.Formacao.FindAsync(id);
            if (formacao == null)
            {
                return NotFound();
            }
            ViewData["CurriculoID"] = new SelectList(_context.Curriculo, "CurriculoID", "Address", formacao.CurriculoID);
            return View(formacao);
        }

        // POST: Formacao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FormacaoID,InstDeEnsino,Estado,Diploma,CampoDeEstudo,Situacao,DataInicio,DataTermino,CurriculoID")] Formacao formacao)
        {
            if (id != formacao.FormacaoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormacaoExists(formacao.FormacaoID))
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
            ViewData["CurriculoID"] = new SelectList(_context.Curriculo, "CurriculoID", "Address", formacao.CurriculoID);
            return View(formacao);
        }

        // GET: Formacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Formacao == null)
            {
                return NotFound();
            }

            var formacao = await _context.Formacao
                .Include(f => f.Curriculo)
                .FirstOrDefaultAsync(m => m.FormacaoID == id);
            if (formacao == null)
            {
                return NotFound();
            }

            return View(formacao);
        }

        // POST: Formacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Formacao == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Formacao'  is null.");
            }
            var formacao = await _context.Formacao.FindAsync(id);
            if (formacao != null)
            {
                _context.Formacao.Remove(formacao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormacaoExists(int id)
        {
          return (_context.Formacao?.Any(e => e.FormacaoID == id)).GetValueOrDefault();
        }
    }
}

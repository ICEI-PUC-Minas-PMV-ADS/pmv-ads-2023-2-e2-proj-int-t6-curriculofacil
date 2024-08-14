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
        public IActionResult Create(int idPrimeiroRegistro)
        {
            // Armazena o ID do primeiro registro na TempData
            TempData["IdPrimeiroRegistro"] = idPrimeiroRegistro;

            ViewData["CurriculoID"] = new SelectList(_context.Curriculo, "CurriculoID", "CurriculoID");
            return View();

            //ViewData["CurriculoID"] = new SelectList(_context.Curriculo, "CurriculoID", "Objective");
            //return View();
        }

        // POST: Formacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FormacaoID,InstDeEnsino,Estado,CampoDeEstudo,Situacao,DataInicio,DataTermino,CurriculoID")] Formacao formacao)
        {
            if (ModelState.IsValid)
            {
                if (TempData.TryGetValue("IdPrimeiroRegistro", out object idPrimeiroRegistroObj) && idPrimeiroRegistroObj is int idPrimeiroRegistro)
                {
                    // Atribui o ID do primeiro registro ao modelo
                    formacao.CurriculoID = idPrimeiroRegistro;
                    _context.Add(formacao);
                    await _context.SaveChangesAsync();

                    int idSegundoRegistro = formacao.CurriculoID;

                    return RedirectToAction("Create", "HistoricoProfissional", new {idSegundoRegistro});
                }
            }
            //ViewData["CurriculoID"] = new SelectList(_context.Curriculo, "CurriculoID", "Objective", formacao.CurriculoID);
            return View(formacao);
        }

        // GET: Formacao/Edit/5
        public async Task<IActionResult> Edit(int? curriculoIDpraEdit)
        {
            if (curriculoIDpraEdit == null)
            {
                return NotFound();
            }

            // Encontre a formação com base no curriculoIDpraEdit
            var formacao =  await _context.Formacao.FirstOrDefaultAsync(f => f.CurriculoID == curriculoIDpraEdit);

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
        public async Task<IActionResult> Edit(int curriculoIDpraEdit, [Bind("FormacaoID,InstDeEnsino,Estado,CampoDeEstudo,Situacao,DataInicio,DataTermino")] Formacao formacao)
        {
            if (curriculoIDpraEdit != formacao.CurriculoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Obtém a formação original do banco de dados
                    var originalFormacao = await _context.Formacao.AsNoTracking().FirstOrDefaultAsync(f => f.FormacaoID == formacao.FormacaoID);

                    // Copia o CurriculoID original para o modelo
                    formacao.CurriculoID = originalFormacao.CurriculoID;

                    // Atualiza a formação no contexto
                    _context.Update(formacao);

                    // Salva as mudanças no banco de dados
                    await _context.SaveChangesAsync();
                    int curriculoPraEditHistorico = formacao.CurriculoID;
                    // Redireciona para a ação "Edit" do controlador "HistoricoProfissional" com o parâmetro "curriculoPraEditHistorico"
                    return RedirectToAction("Edit", "HistoricoProfissional", new { curriculoPraEditHistorico });
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

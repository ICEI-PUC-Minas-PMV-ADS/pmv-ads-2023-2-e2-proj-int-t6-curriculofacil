using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniversityProject.Data;
using UniversityProject.Models;

namespace UniversityProject.Controllers
{
    public class HistoricoProfissionalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HistoricoProfissionalController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HistoricoProfissional
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.HistoricoProfissional.Include(h => h.Curriculo);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: HistoricoProfissional/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            ClaimsPrincipal userPrincipal = HttpContext.User; // Isso pode variar dependendo do contexto (ASP.NET MVC, ASP.NET Core, etc.)
            ClaimsIdentity userIdentity = userPrincipal.Identity as ClaimsIdentity;
            //ID DO USUARIO LOGADO
            var userID = userIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;


            if (id == null || _context.HistoricoProfissional == null)
            {
                return NotFound();
            }

            var historicoProfissional = await _context.HistoricoProfissional
                .Include(h => h.Curriculo)
                .FirstOrDefaultAsync(m => m.HistoricoProfissinalID == id);
            if (historicoProfissional == null)
            {
                return NotFound();
            }

            return View(historicoProfissional);
        }

        // GET: HistoricoProfissional/Create
                    //obtem id do curriculo
        public IActionResult Create(int idSegundoRegistro)
        {
            // Armazena o ID do primeiro registro na TempData
            TempData["idSegundoRegistro"] = idSegundoRegistro;

            ViewData["CurriculoID"] = new SelectList(_context.Curriculo, "CurriculoID", "Objetive");
            return View();
        }

        // POST: HistoricoProfissional/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HistoricoProfissinalID,Cargo,Empregador,Cidade,Estado,DataInicio,DataTermino,CurriculoID")] HistoricoProfissional historicoProfissional)
        {   
            if (ModelState.IsValid)
            {
                if (TempData.TryGetValue("idSegundoRegistro", out object idSegundoRegistroObj) && idSegundoRegistroObj is int idSegundoRegistro)
                {
                    // Atribui o ID do primeiro registro ao modelo
                    historicoProfissional.CurriculoID = idSegundoRegistro;

                    _context.Add(historicoProfissional);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "Curriculos");
                }
            }
            ViewData["CurriculoID"] = new SelectList(_context.Curriculo, "CurriculoID", "Objetive", historicoProfissional.CurriculoID);
            return View(historicoProfissional);
        }
        
        // GET: HistoricoProfissional/Edit/5
        public async Task<IActionResult> Edit(int? curriculoPraEditHistorico)
        {
            if (curriculoPraEditHistorico == null || _context.HistoricoProfissional == null)
            {
                return NotFound();
            }

            // Encontre a formação com base no curriculoIDpraEdit
            var historicoProfissional = await _context.HistoricoProfissional.FirstOrDefaultAsync(f => f.CurriculoID == curriculoPraEditHistorico);
            if (historicoProfissional == null)
            {
                return NotFound();
            }
            ViewData["CurriculoID"] = new SelectList(_context.Curriculo, "CurriculoID", "Objetive", historicoProfissional.CurriculoID);
            return View(historicoProfissional);
        }

        // POST: HistoricoProfissional/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int curriculoPraEditHistorico, [Bind("HistoricoProfissinalID,Cargo,Empregador,Cidade,Estado,DataInicio,DataTermino,CurriculoID")] HistoricoProfissional historicoProfissional)
        {
            if (curriculoPraEditHistorico != historicoProfissional.CurriculoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Obtém a formação original do banco de dados
                    var originalHistorico = await _context.HistoricoProfissional.AsNoTracking().FirstOrDefaultAsync(f => f.HistoricoProfissinalID == historicoProfissional.HistoricoProfissinalID);

                    // Copia o CurriculoID original para o modelo
                    historicoProfissional.CurriculoID = originalHistorico.CurriculoID;

                    // Atualiza a formação no contexto
                    _context.Update(historicoProfissional);

                    // Salva as mudanças no banco de dados
                    await _context.SaveChangesAsync();
                 
                    // Redireciona para a ação "Edit" do controlador "HistoricoProfissional" com o parâmetro "curriculoPraEditHistorico"
                    return RedirectToAction("Index", "Curriculos");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistoricoProfissionalExists(historicoProfissional.HistoricoProfissinalID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Index));
            }
            ViewData["CurriculoID"] = new SelectList(_context.Curriculo, "CurriculoID", "Objetive", historicoProfissional.CurriculoID);
            return View(historicoProfissional);
        }

        // GET: HistoricoProfissional/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HistoricoProfissional == null)
            {
                return NotFound();
            }

            var historicoProfissional = await _context.HistoricoProfissional
                .Include(h => h.Curriculo)
                .FirstOrDefaultAsync(m => m.HistoricoProfissinalID == id);
            if (historicoProfissional == null)
            {
                return NotFound();
            }

            return View(historicoProfissional);
        }

        // POST: HistoricoProfissional/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HistoricoProfissional == null)
            {
                return Problem("Entity set 'ApplicationDbContext.HistoricoProfissional'  is null.");
            }
            var historicoProfissional = await _context.HistoricoProfissional.FindAsync(id);
            if (historicoProfissional != null)
            {
                _context.HistoricoProfissional.Remove(historicoProfissional);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoricoProfissionalExists(int id)
        {
          return (_context.HistoricoProfissional?.Any(e => e.HistoricoProfissinalID == id)).GetValueOrDefault();
        }
    }
}

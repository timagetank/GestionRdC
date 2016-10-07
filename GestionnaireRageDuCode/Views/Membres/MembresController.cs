using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionnaireRageDuCode.Data;
using GestionnaireRageDuCode.Models.MembresViewModels;

namespace GestionnaireRageDuCode.Views.Membres
{
    public class MembresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MembresController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Membres
        public async Task<IActionResult> Index()
        {
            return View(await _context.Membres.ToListAsync());
        }

        // GET: Membres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membres = await _context.Membres.SingleOrDefaultAsync(m => m.ID == id);
            if (membres == null)
            {
                return NotFound();
            }

            return View(membres);
        }

        // GET: Membres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Membres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nom,Prenom,Role")] Models.MembresViewModels.Membres membres)
        {
            if (ModelState.IsValid)
            {
                _context.Add(membres);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(membres);
        }

        // GET: Membres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membres = await _context.Membres.SingleOrDefaultAsync(m => m.ID == id);
            if (membres == null)
            {
                return NotFound();
            }
            return View(membres);
        }

        // POST: Membres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nom,Prenom,Role")] Models.MembresViewModels.Membres membres)
        {
            if (id != membres.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(membres);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MembresExists(membres.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(membres);
        }

        // GET: Membres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membres = await _context.Membres.SingleOrDefaultAsync(m => m.ID == id);
            if (membres == null)
            {
                return NotFound();
            }

            return View(membres);
        }

        // POST: Membres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var membres = await _context.Membres.SingleOrDefaultAsync(m => m.ID == id);
            _context.Membres.Remove(membres);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool MembresExists(int id)
        {
            return _context.Membres.Any(e => e.ID == id);
        }
    }
}

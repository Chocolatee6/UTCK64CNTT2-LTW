using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetCoreLAB6_EF.Data;
using NetCoreLAB6_EF.Models;

namespace NetCoreLAB6_EF.Controllers
{
    public class CatogoriesController : Controller
    {
        private readonly AppDbContext _context;

        public CatogoriesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Catogories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Catogories.ToListAsync());
        }

        // GET: Catogories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catogory = await _context.Catogories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (catogory == null)
            {
                return NotFound();
            }

            return View(catogory);
        }

        // GET: Catogories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Catogories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Status")] Catogory catogory)
        {
            if (ModelState.IsValid)
            {

                catogory.CreatedDate = DateTime.Now;
                _context.Add(catogory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catogory);
        }

        // GET: Catogories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catogory = await _context.Catogories.FindAsync(id);
            if (catogory == null)
            {
                return NotFound();
            }
            return View(catogory);
        }

        // POST: Catogories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Status,CreatedDate")] Catogory catogory)
        {
            if (id != catogory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catogory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatogoryExists(catogory.Id))
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
            return View(catogory);
        }

        // GET: Catogories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catogory = await _context.Catogories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (catogory == null)
            {
                return NotFound();
            }

            return View(catogory);
        }

        // POST: Catogories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var catogory = await _context.Catogories.FindAsync(id);
            if (catogory != null)
            {
                _context.Catogories.Remove(catogory);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatogoryExists(int id)
        {
            return _context.Catogories.Any(e => e.Id == id);
        }
    }
}

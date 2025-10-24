using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HoangQuocAnh231230703de02ConText;
using hqa_231230703_de02.Models;

namespace hqa_231230703_de02.Controllers
{
    public class HqaCatalogsController : Controller
    {
        private readonly HoangQuocAnh231230703De02Context _context;

        public HqaCatalogsController(HoangQuocAnh231230703De02Context context)
        {
            _context = context;
        }

        // GET: HqaCatalogs
        public async Task<IActionResult> hqaIndex()
        {
            return View(await _context.HqaCatalogs.ToListAsync());
        }

        // GET: HqaCatalogs/Details/5
        public async Task<IActionResult> hqaDetails(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hqaCatalog = await _context.HqaCatalogs
                .FirstOrDefaultAsync(m => m.HqaId == id);
            if (hqaCatalog == null)
            {
                return NotFound();
            }

            return View(hqaCatalog);
        }

        // GET: HqaCatalogs/Create
        [HttpGet]
        public IActionResult hqaCreate()
        {
            return View();
        }

        // POST: HqaCatalogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> hqaCreate([Bind("HqaId,HqaCateName,HqaCatePrice,HqaCateQty,HqaPicture,HqaCateActive")] HqaCatalog hqaCatalog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hqaCatalog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(hqaIndex));
            }
            return View(hqaCatalog);
        }

        // GET: HqaCatalogs/Edit/5
        public async Task<IActionResult> hqaEdit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hqaCatalog = await _context.HqaCatalogs.FindAsync(id);
            if (hqaCatalog == null)
            {
                return NotFound();
            }
            return View(hqaCatalog);
        }

        // POST: HqaCatalogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> hqaEdit(string id, [Bind("HqaId,HqaCateName,HqaCatePrice,HqaCateQty,HqaPicture,HqaCateActive")] HqaCatalog hqaCatalog)
        {
            if (id != hqaCatalog.HqaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hqaCatalog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HqaCatalogExists(hqaCatalog.HqaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(hqaIndex));
            }
            return View(hqaCatalog);
        }

        // GET: HqaCatalogs/Delete/5
        public async Task<IActionResult> hqaDelete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hqaCatalog = await _context.HqaCatalogs
                .FirstOrDefaultAsync(m => m.HqaId == id);
            if (hqaCatalog == null)
            {
                return NotFound();
            }

            return View(hqaCatalog);
        }

        // POST: HqaCatalogs/Delete/5
        [HttpPost, ActionName("hqaDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hqaCatalog = await _context.HqaCatalogs.FindAsync(id);
            if (hqaCatalog != null)
            {
                _context.HqaCatalogs.Remove(hqaCatalog);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(hqaIndex));
        }

        private bool HqaCatalogExists(string id)
        {
            return _context.HqaCatalogs.Any(e => e.HqaId == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TvcDay09LabCF.Models;

namespace TvcDay09LabCF.Controllers
{
    public class LoaiSanPhamsController : Controller
    {
        private readonly TvcDay09LabCFContext _context;

        public LoaiSanPhamsController(TvcDay09LabCFContext context)
        {
            _context = context;
        }

        // GET: LoaiSanPhams
        [Route("LoaiSanPhams")]
        public async Task<IActionResult> tvcIndex()
        {
            return View(await _context.tvcLoaiSanPhams.ToListAsync());
        }


        // GET: LoaiSanPhams/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSanPham = await _context.tvcLoaiSanPhams
                .FirstOrDefaultAsync(m => m.IDLoaiSanPham == id);
            if (loaiSanPham == null)
            {
                return NotFound();
            }

            return View(loaiSanPham);
        }

        // GET: LoaiSanPhams/Create
        [HttpGet]
        public IActionResult tvcCreate()
        {
            return View();
        }

        // POST: LoaiSanPhams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> tvcCreate([Bind("IDLoaiSanPham,MaLoai,TenLoai,TrangThai")] LoaiSanPham loaiSanPham)
        {
            
                _context.Add(loaiSanPham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(tvcIndex));
            
        }

        // GET: LoaiSanPhams/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSanPham = await _context.tvcLoaiSanPhams.FindAsync(id);
            if (loaiSanPham == null)
            {
                return NotFound();
            }
            return View(loaiSanPham);
        }

        // POST: LoaiSanPhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("IDLoaiSanPham,MaLoai,TenLoai,TrangThai")] LoaiSanPham loaiSanPham)
        {
            if (id != loaiSanPham.IDLoaiSanPham)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiSanPham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiSanPhamExists(loaiSanPham.IDLoaiSanPham))
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
            return View(loaiSanPham);
        }

        // GET: LoaiSanPhams/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSanPham = await _context.tvcLoaiSanPhams
                .FirstOrDefaultAsync(m => m.IDLoaiSanPham == id);
            if (loaiSanPham == null)
            {
                return NotFound();
            }

            return View(loaiSanPham);
        }

        // POST: LoaiSanPhams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var loaiSanPham = await _context.tvcLoaiSanPhams.FindAsync(id);
            if (loaiSanPham != null)
            {
                _context.tvcLoaiSanPhams.Remove(loaiSanPham);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiSanPhamExists(long id)
        {
            return _context.tvcLoaiSanPhams.Any(e => e.IDLoaiSanPham == id);
        }
    }
}

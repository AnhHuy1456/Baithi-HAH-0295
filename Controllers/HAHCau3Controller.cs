using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApplicationDb.Data;
using Baithi_HAH.Models;

namespace Baithi_HAH.Controllers
{
    public class HAHCau3Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public HAHCau3Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HAHCau3
        public async Task<IActionResult> Index()
        {
              return _context.HAHCau3 != null ? 
                          View(await _context.HAHCau3.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.HAHCau3'  is null.");
        }

        // GET: HAHCau3/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.HAHCau3 == null)
            {
                return NotFound();
            }

            var hAHCau3 = await _context.HAHCau3
                .FirstOrDefaultAsync(m => m.Masinhvien == id);
            if (hAHCau3 == null)
            {
                return NotFound();
            }

            return View(hAHCau3);
        }

        // GET: HAHCau3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HAHCau3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Masinhvien,Hoten,Namsinh")] HAHCau3 hAHCau3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hAHCau3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hAHCau3);
        }

        // GET: HAHCau3/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.HAHCau3 == null)
            {
                return NotFound();
            }

            var hAHCau3 = await _context.HAHCau3.FindAsync(id);
            if (hAHCau3 == null)
            {
                return NotFound();
            }
            return View(hAHCau3);
        }

        // POST: HAHCau3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Masinhvien,Hoten,Namsinh")] HAHCau3 hAHCau3)
        {
            if (id != hAHCau3.Masinhvien)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hAHCau3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HAHCau3Exists(hAHCau3.Masinhvien))
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
            return View(hAHCau3);
        }

        // GET: HAHCau3/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.HAHCau3 == null)
            {
                return NotFound();
            }

            var hAHCau3 = await _context.HAHCau3
                .FirstOrDefaultAsync(m => m.Masinhvien == id);
            if (hAHCau3 == null)
            {
                return NotFound();
            }

            return View(hAHCau3);
        }

        // POST: HAHCau3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.HAHCau3 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.HAHCau3'  is null.");
            }
            var hAHCau3 = await _context.HAHCau3.FindAsync(id);
            if (hAHCau3 != null)
            {
                _context.HAHCau3.Remove(hAHCau3);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HAHCau3Exists(string id)
        {
          return (_context.HAHCau3?.Any(e => e.Masinhvien == id)).GetValueOrDefault();
        }
    }
}

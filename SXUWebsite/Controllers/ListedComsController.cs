using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SXUWebsite.Data;
using SXUWebsite.Models;

namespace SXUWebsite.Controllers
{
    public class ListedComsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListedComsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ListedComs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ListedComs.Include(l => l.Category);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ListedComs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ListedComs == null)
            {
                return NotFound();
            }

            var listedCom = await _context.ListedComs
                .Include(l => l.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (listedCom == null)
            {
                return NotFound();
            }

            return View(listedCom);
        }

        // GET: ListedComs/Create
        public IActionResult Create()
        {
            ViewData["CategoryFK"] = new SelectList(_context.Category, "CategoryID", "CategoryID");
            return View();
        }

        // POST: ListedComs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CompanyName,CompanyCode,CompanyAddress,Website,Email,Password,ConfirmPassword,logoPath,LiceincePath,STATUS,Approval,RegisterTime,CategoryFK")] ListedCom listedCom)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listedCom);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryFK"] = new SelectList(_context.Category, "CategoryID", "CategoryID", listedCom.CategoryFK);
            return View(listedCom);
        }

        // GET: ListedComs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ListedComs == null)
            {
                return NotFound();
            }

            var listedCom = await _context.ListedComs.FindAsync(id);
            if (listedCom == null)
            {
                return NotFound();
            }
            ViewData["CategoryFK"] = new SelectList(_context.Category, "CategoryID", "CategoryID", listedCom.CategoryFK);
            return View(listedCom);
        }

        // POST: ListedComs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CompanyName,CompanyCode,CompanyAddress,Website,Email,Password,ConfirmPassword,logoPath,LiceincePath,STATUS,Approval,RegisterTime,CategoryFK")] ListedCom listedCom)
        {
            if (id != listedCom.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listedCom);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListedComExists(listedCom.ID))
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
            ViewData["CategoryFK"] = new SelectList(_context.Category, "CategoryID", "CategoryID", listedCom.CategoryFK);
            return View(listedCom);
        }

        // GET: ListedComs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ListedComs == null)
            {
                return NotFound();
            }

            var listedCom = await _context.ListedComs
                .Include(l => l.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (listedCom == null)
            {
                return NotFound();
            }

            return View(listedCom);
        }

        // POST: ListedComs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ListedComs == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ListedComs'  is null.");
            }
            var listedCom = await _context.ListedComs.FindAsync(id);
            if (listedCom != null)
            {
                _context.ListedComs.Remove(listedCom);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListedComExists(int id)
        {
          return (_context.ListedComs?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}

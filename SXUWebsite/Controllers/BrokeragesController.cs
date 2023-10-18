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
    public class BrokeragesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BrokeragesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Brokerages
        public async Task<IActionResult> Index()
        {
              return _context.Brokerages != null ? 
                          View(await _context.Brokerages.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Brokerages'  is null.");
        }

        // GET: Brokerages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Brokerages == null)
            {
                return NotFound();
            }

            var brokerage = await _context.Brokerages
                .FirstOrDefaultAsync(m => m.ID == id);
            if (brokerage == null)
            {
                return NotFound();
            }

            return View(brokerage);
        }

        // GET: Brokerages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Brokerages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CompanyName,Phone,CountryCode,CompanyAddress,Website,Email,Password,ConfirmPassword,logoPath,Liceinces,Status,Approval")] Brokerage brokerage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brokerage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(brokerage);
        }

        // GET: Brokerages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Brokerages == null)
            {
                return NotFound();
            }

            var brokerage = await _context.Brokerages.FindAsync(id);
            if (brokerage == null)
            {
                return NotFound();
            }
            return View(brokerage);
        }

        // POST: Brokerages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CompanyName,Phone,CountryCode,CompanyAddress,Website,Email,Password,ConfirmPassword,logoPath,Liceinces,Status,Approval")] Brokerage brokerage)
        {
            if (id != brokerage.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brokerage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrokerageExists(brokerage.ID))
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
            return View(brokerage);
        }

        // GET: Brokerages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Brokerages == null)
            {
                return NotFound();
            }

            var brokerage = await _context.Brokerages
                .FirstOrDefaultAsync(m => m.ID == id);
            if (brokerage == null)
            {
                return NotFound();
            }

            return View(brokerage);
        }

        // POST: Brokerages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Brokerages == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Brokerages'  is null.");
            }
            var brokerage = await _context.Brokerages.FindAsync(id);
            if (brokerage != null)
            {
                _context.Brokerages.Remove(brokerage);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BrokerageExists(int id)
        {
          return (_context.Brokerages?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}

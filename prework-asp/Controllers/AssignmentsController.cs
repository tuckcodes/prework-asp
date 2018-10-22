using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prework_asp.Data.Migrations;
using prework_asp.Models;

namespace prework_asp.Controllers
{
    public class AssignmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AssignmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Assignments
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Assignment.Include(a => a.Progress);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Assignments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assignments = await _context.Assignment
                .Include(a => a.Progress)
                .SingleOrDefaultAsync(m => m.AssignmentsID == id);
            if (assignments == null)
            {
                return NotFound();
            }

            return View(assignments);
        }

        // GET: Assignments/Create
        public IActionResult Create()
        {
            ViewData["ProgressID"] = new SelectList(_context.Progress, "ProgressID", "ProgressID");
            return View();
        }

        // POST: Assignments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AssignmentsID,Project,StartDate,EndDate,Issues,ProgressID")] Assignments assignments)
        {
            if (ModelState.IsValid)
            {
                _context.Add(assignments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProgressID"] = new SelectList(_context.Progress, "ProgressID", "ProgressID", assignments.ProgressID);
            return View(assignments);
        }

        // GET: Assignments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assignments = await _context.Assignment.SingleOrDefaultAsync(m => m.AssignmentsID == id);
            if (assignments == null)
            {
                return NotFound();
            }
            ViewData["ProgressID"] = new SelectList(_context.Progress, "ProgressID", "ProgressID", assignments.ProgressID);
            return View(assignments);
        }

        // POST: Assignments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AssignmentsID,Project,StartDate,EndDate,Issues,ProgressID")] Assignments assignments)
        {
            if (id != assignments.AssignmentsID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assignments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssignmentsExists(assignments.AssignmentsID))
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
            ViewData["ProgressID"] = new SelectList(_context.Progress, "ProgressID", "ProgressID", assignments.ProgressID);
            return View(assignments);
        }

        // GET: Assignments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assignments = await _context.Assignment
                .Include(a => a.Progress)
                .SingleOrDefaultAsync(m => m.AssignmentsID == id);
            if (assignments == null)
            {
                return NotFound();
            }

            return View(assignments);
        }

        // POST: Assignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assignments = await _context.Assignment.SingleOrDefaultAsync(m => m.AssignmentsID == id);
            _context.Assignment.Remove(assignments);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssignmentsExists(int id)
        {
            return _context.Assignment.Any(e => e.AssignmentsID == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudyC.Data;
using StudyC.Models;

namespace StudyC.Controllers
{
    public class UserStudiesController : Controller
    {
        private readonly StudyCContext _context;

        public UserStudiesController(StudyCContext context)
        {
            _context = context;
        }

        // GET: UserStudies
        public async Task<IActionResult> Index()
        {
            var studyCContext = _context.UserStudy.Include(u => u.Study).Include(u => u.User);
            return View(await studyCContext.ToListAsync());
        }

        // GET: UserStudies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userStudy = await _context.UserStudy
                .Include(u => u.Study)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userStudy == null)
            {
                return NotFound();
            }

            return View(userStudy);
        }

        // GET: UserStudies/Create
        public IActionResult Create()
        {
            ViewData["StudyId"] = new SelectList(_context.Study, "Id", "Information");
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Mail");
            return View();
        }

        // POST: UserStudies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,StudyId")] UserStudy userStudy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userStudy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudyId"] = new SelectList(_context.Study, "Id", "Information", userStudy.StudyId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Mail", userStudy.UserId);
            return View(userStudy);
        }

        // GET: UserStudies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userStudy = await _context.UserStudy.FindAsync(id);
            if (userStudy == null)
            {
                return NotFound();
            }
            ViewData["StudyId"] = new SelectList(_context.Study, "Id", "Information", userStudy.StudyId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Mail", userStudy.UserId);
            return View(userStudy);
        }

        // POST: UserStudies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,StudyId")] UserStudy userStudy)
        {
            if (id != userStudy.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userStudy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserStudyExists(userStudy.UserId))
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
            ViewData["StudyId"] = new SelectList(_context.Study, "Id", "Information", userStudy.StudyId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Mail", userStudy.UserId);
            return View(userStudy);
        }

        // GET: UserStudies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userStudy = await _context.UserStudy
                .Include(u => u.Study)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userStudy == null)
            {
                return NotFound();
            }

            return View(userStudy);
        }

        // POST: UserStudies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userStudy = await _context.UserStudy.FindAsync(id);
            _context.UserStudy.Remove(userStudy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserStudyExists(int id)
        {
            return _context.UserStudy.Any(e => e.UserId == id);
        }
    }
}

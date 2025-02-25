﻿using System;
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
    public class StudiesController : Controller
    {
        private readonly StudyCContext _context;

        public StudiesController(StudyCContext context)
        { 
            _context = context;
        }

        // GET: Studies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Study.ToListAsync());
        }
        public async Task<IActionResult> Users()
        {
            return View(await _context.Study.Include(x =>x.UserStudy).ThenInclude(x=>x.User).ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Search(String Search)
        {
            var p = from S in _context.Study
                    where S.Subject.Contains(Search) || S.Information.Contains(Search)
                    select S;
            return View(await p.ToListAsync());
        }

        // GET: Studies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var study = await _context.Study.Include(x=> x.Question).ThenInclude(x => x.Options).FirstOrDefaultAsync(m => m.Id == id);
            if (study == null)
            {
                return NotFound();
            }

            return View(study);
        }

        // GET: Studies/Create
        public IActionResult Create()
        {
      
            return View();
        }

        // POST: Studies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Subject,Information")] Study study)
        {
            if (ModelState.IsValid)
            {
                _context.Add(study);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(study);
        }

        // GET: Studies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var study = await _context.Study.Include(x => x.Question).ThenInclude(x => x.Options).FirstOrDefaultAsync(m => m.Id == id);
            if (study == null)
            {
                return NotFound();
            }
            return View(study);
        }

        // POST: Studies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Subject,Information")] Study study)
        {
            if (id != study.Id)
            {
                return NotFound();
            }
            //var s = await _context.Study.Include(x => x.Question).ThenInclude(x => x.Options).FirstOrDefaultAsync(m => m.Id == id);
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(study);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudyExists(study.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return View(study);
            }
            return View(study);
        }

        // GET: Studies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var study = await _context.Study
                .FirstOrDefaultAsync(m => m.Id == id);
            if (study == null)
            {
                return NotFound();
            }

            return View(study);
        }

        // POST: Studies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var study = await _context.Study.FindAsync(id);
            _context.Study.Remove(study);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudyExists(int id)
        {
            return _context.Study.Any(e => e.Id == id);
        }
    }
}

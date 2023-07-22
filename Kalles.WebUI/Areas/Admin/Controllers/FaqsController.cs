﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kalles.Domain.Models.DataContexts;
using Kalles.Domain.Models.Entities;

namespace Kalles.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FaqsController : Controller
    {
        private readonly KallesDbContext db;

        public FaqsController(KallesDbContext db)
        {
            this.db = db;
        }

   
        public async Task<IActionResult> Index()
        {
            return View(await db.Faqs.ToListAsync());
        }

    
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faq = await db.Faqs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faq == null)
            {
                return NotFound();
            }

            return View(faq);
        }

   
        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Question,Answer,Id,CreatedDate,DeletedDate")] Faq faq)
        {
            if (ModelState.IsValid)
            {
                db.Add(faq);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faq);
        }

       
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faq = await db.Faqs.FindAsync(id);
            if (faq == null)
            {
                return NotFound();
            }
            return View(faq);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Question,Answer,Id,CreatedDate,DeletedDate")] Faq faq)
        {
            if (id != faq.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(faq);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaqExists(faq.Id))
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
            return View(faq);
        }

    

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var faq = await db.Faqs.FindAsync(id);
            db.Faqs.Remove(faq);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FaqExists(int id)
        {
            return db.Faqs.Any(e => e.Id == id);
        }
    }
}

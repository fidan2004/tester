using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kalles.Domain.Models.DataContexts;
using Kalles.Domain.Models.Entities;

namespace Kalles.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ColorsController : Controller
    {
        private readonly KallesDbContext db;

        public ColorsController(KallesDbContext db)
        {
            this.db = db;
        }

  
        [Authorize(Policy = "admin.colors.index")]
        public async Task<IActionResult> Index()
        {
            return View(await db.ProductColors.ToListAsync());
        }

  
        [Authorize(Policy = "admin.colors.details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productColor = await db.ProductColors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productColor == null)
            {
                return NotFound();
            }

            return View(productColor);
        }

     
        [Authorize(Policy = "admin.colors.create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.colors.create")]
        public async Task<IActionResult> Create([Bind("Name,Id,CreatedDate,DeletedDate")] ProductColor productColor)
        {
            if (ModelState.IsValid)
            {
                db.Add(productColor);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productColor);
        }

        
        [Authorize(Policy = "admin.colors.edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productColor = await db.ProductColors.FindAsync(id);
            if (productColor == null)
            {
                return NotFound();
            }
            return View(productColor);
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.colors.edit")]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Id,CreatedDate,DeletedDate")] ProductColor productColor)
        {
            if (id != productColor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(productColor);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductColorExists(productColor.Id))
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
            return View(productColor);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "admin.colors.remove")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productColor = await db.ProductColors.FindAsync(id);
            db.ProductColors.Remove(productColor);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductColorExists(int id)
        {
            return db.ProductColors.Any(e => e.Id == id);
        }
    }
}

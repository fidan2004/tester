using System;
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
    public class MaterialsController : Controller
    {
        private readonly KallesDbContext db;

        public MaterialsController(KallesDbContext db)
        {
            this.db = db;
        }

      
        public async Task<IActionResult> Index()
        {
            return View(await db.ProductMaterials.ToListAsync());
        }

       
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productMaterial = await db.ProductMaterials
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productMaterial == null)
            {
                return NotFound();
            }

            return View(productMaterial);
        }

      
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id,CreatedDate,DeletedDate")] ProductMaterial productMaterial)
        {
            if (ModelState.IsValid)
            {
                db.Add(productMaterial);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productMaterial);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productMaterial = await db.ProductMaterials.FindAsync(id);
            if (productMaterial == null)
            {
                return NotFound();
            }
            return View(productMaterial);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Id,CreatedDate,DeletedDate")] ProductMaterial productMaterial)
        {
            if (id != productMaterial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(productMaterial);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductMaterialExists(productMaterial.Id))
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
            return View(productMaterial);
        }

  
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productMaterial = await db.ProductMaterials
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productMaterial == null)
            {
                return NotFound();
            }

            return View(productMaterial);
        }

      
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productMaterial = await db.ProductMaterials.FindAsync(id);
            db.ProductMaterials.Remove(productMaterial);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductMaterialExists(int id)
        {
            return db.ProductMaterials.Any(e => e.Id == id);
        }
    }
}

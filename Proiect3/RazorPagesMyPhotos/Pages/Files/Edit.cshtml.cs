using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMyPhotos.Data;
using RazorPagesMyPhotos.Models;

namespace RazorPagesMyPhotos.Pages.Files
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesMyPhotos.Data.RazorPagesMyPhotosContext _context;

        public EditModel(RazorPagesMyPhotos.Data.RazorPagesMyPhotosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public File File { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            File = await _context.File.FirstOrDefaultAsync(m => m.Id == id);

            if (File == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(File).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FileExists(File.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FileExists(Guid id)
        {
            return _context.File.Any(e => e.Id == id);
        }
    }
}

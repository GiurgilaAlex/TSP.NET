using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMyPhotos.Data;
using RazorPagesMyPhotos.Models;

namespace RazorPagesMyPhotos.Pages.Files
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMyPhotos.Data.RazorPagesMyPhotosContext _context;

        public DeleteModel(RazorPagesMyPhotos.Data.RazorPagesMyPhotosContext context)
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

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            File = await _context.File.FindAsync(id);

            if (File != null)
            {
                _context.File.Remove(File);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

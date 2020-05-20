using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMyPhotos.Data;
using RazorPagesMyPhotos.Models;

namespace RazorPagesMyPhotos.Pages.Files
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMyPhotos.Data.RazorPagesMyPhotosContext _context;

        public CreateModel(RazorPagesMyPhotos.Data.RazorPagesMyPhotosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public File File { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.File.Add(File);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

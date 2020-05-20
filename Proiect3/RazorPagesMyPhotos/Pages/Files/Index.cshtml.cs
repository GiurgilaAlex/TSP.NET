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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMyPhotos.Data.RazorPagesMyPhotosContext _context;

        public IndexModel(RazorPagesMyPhotos.Data.RazorPagesMyPhotosContext context)
        {
            _context = context;
        }

        public IList<File> File { get;set; }

        public async Task OnGetAsync()
        {
            File = await _context.File.ToListAsync();
        }
    }
}

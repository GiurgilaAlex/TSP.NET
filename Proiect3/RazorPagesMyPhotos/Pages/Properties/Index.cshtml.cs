using System.Collections.Generic;
using System.Threading.Tasks;
using RazorPagesMyPhotos.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMyPhotos;
namespace RazorPagesMyPhotos.Pages.Properties
{
    public class IndexModel : PageModel
    {
        FilePropertyClient fpc = new FilePropertyClient();
        public List<string> Properties { get; set; }

        public IndexModel()
        {
            Properties = new List<string>();
        }
        public async Task OnGetAsync()
        {
            var properties = await fpc.GetAllPropertiesAsync();
            foreach (var item in properties)
            {
                Properties.Add(item);
            }
        }
    }
}
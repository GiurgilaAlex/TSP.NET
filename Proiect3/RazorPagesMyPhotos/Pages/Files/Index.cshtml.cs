using System.Collections.Generic;
using System.Threading.Tasks;
using RazorPagesMyPhotos.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMyPhotos;
namespace RazorPagesMyPhotos.Pages.Files
{
    public class IndexModel : PageModel
    {
        FilePropertyClient fpc = new FilePropertyClient();
        public List<FileDTO> Files { get; set; }

        public IndexModel()
        {
            Files = new List<FileDTO>();
        }
        public async Task OnGetAsync()
        {
            var files = await fpc.GetAllFilesAsync();
            foreach (var item in files)
            {
                FileDTO fd = new FileDTO();
                fd.Id = item.Id;
                fd.Path = item.Path;
                fd.Name = item.Name;
                fd.Properties = new List<PropertyDTO>();

                var properties = await fpc.GetPropertiesByFileIdAsync(item.Id);
                foreach(var prop in properties)
                {
                    PropertyDTO propd = new PropertyDTO();
                    propd.Id = prop.Id;
                    propd.Key = prop.Key;
                    propd.Value = prop.Value;
                    fd.Properties.Add(propd);
                }

                Files.Add(fd);
            }
        }
    }
}
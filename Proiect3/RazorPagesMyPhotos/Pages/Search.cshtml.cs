using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMyPhotos.Models;
using ServiceReferenceMyPhotos;

namespace RazorPagesMyPhotos.Pages
{
    public class SearchModel : PageModel
    {
        public List<FileDTO> Files { get; set; }

        public SelectList KeysInput { get; set; }

        [BindProperty(SupportsGet = true)]
        public string KeyInput { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ValueInput { get; set; }

        [BindProperty(SupportsGet = true)]
        public string NumberOfFoundItems { get; set; }

        FilePropertyClient fpc = new FilePropertyClient();
        public List<string> Properties { get; set; }

        public SearchModel()
        {
            Properties = new List<string>();
            Files = new List<FileDTO>();
        }
        public async Task OnGetAsync()
        {
            var properties = await fpc.GetAllPropertiesAsync();
            foreach (var item in properties)
            {
                Properties.Add(item);
            }
            if (KeyInput == null)
            {
                KeyInput = Properties[0];
            }

            if (!string.IsNullOrEmpty(ValueInput))
            {
                Files = new List<FileDTO>();
                var files = await fpc.GetFilesByPropertyAsync(KeyInput, ValueInput);
                NumberOfFoundItems = files.Count().ToString();
                foreach (var item in files)
                {
                    FileDTO fd = new FileDTO();
                    fd.Id = item.Id;
                    fd.Path = item.Path;
                    fd.Name = item.Name;
                    fd.Properties = new List<PropertyDTO>();

                    var fileProperties = await fpc.GetPropertiesByFileIdAsync(item.Id);
                    foreach (var prop in fileProperties)
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
}
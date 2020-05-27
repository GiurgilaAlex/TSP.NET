using System;
using System.Collections.Generic;

namespace RazorPagesMyPhotos.Models
{
    public class FileDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public ICollection<PropertyDTO> Properties { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace RazorPagesMyPhotos.Models
{
    public class File
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public ICollection<Property> Properties { get; set; }
    }
}

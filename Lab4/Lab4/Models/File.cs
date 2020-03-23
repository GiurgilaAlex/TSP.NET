using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Models
{
    public partial class File
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public ICollection<Property> Properties{ get; set; }

        public File() { }
    }
}

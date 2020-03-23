using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Models
{
    public partial class Property
    {
        public Guid Id { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public File File { get; set; }

        public Guid FileId { get; set; }

        public Property() { }
    }
}

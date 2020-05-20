using System;

namespace RazorPagesMyPhotos.Models
{
    public class Property
    {
        public Guid Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public Guid FileId { get; set; }
        public File File { get; set; }
    }
}

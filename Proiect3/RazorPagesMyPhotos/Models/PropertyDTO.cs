using System;

namespace RazorPagesMyPhotos.Models
{
    public class PropertyDTO
    {
        public Guid Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public Guid FileId { get; set; }
        public FileDTO File { get; set; }
    }
}

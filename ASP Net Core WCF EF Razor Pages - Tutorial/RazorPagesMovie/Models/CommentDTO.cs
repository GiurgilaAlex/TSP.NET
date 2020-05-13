using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class CommentDTO
    {
        public int CommentId { get; set; }

        public int PostPostId { get; set; }

        public string Text { get; set; }

    }
}

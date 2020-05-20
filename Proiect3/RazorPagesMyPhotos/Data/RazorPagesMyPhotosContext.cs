﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMyPhotos.Models;

namespace RazorPagesMyPhotos.Data
{
    public class RazorPagesMyPhotosContext : DbContext
    {
        public RazorPagesMyPhotosContext (DbContextOptions<RazorPagesMyPhotosContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMyPhotos.Models.File> File { get; set; }
    }
}
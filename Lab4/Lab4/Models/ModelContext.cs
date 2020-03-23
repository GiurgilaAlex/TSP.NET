using Microsoft.EntityFrameworkCore;

namespace Lab4.Models
{
    internal class ModelContext: DbContext
    {
        public ModelContext()
            : base(GetOptions())
        {

        }

        public DbSet<File> Files { get; set; }
        public DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<File>()
                .HasMany<Property>(p => p.Properties)
                .WithOne(f => f.File);

            modelBuilder.Entity<Property>()
                .HasOne<File>(f => f.File)
                .WithMany(p => p.Properties);
        }

        private static DbContextOptions GetOptions()
        {
            return new DbContextOptionsBuilder()
                .UseSqlServer("Server=.\\SQLEXPRESS; Initial Catalog=ProiectEFCore; Trusted_Connection=True")
                .Options;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace DataAccess
{
    public class ErxDbContext: DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=10.106.17.152\INTN1;Initial Catalog=CheetahINT;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Blog>(entity =>
            //{
            //    entity.Property(e => e.Url).IsRequired();
            //});

            //modelBuilder.Entity<Post>(entity =>
            //{
            //    entity.HasOne(d => d.Blog)
            //        .WithMany(p => p.Post)
            //        .HasForeignKey(d => d.BlogId);
            //});
        }

    }
}

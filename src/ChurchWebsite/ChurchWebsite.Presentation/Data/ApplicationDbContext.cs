namespace ChurchWebsite.Presentation.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using ChurchWebsite.Presentation.Models;
    using ChurchWebsite.Presentation.Models.EventsModels;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<EventItem>()
                .HasKey(e => e.RecordId);

            builder.Entity<EventItem>()
                .Property(e => e.RecordId)
                .ValueGeneratedOnAdd();

            builder.Entity<EventItem>()
                .Property(e => e.EventTitle)
                .HasMaxLength(64)
                .IsRequired();

            builder.Entity<EventItem>()
                .Property(e => e.EventText)
                .HasMaxLength(512)
                .IsRequired();
        }

        public DbSet<EventItem> EventItems { get; set; }
    }
}

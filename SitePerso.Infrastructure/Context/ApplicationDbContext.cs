using Microsoft.EntityFrameworkCore;
using MonSitePerso.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace SitePerso.Infrastructure.Context
{
    public sealed class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        { 
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserProfile>().ToTable("UserProfiles");
            builder.Entity<Skill>().ToTable("Skills");
            builder.Entity<Experience>().ToTable("Experiences");
            builder.Entity<Education>().ToTable("Educations");
            builder.Entity<Project>().ToTable("Projects");
        }
    }
}

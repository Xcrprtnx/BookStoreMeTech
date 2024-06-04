using BookStoreMeTech.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;


namespace BookStoreMeTech.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class BookStoreMeTechDbContext : AbpDbContext<BookStoreMeTechDbContext>, IIdentityDbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityClaimType> ClaimTypes { get; set; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
        public DbSet<IdentityLinkUser> LinkUsers { get; set; }
        public DbSet<IdentityUserDelegation> UserDelegations { get; set; }

        public BookStoreMeTechDbContext(DbContextOptions<BookStoreMeTechDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureOpenIddict();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            builder.Entity<Book>(b =>
            {
                b.ToTable("Books");
                b.Property(x => x.Title)
                    .HasMaxLength(255)
                    .IsRequired();

                b.Property(x => x.Price)
                    .HasColumnType("decimal(18,2)");

                
                b.HasMany(x => x.Reviews)
                    .WithOne(r => r.Book)
                    .HasForeignKey(r => r.BookId)
                    .OnDelete(DeleteBehavior.NoAction);

                b.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            builder.Entity<Review>(b =>
            {
                b.ToTable("Reviews");
                b.Property(x => x.Rating)
                    .IsRequired();
                b.Property(e => e.Id).ValueGeneratedOnAdd();

                
                b.HasOne(r => r.Book)
                    .WithMany(b => b.Reviews)
                    .HasForeignKey(r => r.BookId)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(r => r.User)
                    .WithMany(u => u.Reviews)
                    .HasForeignKey(r => r.UserId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            builder.Entity<User>(b =>
            {
                b.ToTable("Users");
                b.Property(x => x.Name)
                    .HasMaxLength(255)
                    .IsRequired();

                b.Property(x => x.Email)
                    .HasMaxLength(255)
                    .IsRequired();

                b.Property(x => x.Password)
                    .HasMaxLength(255)
                    .IsRequired();

                b.HasMany(x => x.Reviews)
                    .WithOne(r => r.User)
                    .HasForeignKey(r => r.UserId)
                    .OnDelete(DeleteBehavior.NoAction);

                b.Property(e => e.Id).ValueGeneratedOnAdd();

                b.HasQueryFilter(u => !u.IsDeleted);
            });
        }
    }
}

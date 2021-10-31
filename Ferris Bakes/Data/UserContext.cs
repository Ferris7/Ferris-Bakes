using System;
using Ferris_Bakes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ferris_Bakes.Data
{
    public class UserContext : IdentityDbContext<
        UserModel, BackendRole, string,
        IdentityUserClaim<string>, BackendUserRole, IdentityUserLogin<string>,
        IdentityRoleClaim<string>, IdentityUserToken<string> >
    {
        public UserContext()
        {
        }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        protected void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<UserModel>(b =>
            {
                // Each User can have many UserClaims
                b.HasMany(e => e.Claims)
                    .WithOne()
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();

                // Each User can have many UserLogins
                b.HasMany(e => e.Logins)
                    .WithOne()
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();

                // Each User can have many UserTokens
                b.HasMany(e => e.Tokens)
                    .WithOne()
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();

                // Each User can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                .WithOne(e => e.User)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();
            });

            builder.Entity<BackendRole>(b =>
            {
                // Each Role can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();
            });

            var roles = new[] { new BackendRole("Admin") };

            var users = new[]
            {
                new UserModel
                {
                    Email = "fdehar1@lsu.edu",
                    UserName = "fdehar1@lsu.edu",
                    NormalizedUserName = StringNormalizationExtensions.Normalize("fdehar1@lsu.edu"),
                    Name = "Ferris DeHart",
                    DOB = new DateTime(2000, 7, 7),
                    EmailConfirmed = true
                }
            };

            users[0].PasswordHash = new PasswordHasher<UserModel>().HashPassword(users[0], "Bueller7!");

            var userRoles = new[]
            {
                new BackendUserRole
                {
                    UserId = users[0].Id,
                    RoleId = roles[0].Id
                }
            };

            builder.Entity<UserModel>().HasData(users);
            builder.Entity<BackendRole>().HasData(roles);
            builder.Entity<BackendUserRole>().HasData(userRoles);
        }
    }
}

using DroneHakaton.Domain.Repositories.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System;

namespace DroneHakaton.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Настройка отношений один к одному
            builder.Entity<Course>()
            .HasMany(c => c.Modules)
            .WithOne(m => m.Course)
            .HasForeignKey(m => m.CourseId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Course>()
                .HasMany(c => c.Progresses)
                .WithOne(p => p.Course)
                .HasForeignKey(p => p.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            // Конфигурация связей для Module
            builder.Entity<Module>()
                .HasMany(m => m.Tests)
                .WithOne(t => t.Module)
                .HasForeignKey(t => t.ModuleId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Module>()
                .HasMany(m => m.Progresses)
                .WithOne(p => p.Module)
                .HasForeignKey(p => p.ModuleId)
                .OnDelete(DeleteBehavior.Cascade);

            // Конфигурация связей для Progress
            builder.Entity<UserProgress>()
                .HasOne(p => p.User)
                .WithMany(u => u.Progresses)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Добавление начальных данных для UserProgress
            builder.Entity<UserProgress>().HasData(
                new UserProgress
                {
                    Id = new Guid("3c80611f-875e-47ae-a28f-e48ba8fb9c01"),
                    CompletionStatus = "Soooo",
                    UserId = new Guid("3c80611f-875e-47ae-a28f-e48ba8fb9c02")
                }
            );

            builder.Entity<User>().HasData(
                new User
                {
                    Id = new Guid("3c80611f-875e-47ae-a28f-e48ba8fb9c02"),
                    UserName = "Jhon",
                    Email = "a@gmail.com",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "1234")
                }
            );
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudyC.Models;

namespace StudyC.Data
{
    public class StudyCContext : DbContext
    {
        public StudyCContext (DbContextOptions<StudyCContext> options)
            : base(options)
        {
        }
      protected override void OnModelCreating(ModelBuilder modelBuilder)
        { modelBuilder.Entity<UserStudy>()
                .HasKey(pr => new { pr.UserId, pr.StudyId });
          modelBuilder.Entity<UserStudy>()
                .HasOne(pt => pt.User)
                .WithMany(p => p.UserStudy)
                .HasForeignKey(pt => pt.UserId);
          modelBuilder.Entity<UserStudy>()
                .HasOne(pt => pt.Study)
                .WithMany(t => t.UserStudy)
                .HasForeignKey(pt => pt.StudyId); }
        public DbSet<StudyC.Models.Contact> Contact { get; set; }
        public DbSet<StudyC.Models.User> User { get; set; }
        public DbSet<StudyC.Models.Question> Question { get; set; }
        public DbSet<StudyC.Models.Study> Study { get; set; }
        public DbSet<StudyC.Models.UserStudy> UserStudy { get; set; }
        public DbSet<StudyC.Models.Option> Option { get; set; }
    }
}

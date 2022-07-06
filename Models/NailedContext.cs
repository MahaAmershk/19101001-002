using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project_19101001_002.Models
{
    public partial class NailedContext : DbContext
    {
        public NailedContext()
        {
        }

        public NailedContext(DbContextOptions<NailedContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);Database=Nailed;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.Property(e => e.Dropdown)
                    .IsUnicode(false)
                    .HasColumnName("dropdown");

                entity.Property(e => e.Dropdownn)
                    .IsUnicode(false)
                    .HasColumnName("dropdownn");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .IsUnicode(false)
                    .HasColumnName("firstname");

                entity.Property(e => e.Phn).IsUnicode(false);

                entity.Property(e => e.Secondname)
                    .IsUnicode(false)
                    .HasColumnName("secondname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

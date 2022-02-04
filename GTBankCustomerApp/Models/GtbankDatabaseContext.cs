using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GTBankCustomerApp.Models
{
    public partial class GtbankDatabaseContext : DbContext
    {
        public GtbankDatabaseContext()
        {
        }

        public GtbankDatabaseContext(DbContextOptions<GtbankDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblLoanApplication> TblLoanApplication { get; set; }
        public virtual DbSet<TblCustomerCreation> TblCustomerCreation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=AMY\\AMAKA;Database=GtbankDatabase; user id=sa; password=sqluser10$;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblLoanApplication>(entity =>
            {
                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.FirstPayDate).HasColumnType("date");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrincipalAmount)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomerCreation>(entity =>
            {
                entity.Property(e => e.Bvn)
                    .HasColumnName("bvn")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Othername)
                    .HasColumnName("othername")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Residence)
                    .HasColumnName("residence")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

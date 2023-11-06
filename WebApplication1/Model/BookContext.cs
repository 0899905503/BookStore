﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Model
{
    public partial class BookContext : DbContext
    {
        public BookContext()
        {
        }

        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Loaisach> Loaisaches { get; set; } = null!;
        public virtual DbSet<Sach> Sachs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-AJRN0CS\\BAVO;Database=QLBANSACH;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loaisach>(entity =>
            {
                entity.HasKey(e => e.IdColumn)
                    .HasName("PK__LOAI_SAC__1E5A0B8E55B4F752");

                entity.ToTable("LOAISACH");

                entity.Property(e => e.IdColumn).HasColumnName("ID_column");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Daban).HasColumnName("DABAN");

                entity.Property(e => e.Hinhanh)
                    .HasMaxLength(255)
                    .HasColumnName("HINHANH");

                entity.Property(e => e.Maloaisach).HasColumnName("MALOAISACH");

                entity.Property(e => e.Mota)
                    .HasMaxLength(255)
                    .HasColumnName("MOTA");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("TEN");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

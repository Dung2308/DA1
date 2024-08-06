using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DTO.Models;

public partial class QlDuAn1Context : DbContext
{
    public QlDuAn1Context()
    {
    }

    public QlDuAn1Context(DbContextOptions<QlDuAn1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<Billinfo> Billinfos { get; set; }

    public virtual DbSet<Food> Foods { get; set; }

    public virtual DbSet<Foodcategory> Foodcategories { get; set; }

    public virtual DbSet<Tablefood> Tablefoods { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-G6B8K1EL\\SQLEXPRESS;Database=QL_DU_AN1;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("PK__account__F3DBC573768A8B04");

            entity.ToTable("account");

            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasDefaultValueSql("((0))")
                .HasColumnName("password");
            entity.Property(e => e.Ten)
                .HasMaxLength(100)
                .HasDefaultValue("ZDUNG")
                .HasColumnName("ten");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__bill__3213E83FD5A7876A");

            entity.ToTable("bill");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Datecheckin).HasColumnName("datecheckin");
            entity.Property(e => e.Datecheckout).HasColumnName("datecheckout");
            entity.Property(e => e.IdTable).HasColumnName("idTable");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.IdTableNavigation).WithMany(p => p.Bills)
                .HasForeignKey(d => d.IdTable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__bill__status__59FA5E80");
        });

        modelBuilder.Entity<Billinfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__billinfo__3213E83F28066C8F");

            entity.ToTable("billinfo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Idbill).HasColumnName("idbill");
            entity.Property(e => e.Idfood).HasColumnName("idfood");

            entity.HasOne(d => d.IdbillNavigation).WithMany(p => p.Billinfos)
                .HasForeignKey(d => d.Idbill)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__billinfo__idbill__5DCAEF64");

            entity.HasOne(d => d.IdfoodNavigation).WithMany(p => p.Billinfos)
                .HasForeignKey(d => d.Idfood)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__billinfo__idfood__5EBF139D");
        });

        modelBuilder.Entity<Food>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__food__3213E83F7CC14BC1");

            entity.ToTable("food");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idcategory).HasColumnName("idcategory");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Tenfood)
                .HasMaxLength(100)
                .HasDefaultValue("unnamed")
                .HasColumnName("tenfood");

            entity.HasOne(d => d.IdcategoryNavigation).WithMany(p => p.Foods)
                .HasForeignKey(d => d.Idcategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__food__idcategory__5629CD9C");
        });

        modelBuilder.Entity<Foodcategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Foodcate__3213E83F0708294E");

            entity.ToTable("Foodcategory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Tenmon)
                .HasMaxLength(100)
                .HasDefaultValue("Unnamed")
                .HasColumnName("tenmon");
        });

        modelBuilder.Entity<Tablefood>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tablefoo__3213E83F8C2EBBB1");

            entity.ToTable("tablefood");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("This table doesnt have name yet	")
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasDefaultValue("Empty")
                .HasColumnName("status");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

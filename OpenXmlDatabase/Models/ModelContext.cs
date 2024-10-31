using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OpenXmlDatabase.Models;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Assembly> Assemblies { get; set; }

    public virtual DbSet<GenericTypeArg> GenericTypeArgs { get; set; }

    public virtual DbSet<GenericTypesList> GenericTypesLists { get; set; }

    public virtual DbSet<Namespace> Namespaces { get; set; }

    public virtual DbSet<NestedGenericTypesList> NestedGenericTypesLists { get; set; }

    public virtual DbSet<NestedNormalTypesList> NestedNormalTypesLists { get; set; }

    public virtual DbSet<NormalTypesList> NormalTypesLists { get; set; }

    public virtual DbSet<Property> Properties { get; set; }

    public virtual DbSet<Type> Types { get; set; }

    public virtual DbSet<TypeKind> TypeKinds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseJet("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\OneDrive\\VS\\Projects\\DocxDocument\\OpenXmlDatabase\\OpenXml.accdb;Jet OLEDB:Database Password=****;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Assembly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.HasIndex(e => e.Name, "Name").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("ID");
        });

        modelBuilder.Entity<GenericTypeArg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.HasIndex(e => e.ArgTypeId, "ArgTypeId");

            entity.HasIndex(e => e.GenericTypeId, "GenericTypeId");

            entity.HasIndex(e => e.Id, "Id");

            entity.HasIndex(e => new { e.GenericTypeId, e.ArgNo, e.ArgTypeId }, "UniqueKey");

            entity.Property(e => e.Id).HasColumnType("counter");
            entity.Property(e => e.ArgNo).HasDefaultValue((byte)0);
        });

        modelBuilder.Entity<GenericTypesList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GenericTypesList");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.IsAbstract).HasColumnType("bit");
            entity.Property(e => e.IsGeneric).HasColumnType("bit");
            entity.Property(e => e.IsNested).HasColumnType("bit");
        });

        modelBuilder.Entity<Namespace>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.HasIndex(e => e.Id, "Id");

            entity.HasIndex(e => e.Name, "Name").IsUnique();

            entity.Property(e => e.Id).HasColumnType("counter");
            entity.Property(e => e.Prefix).HasMaxLength(15);
        });

        modelBuilder.Entity<NestedGenericTypesList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NestedGenericTypesList");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.IsAbstract).HasColumnType("bit");
            entity.Property(e => e.IsGeneric).HasColumnType("bit");
            entity.Property(e => e.IsNested).HasColumnType("bit");
        });

        modelBuilder.Entity<NestedNormalTypesList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NestedNormalTypesList");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.IsAbstract).HasColumnType("bit");
            entity.Property(e => e.IsGeneric).HasColumnType("bit");
            entity.Property(e => e.IsNested).HasColumnType("bit");
        });

        modelBuilder.Entity<NormalTypesList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NormalTypesList");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.IsAbstract).HasColumnType("bit");
            entity.Property(e => e.IsGeneric).HasColumnType("bit");
            entity.Property(e => e.IsNested).HasColumnType("bit");
        });

        modelBuilder.Entity<Property>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Name, "Name");

            entity.HasIndex(e => e.ParentTypeId, "ParentTypeId");

            entity.HasIndex(e => new { e.ParentTypeId, e.Name }, "UniqueKey");

            entity.HasIndex(e => e.ValueTypeId, "ValueTypeId");

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.IsAbstract)
                .HasDefaultValueSql("No")
                .HasColumnType("bit");
            entity.Property(e => e.IsOverride)
                .HasDefaultValueSql("No")
                .HasColumnType("bit");
            entity.Property(e => e.IsPublic)
                .HasDefaultValueSql("No")
                .HasColumnType("bit");
            entity.Property(e => e.IsStatic)
                .HasDefaultValueSql("No")
                .HasColumnType("bit");
            entity.Property(e => e.IsVirtual)
                .HasDefaultValueSql("No")
                .HasColumnType("bit");

            entity.HasOne(d => d.ParentType).WithMany(p => p.Properties)
                .HasForeignKey(d => d.ParentTypeId)
                .HasConstraintName("TypesProperties");
        });

        modelBuilder.Entity<Type>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.HasIndex(e => e.AssemblyId, "AssemblyId");

            entity.HasIndex(e => e.Name, "Name");

            entity.HasIndex(e => e.NamespaceId, "NamespaceId");

            entity.HasIndex(e => e.ParentTypeId, "ParentTypeId");

            entity.HasIndex(e => e.SuperTypeId, "SuperTypeId");

            entity.HasIndex(e => e.Tag, "Tag");

            entity.HasIndex(e => new { e.NamespaceId, e.ParentTypeId, e.Name }, "UniqueKey");

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.IsAbstract)
                .HasDefaultValueSql("No")
                .HasColumnType("bit");
            entity.Property(e => e.IsGeneric)
                .HasDefaultValueSql("No")
                .HasColumnType("bit");
            entity.Property(e => e.IsNested)
                .HasDefaultValueSql("No")
                .HasColumnType("bit");
            entity.Property(e => e.OfficeVersion).HasDefaultValue((byte)0);

            entity.HasOne(d => d.Namespace).WithMany(p => p.Types)
                .HasForeignKey(d => d.NamespaceId)
                .HasConstraintName("NamespacesTypes");
        });

        modelBuilder.Entity<TypeKind>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Kind).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

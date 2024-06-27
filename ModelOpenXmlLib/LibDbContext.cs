using System.Diagnostics;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using EntityFrameworkCore.Jet;
using DocumentFormat.OpenXml;

namespace ModelOpenXmlLib;

public sealed class LibDbContext : DbContext
{

  public DbSet<LibFile> Files { get; set; }

  public DbSet<Namespace> Namespaces { get; set; }

  public DbSet<FileNamespace> FileNamespaces { get; set; }

  public DbSet<TypeDef> Types { get; set; }

  public DbSet<EnumValue> EnumValues { get; set; }

  public DbSet<Property> Properties { get; set; }

  public string DbFilename { get; }

  public LibDbContext(string dbFilename)
  {
    DbFilename = dbFilename;
    Database.EnsureCreated();
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseJet(@$"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={DbFilename};");
    //optionsBuilder.EnableSensitiveDataLogging(true);
    //optionsBuilder.LogTo(message => Console.WriteLine(message));
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {

    modelBuilder.Entity<FileNamespace>()
      .HasKey(item => new { item.FileId, item.NamespaceId }); // Composite key

    modelBuilder.Entity<FileNamespace>()
      .HasOne(item => item.File)
      .WithMany(subItem => subItem.FileNamespaces)
      .HasForeignKey(item => item.FileId);

    modelBuilder.Entity<FileNamespace>()
      .HasOne(item => item.Namespace)
      .WithMany(subItem => subItem.FileNamespaces)
      .HasForeignKey(item => item.NamespaceId);

    modelBuilder.Entity<TypeDef>()
      .HasOne(item => item.BaseType)
      .WithMany(subItem => subItem.DerivedTypes)
      .HasForeignKey(item => item.BaseTypeId);

    modelBuilder.Entity<TypeDef>()
      .Property(item => item.Kind)
      .HasColumnType("byte");

    modelBuilder.Entity<TypeDef>()
      .Property(item => item.IsAbstract)
      .HasColumnType("bit");

    modelBuilder.Entity<EnumValue>()
      .HasOne(item => item.OwnerType)
      .WithMany(subItem => subItem.EnumValues)
      .HasForeignKey(item => item.OwnerTypeId);

    modelBuilder.Entity<Property>()
      .HasOne(item => item.OwnerType)
      .WithMany(subItem => subItem.Properties)
      .HasForeignKey(item => item.OwnerTypeId);

    modelBuilder.Entity<Property>()
      .HasOne(item => item.ValueType)
      .WithMany(subItem => subItem.UsedInProperties)
      .HasForeignKey(item => item.ValueTypeId);
  }

}

using System.Diagnostics;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using EntityFrameworkCore.Jet;
using DocumentFormat.OpenXml;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace ModelOpenXmlLib;

public sealed class LibDbContext : DbContext
{
  public DbSet<LibFile> Files { get; set; }

  public DbSet<Namespace> Namespaces { get; set; }

  public DbSet<FileNamespace> FileNamespaces { get; set; }

  public DbSet<TypeDef> Types { get; set; }

  public DbSet<EnumValue> EnumValues { get; set; }

  public DbSet<Property> Properties { get; set; }

  public Dictionary<string, LibFile> FilesDictionary { get; set; } = null!;

  public Dictionary<string, Namespace> NamespaceDictionary { get; set; } = null!;

  public string DbFilename { get; }

  public LibDbContext()
  {
    DbFilename = @"D:\VS\Docs\OpenXML\OpenXmlLib.accdb";
    Database.EnsureCreated();
  }

  public LibDbContext(string dbFilename)
  {
    DbFilename = dbFilename;
    Database.EnsureCreated();
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseJet(@$"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={DbFilename};");
    //optionsBuilder.EnableSensitiveDataLogging(true);
    optionsBuilder.LogTo(LogMessage);
  }

  public bool DisplayMessageEnabled { get; set; }

  public void LogMessage(string message)
  {
    if (DisplayMessageEnabled)
      Console.WriteLine(message);
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {

    modelBuilder.Entity<FileNamespace>()
      .HasKey(item => new { item.FileId, item.NamespaceId }); // Composite key

    //modelBuilder.Entity<FileNamespace>()
    //  .HasOne(item => item.File)
    //  .WithMany(subItem => subItem.FileNamespaces)
    //  .HasForeignKey(item => item.FileId);

    //modelBuilder.Entity<FileNamespace>()
    //  .HasOne(item => item.Namespace)
    //  .WithMany(subItem => subItem.FileNamespaces)
    //  .HasForeignKey(item => item.NamespaceId);

    modelBuilder.Entity<TypeDef>()
      .Property(item => item.Kind)
      .HasColumnType("byte");

    modelBuilder.Entity<TypeDef>()
      .Property(item => item.IsAbstract)
      .HasColumnType("bit");

    modelBuilder.Entity<TypeDef>()
      .HasOne(item => item.Namespace)
      .WithMany(subItem => subItem.Types)
      .HasForeignKey(item => item.NamespaceId);

    modelBuilder.Entity<TypeDef>()
      .HasOne(item => item.BaseType)
      .WithMany(subItem => subItem.DerivedTypes)
      .HasForeignKey(item => item.BaseTypeId);

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
      .WithMany()
      .HasForeignKey(item => item.ValueTypeId);

    //modelBuilder.Entity<Property>()
    //  .Property(p => p.ValueType)
    //  .UsePropertyAccessMode(PropertyAccessMode.Property);
  }



  public void LoadFiles()
  {
    FilesDictionary = Files.ToDictionary(file => file.FileName);
    NamespaceDictionary = Namespaces.ToDictionary(ns => ns.Name ?? "");

    Files.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (LibFile file in args.NewItems!)
        {
          FilesDictionary.Add(file.FileName ?? "", file);
        }
      }
    };

    Namespaces.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Namespace ns in args.NewItems!)
        {
          NamespaceDictionary.Add(ns.Name ?? "", ns);
        }
      }
    };

  }

  public void LoadNamespaces()
  {
    //DisplayMessageEnabled = true;
    foreach (var ns in Namespaces
               .Include(ns => ns.Types).
               ThenInclude(aType => aType.EnumValues)
               .Include(ns => ns.Types)
               .ThenInclude(aType => aType.Properties)
               )
    {
      ns.TypesDictionary = ns.Types.ToDictionary(type => type.Name, type => type);
      foreach (var type in ns.TypesDictionary.Values)
      {
        type.EnumValuesDictionary = type.EnumValues.ToDictionary(enumValue => enumValue.Name, enumValue => enumValue);
        type.PropertiesDictionary = type.Properties.ToDictionary(prop => prop.Name, prop => prop);
      }
    }
    Types.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (TypeDef type in args.NewItems!)
        {
          NamespaceDictionary[type.Namespace.Name ?? ""].TypesDictionary.Add(type.Name, type);
        }
      }
    };
    EnumValues.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (EnumValue enumValue in args.NewItems!)
        {
          NamespaceDictionary[enumValue.OwnerType.Namespace.Name ?? ""].TypesDictionary[enumValue.OwnerType.Name].EnumValuesDictionary.Add(enumValue.Name, enumValue);
        }
      }
    };
    Properties.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Property prop in args.NewItems!)
        {
          NamespaceDictionary[prop.OwnerType.Namespace.Name ?? ""].TypesDictionary[prop.OwnerType.Name].PropertiesDictionary.Add(prop.Name, prop);
        }
      }
    };
  }

}

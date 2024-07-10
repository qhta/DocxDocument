using DocumentFormat.OpenXml.Math;
using System.Diagnostics;
using System.Net.Mime;
using System.Runtime.InteropServices;

using Microsoft.EntityFrameworkCore;
using Access = Microsoft.Office.Interop.Access;
using DAO = Microsoft.Office.Interop.Access.Dao;

using Qhta.Access.Dao;

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
    SetupAccessDatabase();
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

  internal void SetupAccessDatabase()
  {
    var accessApp = new Access.Application();
    DAO.Database database = null!;
    try
    {
      accessApp.OpenCurrentDatabase(DbFilename, false);
      database = accessApp.CurrentDb();

      Tools.CreateEnumLookupTable(database, "TypeKinds", typeof(TypeKind));
      Tools.SetLookup(database, "Types", "Kind", "TypeKinds");
    }
    catch (Exception ex)
    {
      Debug.WriteLine($"An error occurred: {ex.Message}");
    }
    finally
    {
      if (database != null)
      {
        accessApp.CloseCurrentDatabase();
      }
      accessApp.Quit(Access.AcQuitOption.acQuitSaveAll);
      Marshal.ReleaseComObject(accessApp);
      accessApp = null!;
      // For good measure, force a garbage collection
      GC.Collect();
      GC.WaitForPendingFinalizers();
      Tools.KillMsAccess();
    }
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {

    modelBuilder.Entity<FileNamespace>()
      .HasKey(item => new { item.FileId, item.NamespaceId });

    modelBuilder.Entity<FileNamespace>()
      .HasOne(item => item.File)
      .WithMany()
      .HasForeignKey(item => item.FileId);

    modelBuilder.Entity<FileNamespace>()
      .HasOne(item => item.Namespace)
      .WithMany()
      .HasForeignKey(item => item.NamespaceId);

    modelBuilder.Entity<TypeDef>()
      .HasOne(item => item.OwnerNamespace)
      .WithMany(subItem => subItem.Types)
      .HasForeignKey(item => item.OwnerNamespaceId);

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
          FilesDictionary.Add(file.FileName, file);
        }
      }
    };

    Namespaces.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Namespace ns in args.NewItems!)
        {
          NamespaceDictionary.Add(ns.Name, ns);
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
          NamespaceDictionary[type.OwnerNamespace.Name].TypesDictionary.Add(type.Name, type);
        }
      }
    };
    EnumValues.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (EnumValue enumValue in args.NewItems!)
        {
          NamespaceDictionary[enumValue.OwnerType.OwnerNamespace.Name].TypesDictionary[enumValue.OwnerType.Name].EnumValuesDictionary.Add(enumValue.Name, enumValue);
        }
      }
    };
    Properties.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Property prop in args.NewItems!)
        {
          NamespaceDictionary[prop.OwnerType.OwnerNamespace.Name].TypesDictionary[prop.OwnerType.Name].PropertiesDictionary.Add(prop.Name, prop);
        }
      }
    };
  }

}

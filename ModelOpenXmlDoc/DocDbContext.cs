using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Math;
using System.Diagnostics;
using System.Runtime.InteropServices;

using DocumentFormat.OpenXml.Wordprocessing;

using Microsoft.EntityFrameworkCore;
using Access = Microsoft.Office.Interop.Access;
using DAO = Microsoft.Office.Interop.Access.Dao;

using Qhta.Access.Dao;

namespace ModelOpenXmlDoc;

public sealed class DocDbContext : DbContext
{
  public DbSet<DocFile> Files { get; set; }

  public DbSet<Chapter> Chapters { get; set; }

  public DbSet<SimpleType> SimpleTypes { get; set; }

  public DbSet<EnumValue> EnumValues { get; set; }

  public DbSet<Element> Elements { get; set; }

  public DbSet<Attribute> Attributes { get; set; }

  public Dictionary<string, DocFile> FilesDictionary { get; set; } = null!;
  public Dictionary<int, DocFile> FilesIndex { get; set; } = null!;

  public Dictionary<string, Chapter> ChaptersDictionary { get; set; } = null!;
  public Dictionary<int, Chapter> ChaptersIndex { get; set; } = null!;

  public string DbFilename { get; }

  public DocDbContext()
  {
    DbFilename = @"D:\VS\Docs\OpenXML\OpenXmlLib.accdb";
    Database.EnsureCreated();
    SetupAccessDatabase();
  }

  public DocDbContext(string dbFilename)
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

      Tools.SetQuery(database, "ChaptersView", "SELECT Chapters.Id, [NumStr] & \" \" & [Heading] AS Title\r\nFROM Chapters;");
      Tools.SetQuery(database, "SimpleTypesView", "SELECT SimpleTypes.Id, SimpleTypes.ShortName, ChaptersView.Title AS Chapter\r\nFROM SimpleTypes INNER JOIN ChaptersView ON SimpleTypes.OwnerChapterId = ChaptersView.Id;");
      Tools.SetQuery(database, "ElementsView", "SELECT Elements.Id, Elements.ShortName, ChaptersView.Title AS OwnerChapter\r\nFROM Elements INNER JOIN ChaptersView ON Elements.OwnerChapterId = ChaptersView.Id;");
      Tools.SetQuery(database, "AttributesView", "SELECT Attributes.Id, Attributes.OwnerElementId, Attributes.ShortName, Attributes.LongName, Attributes.Namespace, ElementsView.ShortName AS OwnerElement, ElementsView.OwnerChapter, Attributes.DescriptionText, Len([Attributes].[DescriptionText]) AS Length\r\nFROM Attributes INNER JOIN ElementsView ON Attributes.OwnerElementId = ElementsView.Id;");
      Tools.SetQuery(database, "EnumValuesView", "SELECT EnumValues.Id, EnumValues.OrdNum, EnumValues.Value, EnumValues.LongName, SimpleTypesView.ShortName AS OwnerType, SimpleTypesView.Chapter AS OwnerChapter, EnumValues.DescriptionText\r\nFROM EnumValues INNER JOIN SimpleTypesView ON EnumValues.OwnerTypeId = SimpleTypesView.Id;");
      //Tools.CreateEnumLookupTable(database, "TypeKinds", typeof(TypeKind));
      //Tools.SetLookup(database, "Types", "Kind", "TypeKinds");
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
    modelBuilder.Entity<Chapter>()
      .HasOne(item => item.OwnerFile)
      .WithMany(f => f.Chapters)
      .HasForeignKey(item => item.OwnerFileId);

    modelBuilder.Entity<Chapter>()
      .HasOne(item => item.ParentChapter)
      .WithMany(subItem => subItem.SubChapters)
      .HasForeignKey(item => item.ParentChapterId);

    modelBuilder.Entity<SimpleType>()
      .HasOne(item => item.OwnerChapter)
      .WithMany(chapter => chapter.SimpleTypes)
      .HasForeignKey(item => item.OwnerChapterId);

    modelBuilder.Entity<EnumValue>()
      .HasOne(item => item.OwnerType)
      .WithMany(type => type.EnumValues)
      .HasForeignKey(item => item.OwnerTypeId);

    modelBuilder.Entity<Element>()
      .HasOne(item => item.OwnerChapter)
      .WithMany(chapter => chapter.Elements)
      .HasForeignKey(item => item.OwnerChapterId);

    modelBuilder.Entity<Attribute>()
      .HasOne(item => item.OwnerElement)
      .WithMany(type => type.Attributes)
      .HasForeignKey(item => item.OwnerElementId);
  }

  public void LoadFiles()
  {
    FilesDictionary = Files.ToDictionary(file => file.FileName);
    FilesIndex = Files.ToDictionary(file => file.Id);

    Files.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (DocFile file in args.NewItems!)
        {
          if (file.Id != 0)
            FilesIndex.TryAdd(file.Id, file);
        }
      }
    };

  }

  public void LoadChapters()
  {
    ChaptersDictionary = Chapters.ToDictionary(chapter => chapter.NumStr);
    ChaptersIndex = Chapters.ToDictionary(chapter => chapter.Id);    

    foreach (var file in Files
               .Include(f => f.Chapters)
               )

    {
      file.ChaptersDictionary = file.Chapters.ToDictionary(Chapter => Chapter.NumStr, chapter => chapter);
    }

    foreach (var chapter in Chapters
               .Include(f => f.SubChapters)
               .Include(f => f.SimpleTypes)
               .Include(f => f.Elements)
            )
    {
      chapter.HasSubChapters = chapter.SubChapters.Count > 0;
      if (chapter.HasSubChapters)
        chapter.SubChaptersDictionary = chapter.SubChapters.ToDictionary(Chapter => Chapter.NumStr);
      chapter.HasSimpleTypes = chapter.SimpleTypes.Count > 0;
      if (chapter.HasSimpleTypes)
        chapter.SimpleTypesDictionary = chapter.SimpleTypes.ToDictionary(SimpleType => SimpleType.ShortName);
      chapter.HasElements = chapter.Elements.Count > 0;
      if (chapter.HasElements)
        chapter.ElementsDictionary = chapter.Elements.ToDictionary(item => item.ShortName);
    }

    Chapters.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Chapter chapter in args.NewItems!)
        {
          chapter.OwnerFile.ChaptersDictionary.TryAdd(chapter.NumStr, chapter);
          ChaptersDictionary.TryAdd(chapter.NumStr, chapter);
          if (chapter.Id != 0)
            ChaptersIndex.TryAdd(chapter.Id, chapter);
          if (chapter.ParentChapterId != null)
          {
            chapter.ParentChapter = ChaptersIndex[chapter.ParentChapterId!.Value];
            chapter.ParentChapter.SubChaptersDictionary.TryAdd(chapter.NumStr, chapter);
          }
        }
      }
    };

    SimpleTypes.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (SimpleType simpleType in args.NewItems!)
        {
          simpleType.OwnerChapter.SimpleTypesDictionary.TryAdd(simpleType.ShortName, simpleType);
        }
      }
    };

    foreach (var simpleType in SimpleTypes
               .Include(f => f.EnumValues)
            )
    {
      simpleType.IsEnum = simpleType.EnumValues.Count > 0;
      if (simpleType.IsEnum)
        simpleType.EnumValuesDictionary = simpleType.EnumValues.ToDictionary(ev => ev.Value);
    }

    EnumValues.Local.CollectionChanged += (sender, args) =>
      {
        if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
        {
          foreach (EnumValue enumValue in args.NewItems!)
          {
            enumValue.OwnerType.EnumValuesDictionary.TryAdd(enumValue.Value, enumValue);
          }
        }
      };

    Elements.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Element element in args.NewItems!)
        {
          element.OwnerChapter.ElementsDictionary.TryAdd(element.ShortName, element);
        }
      }
    };

    foreach (var element in Elements
               .Include(f => f.Attributes)
            )
    {
      element.HasAttributes = element.Attributes.Count > 0;
      if (element.HasAttributes)
      {
        element.AttributesDictionary = element.Attributes.ToDictionary(at => at.ShortName);
      }
    }

    foreach (var attribute in Attributes
               .Include(f => f.OwnerElement)
            )
    {
      attribute.OwnerElement.AttributesDictionary.TryAdd(attribute.ShortName, attribute);
    }

    Attributes.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Attribute attribute in args.NewItems!)
        {
          attribute.OwnerElement.AttributesDictionary.TryAdd(attribute.ShortName, attribute);
        }
      }
    };

  }

}

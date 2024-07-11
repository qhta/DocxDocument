using System.Diagnostics;
using System.Runtime.InteropServices;

using Microsoft.EntityFrameworkCore;
using Access = Microsoft.Office.Interop.Access;
using DAO = Microsoft.Office.Interop.Access.Dao;

using Qhta.Access.Dao;

namespace ModelOpenXmlCmt;

public sealed class CmtDbContext : DbContext
{
  public DbSet<CmtFile> Files { get; set; }

  public DbSet<Member> Members { get; set; }

  public Dictionary<string, CmtFile> FilesDictionary { get; set; } = null!;
  public Dictionary<int, CmtFile> FilesIndex { get; set; } = null!;

  public Dictionary<string, Member> MembersDictionary { get; set; } = null!;
  public Dictionary<int, Member> MembersIndex { get; set; } = null!;

  public string DbFilename { get; }

  public CmtDbContext(): this(@"D:\VS\Docs\OpenXML\OpenXmlCmt.accdb")
  {
  }

  public CmtDbContext(string dbFilename)
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

      //Tools.SetQuery(database, "ChaptersView", "SELECT Chapters.Id, [NumStr] & \" \" & [Heading] AS Title\r\nFROM Chapters;");
      //Tools.SetQuery(database, "SimpleTypesView", "SELECT SimpleTypes.Id, SimpleTypes.ShortName, ChaptersView.Title AS Chapter\r\nFROM SimpleTypes INNER JOIN ChaptersView ON SimpleTypes.OwnerChapterId = ChaptersView.Id;");
      //Tools.SetQuery(database, "ElementsView", "SELECT Elements.Id, Elements.ShortName, ChaptersView.Title AS OwnerChapter\r\nFROM Elements INNER JOIN ChaptersView ON Elements.OwnerChapterId = ChaptersView.Id;");
      //Tools.SetQuery(database, "AttributesView", "SELECT Attributes.Id, Attributes.OwnerElementId, Attributes.ShortName, Attributes.LongName, Attributes.Namespace, ElementsView.ShortName AS OwnerElement, ElementsView.OwnerChapter, Attributes.DescriptionText, Len([Attributes].[DescriptionText]) AS Length\r\nFROM Attributes INNER JOIN ElementsView ON Attributes.OwnerElementId = ElementsView.Id;");
      //Tools.SetQuery(database, "EnumValuesView", "SELECT EnumValues.Id, EnumValues.OrdNum, EnumValues.Value, EnumValues.LongName, SimpleTypesView.ShortName AS OwnerType, SimpleTypesView.Chapter AS OwnerChapter, EnumValues.DescriptionText\r\nFROM EnumValues INNER JOIN SimpleTypesView ON EnumValues.OwnerTypeId = SimpleTypesView.Id;");
      Tools.CreateEnumLookupTable(database, "MembersType", typeof(MemberType));
      Tools.SetLookup(database, "Members", "Type", "MembersType");
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
    modelBuilder.Entity<Member>()
      .HasOne(item => item.OwnerFile)
      .WithMany(f => f.Members)
      .HasForeignKey(item => item.OwnerFileId);

    modelBuilder.Entity<Member>()
      .HasOne(item => item.ParentMember)
      .WithMany(subItem => subItem.Members)
      .HasForeignKey(item => item.ParentMemberId)
      .IsRequired(false);

  }

  public void LoadFiles()
  {
    FilesDictionary = Files.ToDictionary(file => file.FileName);
    FilesIndex = Files.ToDictionary(file => file.Id);

    Files.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (CmtFile file in args.NewItems!)
        {
          if (file.Id != 0)
            FilesIndex.TryAdd(file.Id, file);
        }
      }
    };

  }

  public void LoadMembers()
  {
    MembersDictionary = Members.ToDictionary(m => m.FullName);
    MembersIndex = Members.ToDictionary(m => m.Id);

    foreach (var file in Files
               .Include(f => f.Members)
               )

    {
      file.MembersDictionary = file.Members.ToDictionary(member => member.FullName, member => member);
    }

    foreach (var member in Members
               .Include(f => f.Members)
            )
    {
      member.HasMembers = member.Members.Count > 0;
      if (member.HasMembers)
        member.MembersDictionary = member.Members.ToDictionary(m => m.FullName);
    }

    Members.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Member member in args.NewItems!)
        {
          //member.OwnerFile.MembersDictionary.TryAdd(member => member.FullName, member => member);
          //MembersDictionary.TryAdd(chapter.NumStr, chapter);
          //if (chapter.Id != 0)
          //  MembersIndex.TryAdd(chapter.Id, chapter);
          //if (chapter.ParentChapterId != null)
          //{
          //  chapter.ParentChapter = MembersIndex[chapter.ParentChapterId!.Value];
          //  chapter.ParentChapter.SubChaptersDictionary.TryAdd(chapter.NumStr, chapter);
          //}
        }
      }
    };

  }

}

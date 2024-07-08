using Microsoft.EntityFrameworkCore;

namespace ModelOpenXmlDoc;

public sealed class DocDbContext : DbContext
{
  public DbSet<DocFile> Files { get; set; }

  public DbSet<Chapter> Chapters { get; set; }

  public Dictionary<string, DocFile> FilesDictionary { get; set; } = null!;
  public Dictionary<int, DocFile> FilesIndex { get; set; } = null!;

  public Dictionary<string, Chapter> ChaptersDictionary { get; set; } = null!;
  public Dictionary<int, Chapter> ChaptersIndex { get; set; } = null!;

  public string DbFilename { get; }

  public DocDbContext()
  {
    DbFilename = @"D:\VS\Docs\OpenXML\OpenXmlLib.accdb";
    Database.EnsureCreated();
  }

  public DocDbContext(string dbFilename)
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
    modelBuilder.Entity<Chapter>()
      .HasOne(item => item.OwnerFile)
      .WithMany(f => f.Chapters)
      .HasForeignKey(item => item.OwnerFileId);

    modelBuilder.Entity<Chapter>()
      .HasOne(item => item.ParentChapter)
      .WithMany(subItem => subItem.SubChapters)
      .HasForeignKey(item => item.ParentChapterId);

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
            )
    {
      chapter.SubChaptersDictionary = chapter.SubChapters.ToDictionary(Chapter => Chapter.NumStr);
      chapter.HasSubChapters = chapter.SubChapters.Count > 0;
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

  }

}

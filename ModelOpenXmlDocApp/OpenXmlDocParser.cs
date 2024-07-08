using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata;

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml.Wordprocessing;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using ModelOpenXmlDoc;

using Qhta.OpenXMLTools;
using ParaTools = Qhta.OpenXMLTools.ParagraphTools;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Xml.Schema;

namespace ModelOpenXmlDocApp;


/// <summary>
/// Parser that reads XML schema files and stores the schema in a database.
/// </summary>
public class OpenXmlDocParser
{
  public string SourceDocPath { get; set; } = null!;
  public int FilesTotal, FilesAdded;
  public int ChaptersTotal, ChaptersAdded, ChaptersUpdated;

  public void ParseSchemaFiles(string sourceDllPath, string dbFilename)
  {
    SourceDocPath = sourceDllPath;
    using (dbContext = new DocDbContext(dbFilename))
    {
      dbContext.ChangeTracker.LazyLoadingEnabled = false;
      LoadDocumentFiles();
      ParseDocuments();
      dbContext.DisplayMessageEnabled = false;
      FilesTotal = dbContext.Files.Count();
      ChaptersTotal = dbContext.Chapters.Count();
    }
  }

  internal int AnonSimpleTypes = 0;
  internal DocDbContext dbContext = null!;


  internal int SaveChanges()
  {
    try
    {
      var changes = dbContext.SaveChanges();
      return changes;
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      //throw;
      return -1;
    }
  }

  internal void Write(string? message)
  {
    Console.Write(message);
  }

  internal void WriteLine(string? message)
  {
    Console.WriteLine(message);
  }

  internal void LoadDocumentFiles()
  {
    dbContext.LoadFiles();
    List<DocFile> files = new();
    var docsPaths = Directory.GetFiles(SourceDocPath, "*.docx");
    foreach (var path in docsPaths)
    {
      var filename = Path.GetFileName(Path.GetFileNameWithoutExtension(Path.GetFileName(path)));
      if (path.StartsWith('$')) continue;

      if (!dbContext.FilesDictionary.TryGetValue(filename, out var docFile))
      {
        WriteLine($"Adding file {filename}");
        docFile = new DocFile() { FileName = filename };
        dbContext.Files.Add(docFile);
        if (SaveChanges() > 0)
        {
          dbContext.FilesIndex.TryAdd(docFile.Id, docFile);
          FilesAdded++;
        }
      }
    }
    dbContext.LoadFiles();
  }

  internal void ParseDocuments()
  {
    dbContext.LoadChapters();
    foreach (var docFile in dbContext.Files.ToList())
    {
      var filename = Path.Combine(SourceDocPath, docFile.FileName + ".docx");
      using (var document = WordprocessingDocument.Open(filename, false))
      {
        ParseDoc(docFile, document);
      }
    };
  }
  internal void ParseDoc(DocFile docFile, WordprocessingDocument document)
  {
    var mainPart = document.MainDocumentPart;
    if (mainPart == null) return;
    var body = mainPart.Document.Body;
    if (body == null) return;
    var paragraphs = body.Elements<Paragraph>();
    var paragraph = paragraphs.FirstOrDefault();
    var ordNum = 1;
    while (paragraph != null)
    {
      if (paragraph.IsHeading())
      {
        var text = paragraph.GetText();
        ParseChapter(docFile, ref paragraph, ordNum++);
      }
      paragraph = paragraph.NextSibling<Paragraph>();
    }
  }

  internal bool ParseChapter(DocFile docFile, ref Paragraph paragraph, int ordNum)
  {
    bool added = false;
    bool updated = false;
    var text = paragraph.GetText();
    string number = GetNumber(text, out string heading) ?? ordNum.ToString();
    var parentNumber = GetParentNumber(number, out var thisNum);
    Write($"Checking chapter {number} {heading} ... ");
    if (!docFile.ChaptersDictionary.TryGetValue(number, out var chapter))
    {
      chapter = new Chapter { OwnerFileId = docFile.Id, OrdNum = thisNum, NumStr = number, Heading = heading };
      if (parentNumber != null && dbContext.ChaptersDictionary.TryGetValue(parentNumber, out var parentChapter))
      {
        chapter.ParentChapterId = parentChapter.Id;
        if (!parentChapter.HasSubChapters)
        {
          parentChapter.HasSubChapters = true;
          dbContext.Chapters.Update(parentChapter);
        }
      }
      chapter.OrdNum = thisNum;
      dbContext.Chapters.Add(chapter);
      if (SaveChanges() > 0)
      {
        dbContext.ChaptersIndex.TryAdd(chapter.Id, chapter);
        ChaptersAdded++;
        added = true;
      }
    }
    else
    {
      if (chapter.OrdNum != thisNum)
      {
        chapter.OrdNum = thisNum;
        updated = true;
      }
      if (chapter.NumStr != number)
      {
        chapter.NumStr = number;
        updated = true;
      }
      if (chapter.Heading != heading)
      {
        chapter.Heading = heading;
        updated = true;
      }
      if (updated)
        dbContext.Chapters.Update(chapter);
      if (SaveChanges() > 0)
        ChaptersUpdated++;
    }
    if (added)
      WriteLine("added");
    else if (updated)
      WriteLine("updated");
    else
      WriteLine("ok");
    return added || updated;
  }

  internal string? GetNumber(string text, out string heading)
  {
    for (int i = 0; i < text.Length; i++)
    {
      if (!(Char.IsDigit(text[i]) || text[i] == '.'))
      {
        heading = text.Substring(i).Trim();
        var number = text.Substring(0, i);
        if (number.EndsWith('.'))
          number = number.Substring(0, number.Length - 1);
        return number;
      }
    }
    heading = text;
    return null;
  }

  internal string? GetParentNumber(string number, out int thisNum)
  {
    var k = number.LastIndexOf('.');
    if (k > 0)
    { 
      thisNum = int.Parse(number.Substring(k + 1));
      return number.Substring(0, k);
    }
    thisNum = int.Parse(number);
    return null;
  }

}

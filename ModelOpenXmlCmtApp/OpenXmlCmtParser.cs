using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

using ModelOpenXmlCmt;


namespace ModelOpenXmlCmtApp;


/// <summary>
/// Parser that reads XML schema files and stores the schema in a database.
/// </summary>
public class OpenXmlCmtParser
{
  public string SourceDocPath { get; set; } = null!;
  public int FilesTotal, FilesAdded;
  public int MembersTotal, MembersAdded, MembersUpdated;


  public void ParseDocuments(string sourceDocPath, string dbFilename)
  {
    SourceDocPath = sourceDocPath;
    using (dbContext = new CmtDbContext(dbFilename))
    {
      dbContext.ChangeTracker.LazyLoadingEnabled = false;
      LoadXmlFiles();
      ParseXmlDocuments();
      dbContext.DisplayMessageEnabled = false;
      FilesTotal = dbContext.Files.Count();
      MembersTotal = dbContext.Members.Count();
    }
  }

  internal CmtDbContext dbContext = null!;


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

  internal void LoadXmlFiles()
  {
    dbContext.LoadFiles();
    List<CmtFile> files = new();
    var docsPaths = Directory.GetFiles(SourceDocPath, "*.xml");
    foreach (var path in docsPaths)
    {
      var filename = Path.GetFileName(Path.GetFileNameWithoutExtension(Path.GetFileName(path)));
      if (filename.StartsWith('~')) continue;

      if (!dbContext.FilesDictionary.TryGetValue(filename, out var docFile))
      {
        WriteLine($"Adding file {filename}");
        docFile = new CmtFile() { FileName = filename };
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

  internal void ParseXmlDocuments()
  {
    dbContext.LoadMembers();
    foreach (var docFile in dbContext.Files.ToList())
    {
      var filename = Path.Combine(SourceDocPath, docFile.FileName + ".xml");
      XDocument document = null!;
      while (document == null)
        try
        {
          document = XDocument.Load(filename);
          docFile.Document = document;
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Error opening file {filename}: {ex.Message}");
          Console.Write($"Abort, Retry, Ignore? ");
          ConsoleKeyInfo key;
          do
          {
            key = Console.ReadKey();
            Console.Write(new String(key.KeyChar, 1));
          } while (key.Key != ConsoleKey.A && key.Key != ConsoleKey.I && key.Key != ConsoleKey.R);
          Console.WriteLine("");
          if (key.Key == ConsoleKey.A)
            return;
          if (key.Key == ConsoleKey.I)
            break;
          if (key.Key == ConsoleKey.R)
            continue;
        }
      ParseDoc(docFile);
    }
    ;
  }

  internal void ParseDoc(CmtFile docFile)
  {
    var doc = docFile.Document.Root;
    if (doc == null)
      throw new InvalidDataException($"Cannot find root element in file {docFile.FileName}");
    foreach (var element in doc.Elements())
    {
      if (element.Name.LocalName == "members")
      {
        foreach (var xElement in element.Elements())
          ParseMember(docFile, xElement);
      }
    }
  }

  internal bool ParseMember(CmtFile docFile, XElement xElement)
  {
    bool added = false;
    bool updated = false;
    var name = xElement.Attribute("name")?.Value;
    if (name == null)
      throw new InvalidDataException("Member element must have a name attribute");
    if (name.Length <= 2)
      throw new InvalidDataException($"Member name \"{name}\" is too short");
    if (name[1] != ':')
      throw new InvalidDataException($"Invalid member name \"{name}\"");
    MemberType memberType = name[0] switch
    {
      'T' => MemberType.Type,
      'F' => MemberType.Field,
      'P' => MemberType.Property,
      'M' => MemberType.Method,
      'E' => MemberType.Event,
      _ => throw new InvalidDataException($"Unrecognized member type \"{name[0]}\"")
    };
    if (memberType == MemberType.Method || memberType == MemberType.Event)
    {
      return false;
    }


    var fullName = name;
    name = name.Substring(2);
    var k = name.IndexOf('(');
    if (k > 0)
      name = name.Substring(0, k);
    k = name.LastIndexOf('.');
    if (k > 0)
      name = name.Substring(k + 1);
    Write($"Checking member {fullName} ... ");
    if (!docFile.MembersDictionary.TryGetValue(fullName, out var member))
    {
      member = new Member { OwnerFileId = docFile.Id, FullName = fullName, ShortName = name, Type = memberType};
      //if (parentNumber != null && dbContext.ChaptersDictionary.TryGetValue(parentNumber, out var parentChapter))
      //{
      //  chapter.ParentChapterId = parentChapter.Id;
      //  if (!parentChapter.HasSubChapters)
      //  {
      //    parentChapter.HasSubChapters = true;
      //    dbContext.Chapters.Update(parentChapter);
      //  }
      //}
      dbContext.Members.Add(member);
      if (SaveChanges() > 0)
      {
        dbContext.MembersIndex.TryAdd(member.Id, member);
        MembersAdded++;
        added = true;
      }
    }
    else
    {
      //if (chapter.OrdNum != thisNum)
      //{
      //  chapter.OrdNum = thisNum;
      //  updated = true;
      //}
      //if (chapter.NumStr != number)
      //{
      //  chapter.NumStr = number;
      //  updated = true;
      //}
      //if (chapter.Heading != heading)
      //{
      //  chapter.Heading = heading;
      //  updated = true;
      //}
      //if (chapter.ParagraphId != paragraph.ParagraphId?.Value)
      //{
      //  chapter.ParagraphId = paragraph.ParagraphId?.Value;
      //  updated = true;
      //}
    }

    if (updated)
    {
      dbContext.Members.Update(member);
      if (SaveChanges() > 0)
        MembersUpdated++;
    }

    if (added)
      WriteLine("added");
    else if (updated)
      WriteLine("updated");
    else
      WriteLine("ok");
    return true;
  }
}

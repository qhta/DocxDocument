using System.Data;
using System.Diagnostics.CodeAnalysis;

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using ModelOpenXmlDoc;

using Qhta.OpenXMLTools;

using ParaTools = Qhta.OpenXMLTools.ParagraphTools;
using Table = DocumentFormat.OpenXml.Wordprocessing.Table;

namespace ModelOpenXmlDocApp;


/// <summary>
/// Parser that reads XML schema files and stores the schema in a database.
/// </summary>
public class OpenXmlDocParser
{
  public string SourceDocPath { get; set; } = null!;
  public int FilesTotal, FilesAdded;
  public int ChaptersTotal, ChaptersAdded, ChaptersUpdated;
  public int SimpleTypesTotal, SimpleTypesAdded, SimpleTypesUpdated;
  public int EnumValuesTotal, EnumValuesAdded, EnumValuesUpdated;

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
      SimpleTypesTotal = dbContext.SimpleTypes.Count();
      EnumValuesTotal = dbContext.EnumValues.Count();
    }
  }

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
      if (filename.StartsWith('~')) continue;

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
        docFile.Document = document;
        if (docFile.Document == null)
          continue;
        ParseDoc(docFile);
        docFile.Document = null;
      }
    };
  }
  internal void ParseDoc(DocFile docFile)
  {

    var paragraphs = docFile.Document!.MainDocumentPart!.Document!.Body!.Elements<Paragraph>();
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
    foreach (var chapter in docFile.Chapters.Where(item => item.Heading == "Simple Types"))
    {
      if (chapter.SubChapters.Count > 0)
      {
        var subChapters = chapter.SubChapters.OrderBy(ch => ch.OrdNum);
        foreach (var subChapter in subChapters)
        {
          ParseSimpleTypeChapter(subChapter);
        }
      }
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
      chapter = new Chapter { OwnerFileId = docFile.Id, OrdNum = thisNum, NumStr = number, Heading = heading, ParagraphId = paragraph.ParagraphId };
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
      if (chapter.ParagraphId != paragraph.ParagraphId?.Value)
      {
        chapter.ParagraphId = paragraph.ParagraphId?.Value;
        updated = true;
      }
    }
    var nextParagraph = paragraph.NextSibling<Paragraph>();
    var isFirst = true;
    while (nextParagraph != null && !nextParagraph.IsHeading())
    {
      paragraph = nextParagraph;
      if (isFirst)
      {
        var firstParaText = paragraph.GetText();
        if (chapter.FirstParaText != firstParaText)
        {
          chapter.FirstParaText = firstParaText;
          updated = true;
        }
      }
      isFirst = false;
      nextParagraph = paragraph.NextSibling<Paragraph>();
    }

    if (updated)
    {
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


  internal bool ParseSimpleTypeChapter(Chapter chapter)
  {
    bool added = false;
    bool updated = false;
    bool isEnum = false;

    var text = chapter.Heading;
    if (!SplitName(text, out var shortName, out var longName))
      throw new InvalidDataException($"Cannot split heading {text} to short name and long name");

    Write($"Checking simple type {shortName} ({longName}) ... ");
    Table? enumTable = null;
    var fromParagraph = ParaTools.FindParagraph(chapter.OwnerFile.Document!, chapter.ParagraphId!);
    var element = fromParagraph?.NextSibling();
    while (element != null && (element as Paragraph)?.IsHeading() != true)
    {
      if (element is Table table)
      {
        var firstCellPara = table.Elements<TableRow>().FirstOrDefault()?.Elements<TableCell>().FirstOrDefault()?.Elements<Paragraph>().FirstOrDefault();
        if (firstCellPara != null)
        {
          var firstCellText = firstCellPara.GetText();
          if (firstCellText == "Enumeration Value")
          {
            isEnum = true;
            enumTable = table;
          }
          break;
        }
      }
      element = element.NextSibling();
    }
    if (!chapter.SimpleTypesDictionary.TryGetValue(shortName, out var simpleType))
    {
      simpleType = new SimpleType { OwnerChapterId = chapter.Id, ShortName = shortName, LongName = longName, IsEnum = isEnum };
      dbContext.SimpleTypes.Add(simpleType);
      if (SaveChanges() > 0)
      {
        added = true;
        SimpleTypesAdded++;
      }
    }
    else
    {
      if (simpleType.LongName != longName)
      {
        simpleType.LongName = longName;
        updated = true;
      }
      if (simpleType.IsEnum != isEnum)
      {
        simpleType.IsEnum = isEnum;
        updated = true;
      }
    }

    if (updated)
      dbContext.SimpleTypes.Update(simpleType);
    if (SaveChanges() > 0)
      SimpleTypesUpdated++;

    if (added)
      WriteLine("added");
    else if (updated)
      WriteLine("updated");
    else
      WriteLine("ok");

    if (isEnum)
    {
      ParseEnumValues(simpleType, enumTable!);
    }
    return added || updated;
  }

  internal bool SplitName(string heading, [NotNullWhen(true)] out string? shortName, [NotNullWhen(true)] out string? longName)
  {
    var k = heading.IndexOf('(');
    if (k > 0 && heading.EndsWith(")"))
    {
      shortName = heading.Substring(0, k).Trim();
      longName = heading.Substring(k + 1, heading.Length - k - 2).Trim();
      return true;
    }
    shortName = null;
    longName = null;
    return false;
  }

  internal void ParseEnumValues(SimpleType simpleType, Table table)
  {
    var rows = table.Elements<TableRow>().Skip(1);
    int ordNum = 0;
    foreach (var row in rows)
    {
      ParseEnumValue(simpleType, row, ordNum++);
    }
  }

  internal bool ParseEnumValue(SimpleType simpleType, TableRow row, int ordNum)
  {
    bool added = false;
    bool updated = false;
    var cells = row.Elements<TableCell>().ToList();
    if (cells.Count < 2)
      throw new InvalidDataException("Enum value row must have at least 2 cells");
    var text1 = cells[0].GetText();
    if (text1 == "Enumeration Value")
      throw new InvalidDataException($"\"Enumeration value\" appeared in simple type {simpleType.ShortName} enum table");
    if (!SplitName(text1, out var shortName, out var longName))
      throw new InvalidDataException($"Cannot split enum value {text1} to short name and long name");
    //var text2 = cells[1].GetText();
    Write($"Checking enum value {shortName} ({longName}) ... ");
    if (!simpleType.EnumValuesDictionary.TryGetValue(shortName, out var enumValue))
    {
      enumValue = new EnumValue { OwnerTypeId = simpleType.Id, OrdNum = ordNum, Value = shortName, LongName = longName };
      dbContext.EnumValues.Add(enumValue);
      if (SaveChanges() > 0)
      {
        added = true;
        EnumValuesAdded++;
      }
    }
    else
    {
      if (enumValue.LongName != longName)
      {
        enumValue.LongName = longName;
        updated = true;
      }
    }

    if (updated)
    {
      dbContext.EnumValues.Update(enumValue);
      if (SaveChanges() > 0)
        EnumValuesUpdated++;
    }

    if (added)
      WriteLine("added");
    else if (updated)
      WriteLine("updated");
    else
      WriteLine("ok");


    return added || updated;
  }

}

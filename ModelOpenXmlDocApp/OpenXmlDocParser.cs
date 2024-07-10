using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

using DocumentFormat.OpenXml.Office2010.CustomUI;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using ModelOpenXmlDoc;

using Qhta.OpenXMLTools;

using Attribute = ModelOpenXmlDoc.Attribute;
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
  public int ElementsTotal, ElementsAdded, ElementsUpdated;
  public int AttributesTotal, AttributesAdded, AttributesUpdated;
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
      ElementsTotal = dbContext.Elements.Count();
      AttributesTotal = dbContext.Attributes.Count();
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
      WordprocessingDocument document = null!;
      while (document == null)
        try
        {
          document = WordprocessingDocument.Open(filename, false);
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Error opening file {filename}: {ex.Message}");
          Console.Write($"Abort, Retry, Ignore? ");
          ConsoleKeyInfo key;
          do
          {
            key = Console.ReadKey();
            Console.Write(new String(key.KeyChar,1));
          } while (key.Key != ConsoleKey.A && key.Key != ConsoleKey.I && key.Key != ConsoleKey.R);
          Console.WriteLine("");
          if (key.Key == ConsoleKey.A)
            return;
          if (key.Key == ConsoleKey.I)
            break;
          if (key.Key == ConsoleKey.R)
            continue;
        }
      using (document)
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

    //foreach (var chapter in docFile.Chapters.Where(item => item.Heading == "Simple Types"))
    //{
    //  if (chapter.SubChapters.Count > 0)
    //  {
    //    var subChapters = chapter.SubChapters.OrderBy(ch => ch.OrdNum);
    //    foreach (var subChapter in subChapters)
    //    {
    //      ParseSimpleTypeChapter(subChapter);
    //    }
    //  }
    //}

    //foreach (var chapter in docFile.Chapters.Where(item => item.Heading == "Elements"))
    //{
    //  if (chapter.SubChapters.Count > 0)
    //  {
    //    var subChapters = chapter.SubChapters.OrderBy(ch => ch.OrdNum);
    //    foreach (var subChapter in subChapters)
    //    {
    //      ParseElementChapter(subChapter);
    //    }
    //  }
    //}

    foreach (var chapter in docFile.Chapters.Where(item => item.HasSubChapters))
    {
      if (chapter.Heading == "Simple Types")
      {
        var subChapters = chapter.SubChapters.OrderBy(ch => ch.OrdNum);
        foreach (var subChapter in subChapters)
        {
          ParseSimpleTypeChapter(subChapter);
        }
      }
      else if (chapter.Heading == "Elements")
      {
        var subChapters = chapter.SubChapters.OrderBy(ch => ch.OrdNum);
        foreach (var subChapter in subChapters)
        {
          ParseElementChapter(subChapter);
        }
      }
      else
      {
        var subChapters = chapter.SubChapters.OrderBy(ch => ch.OrdNum);
        foreach (var subChapter in subChapters.Where(item => !item.HasSubChapters))
          if (subChapter.Heading.Contains(" ("))
          {
            if (subChapter.Heading.StartsWith(("ST_")))
              ParseSimpleTypeChapter(subChapter);
            else
              ParseElementChapter(subChapter);
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

  internal bool ParseSimpleTypeChapter(Chapter chapter)
  {
    bool added = false;
    bool updated = false;
    bool isEnum = false;

    var text = chapter.Heading;
    if (!SplitName(text, out var shortName, out var longName, out _))
      throw new InvalidDataException($"Cannot split heading {text} to short name and long name");

    Write($"Checking simple type {shortName} ({longName}) ... ");
    Table? enumTable = null;
    var paragraph = ParaTools.FindParagraph(chapter.OwnerFile.Document!, chapter.ParagraphId!);
    if (paragraph == null)
      throw new InvalidDataException($"Cannot find paragraph {chapter.ParagraphId} in file {chapter.OwnerFile.FileName}");
    var item = paragraph?.NextSibling();
    while (item != null && (item as Paragraph)?.IsHeading() != true)
    {
      if (item is Table table)
      {
        var firstCellPara = table.Elements<TableRow>().FirstOrDefault()?.Elements<TableCell>().FirstOrDefault()?.Elements<Paragraph>().FirstOrDefault();
        if (firstCellPara != null)
        {
          var firstCellText = firstCellPara.GetText().Trim();
          if (firstCellText == "Enumeration Value")
          {
            isEnum = true;
            enumTable = table;
          }
          break;
        }
      }
      item = item.NextSibling();
    }

    string? description = null;
    var nextParagraph = paragraph!.NextSibling<Paragraph>();
    if (nextParagraph != null && !nextParagraph.IsHeading())
    {
      paragraph = nextParagraph;
      description = TrimDescription(paragraph.GetText());
    }

    if (!chapter.SimpleTypesDictionary.TryGetValue(shortName, out var simpleType))
    {
      simpleType = new SimpleType { OwnerChapterId = chapter.Id, ShortName = shortName, LongName = longName, IsEnum = isEnum, DescriptionText = description };
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
      if (simpleType.DescriptionText != description)
      {
        simpleType.DescriptionText = description;
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
    if (!SplitName(text1, out var shortName, out var longName, out _))
      throw new InvalidDataException($"Cannot split enum value \"{text1}\" to short name and long name");
    var text2 = cells[1].GetText();
    if (text2.Contains('\n'))
      Debug.Assert(true);
    var description = text2;
    Write($"Checking enum value {shortName} ({longName}) ... ");
    if (!simpleType.EnumValuesDictionary.TryGetValue(shortName, out var enumValue))
    {
      enumValue = new EnumValue { OwnerTypeId = simpleType.Id, OrdNum = ordNum, Value = shortName, LongName = longName, DescriptionText = description };
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

      if (enumValue.DescriptionText != description)
      {
        enumValue.DescriptionText = description;
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

  internal bool ParseElementChapter(Chapter chapter)
  {
    bool added = false;
    bool updated = false;
    bool hasAttributes = false;

    var text = chapter.Heading;
    if (!SplitName(text, out var shortName, out var longName, out _))
      throw new InvalidDataException($"Cannot split heading {text} to short name and long name");

    Write($"Checking element {shortName} ({longName}) ... ");

    Table? attribTable = null;
    var paragraph = ParaTools.FindParagraph(chapter.OwnerFile.Document!, chapter.ParagraphId!);
    if (paragraph == null)
      throw new InvalidDataException($"Cannot find paragraph {chapter.ParagraphId} in file {chapter.OwnerFile.FileName}");
    var item = paragraph?.NextSibling();
    while (item != null && (item as Paragraph)?.IsHeading() != true)
    {
      if (item is Table table)
      {
        var firstCellPara = table.Elements<TableRow>().FirstOrDefault()?.Elements<TableCell>().FirstOrDefault()?.Elements<Paragraph>().FirstOrDefault();
        if (firstCellPara != null)
        {
          var firstCellText = firstCellPara.GetText().Trim();
          if (firstCellText == "Attributes")
          {
            hasAttributes = true;
            attribTable = table;
          }
          break;
        }
      }
      item = item.NextSibling();
    }

    string? description = null;
    var nextParagraph = paragraph!.NextSibling<Paragraph>();
    if (nextParagraph != null && !nextParagraph.IsHeading())
    {
      paragraph = nextParagraph;
      description = TrimDescription(paragraph.GetText());
    }

    if (!chapter.ElementsDictionary.TryGetValue(shortName, out var element))
    {
      element = new Element { OwnerChapterId = chapter.Id, ShortName = shortName, LongName = longName, HasAttributes = hasAttributes, DescriptionText = description };
      dbContext.Elements.Add(element);
      if (SaveChanges() > 0)
      {
        added = true;
        SimpleTypesAdded++;
      }
    }
    else
    {
      if (element.LongName != longName)
      {
        element.LongName = longName;
        updated = true;
      }
      if (element.HasAttributes != hasAttributes)
      {
        element.HasAttributes = hasAttributes;
        updated = true;
      }
      if (element.DescriptionText != description)
      {
        element.DescriptionText = description;
        updated = true;
      }
    }

    if (updated)
      dbContext.Elements.Update(element);
    if (SaveChanges() > 0)
      SimpleTypesUpdated++;

    if (added)
      WriteLine("added");
    else if (updated)
      WriteLine("updated");
    else
      WriteLine("ok");

    if (hasAttributes)
    {
      ParseAttributes(element, attribTable!);
    }
    return added || updated;
  }

  internal void ParseAttributes(Element element, Table table)
  {
    var rows = table.Elements<TableRow>().Skip(1);
    int ordNum = 0;
    foreach (var row in rows)
    {
      ParseAttribute(element, row, ordNum++);
    }
  }

  internal bool ParseAttribute(Element element, TableRow row, int ordNum)
  {
    bool added = false;
    bool updated = false;
    var cells = row.Elements<TableCell>().ToList();
    if (cells.Count < 2)
      throw new InvalidDataException("Attribute row must have at least 2 cells");
    var text1 = cells[0].GetText();
    if (text1 == "Attributes")
      throw new InvalidDataException($"\"Attributes\" appeared in element {element.ShortName} enum table");
    //TryRemoveNamespace(ref text1);
    if (!SplitName(text1, out var shortName, out var longName, out var nsName))
      throw new InvalidDataException($"Cannot split attribute \"{text1}\" to short name and long name");
    var text2 = cells[1].GetText();

    var description = RemoveNote(RemoveExample(text2));
    Write($"Checking attribute {shortName} ({longName}) ... ");
    if (!element.AttributesDictionary.TryGetValue(shortName, out var attribute))
    {
      attribute = new Attribute { OwnerTypeId = element.Id, OrdNum = ordNum, ShortName = shortName, LongName = longName, DescriptionText = description, Namespace = nsName };
      dbContext.Attributes.Add(attribute);
      if (SaveChanges() > 0)
      {
        added = true;
        AttributesAdded++;
      }
    }
    else
    {
      if (attribute.LongName != longName)
      {
        attribute.LongName = longName;
        updated = true;
      }

      if (attribute.Namespace != nsName)
      {
        attribute.Namespace = nsName;
        updated = true;
      }

      if (attribute.DescriptionText != description)
      {
        attribute.DescriptionText = description;
        updated = true;
      }
    }

    if (updated)
    {
      dbContext.Attributes.Update(attribute);
      if (SaveChanges() > 0)
        AttributesUpdated++;
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

  internal bool SplitName(string heading, [NotNullWhen(true)] out string? shortName, [NotNullWhen(true)] out string? longName, out string? nsName)
  {
    heading = heading.Trim();
    heading = heading.Replace("\r\n", " ");
    var k = heading.IndexOf('(');
    var l = heading.LastIndexOf(')');
    if (k > 0 && l > k)
    {
      shortName = heading.Substring(0, k).Trim();
      longName = heading.Substring(k + 1, l - k - 1).Trim();
      k = heading.IndexOf("Namespace:");
      if (k > 0)
      {
        nsName = heading.Substring(k + 10).Trim();
        TryRemoveSpaces(ref nsName);
      }
      else
      {
        nsName = null;
      }
      return true;
    }
    shortName = null;
    longName = null;
    nsName = null;
    return false;
  }

  internal string RemoveExample(string text)
  {
    var k = text.IndexOf("[Example:");
    while (k >= 0)
    {
      var m = text.IndexOf("end example]", k);
      if (m > 0)
      {
        text = text.Substring(0, k).Trim() + text.Substring(m + 12).Trim();
        k = text.IndexOf("[Example:");
      }
      else
      {
        text = text.Substring(0, k).Trim();
        break;
      }
    }
    return text;
  }

  internal string RemoveNote(string text)
  {
    var k = text.IndexOf("[Note:");
    while (k >= 0)
    {
      var m = text.IndexOf("end note]", k);
      if (m > 0)
      {
        text = text.Substring(0, k).Trim() + text.Substring(m + 9).Trim();
        k = text.IndexOf("[Note:");
      }
      else
      {
        text = text.Substring(0, k).Trim();
        break;
      }
    }
    return text;
  }

  internal string TrimDescription(string text)
  {
    text = text.Trim();
    text = RemoveExample(text);
    text = RemoveNote(text);
    if (text.EndsWith(":"))
      TryRemoveLastSentence(ref text);
    while (text.EndsWith(" .") || text.EndsWith(" ,"))
      if (!TryRemoveLastClause(ref text))
        break;
    text = text.Replace(", as in .", ".");
    if (text.EndsWith(":"))
      TryRemoveLastSentence(ref text);
    return text;
  }

  internal bool TryRemoveLastSentence(ref string text)
  {
    var k = text.LastIndexOf('.');
    if (k > 0)
    {
      text = text.Substring(0, k) + '.';
      return true;
    }
    return false;
  }

  internal bool TryRemoveLastClause(ref string text)
  {
    var k = text.LastIndexOf(',');
    if (k > 0)
    {
      text = text.Substring(0, k) + '.';
      return true;
    }
    return false;
  }

  internal bool TryRemoveNamespace(ref string text)
  {
    var k = text.LastIndexOf("Namespace:");
    if (k > 0)
    {
      text = text.Substring(0, k);
      return true;
    }
    return false;
  }

  internal bool TryRemoveSpaces(ref string text)
  {
    var chars = text.ToList();
    var removed = false;
    for (int i = chars.Count - 1; i >= 0; i--)
    {
      if (Char.GetUnicodeCategory(chars[i]) == System.Globalization.UnicodeCategory.SpaceSeparator)
      {
        chars.RemoveAt(i);
        removed = true;
      }
    }
    if (removed)
    {
      text = new string(chars.ToArray());
      return true;
    }
    return false;
  }
}

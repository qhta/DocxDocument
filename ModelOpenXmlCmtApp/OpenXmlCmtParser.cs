using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using System.Xml.Linq;

using ModelOpenXmlCmt;


namespace ModelOpenXmlCmtApp;

/// <summary>
/// Parser that reads XML files and stores its elements in a database.
/// </summary>
public class OpenXmlCmtParser
{
  public string SourceDocPath { get; set; } = null!;
  public int FilesTotal, FilesAdded;
  public int TypesTotal, TypesAdded, TypesUpdated;
  public int FieldsTotal, FieldsAdded, FieldsUpdated;
  public int PropsTotal, PropsAdded, PropsUpdated;


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
      TypesTotal = dbContext.Members.Count(m => m.Type == MemberType.Type);
      FieldsTotal = dbContext.Members.Count(m => m.Type == MemberType.Field);
      PropsTotal = dbContext.Members.Count(m => m.Type == MemberType.Property);

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
    List<XmlFile> files = new();
    var docsPaths = Directory.GetFiles(SourceDocPath, "*.xml");
    foreach (var path in docsPaths)
    {
      var filename = Path.GetFileName(Path.GetFileNameWithoutExtension(Path.GetFileName(path)));
      if (filename.StartsWith('~')) continue;

      if (!dbContext.FilesDictionary.TryGetValue(filename, out var docFile))
      {
        WriteLine($"Adding file {filename}");
        docFile = new XmlFile() { FileName = filename };
        dbContext.Files.Add(docFile);
        if (SaveChanges() > 0)
        {
          //dbContext.FilesIndex.TryAdd(docFile.Id, docFile);
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

  internal void ParseDoc(XmlFile docFile)
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

  internal bool ParseMember(XmlFile docFile, XElement xElement)
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
    string? paramsStr = null;
    string parentName = "";
    var k = name.IndexOf('(');
    if (k > 0)
    {
      paramsStr = name.Substring(k + 1, name.Length - k - 1);
      name = name.Substring(0, k);
    }

    k = name.LastIndexOf('.');
    if (k > 0)
    {
      parentName = name.Substring(0, k);
      name = name.Substring(k + 1);
    }
    Write($"Checking member {fullName} ... ");
    int? parentMemberId = null;
    var parentFullName = "T:" + parentName;
    var parentShortName = parentName;
    k = parentName.LastIndexOf('.');
    if (k>0)
    {
      parentShortName = parentName.Substring(0, k);
    }

    if (docFile.MembersDictionary.TryGetValue(parentFullName, out var typeMember))
    {
      parentMemberId = typeMember.Id;
    }
    else
    {
      if (memberType != MemberType.Type)
      {
        typeMember = new Member { OwnerFileId = docFile.Id, FullName = parentFullName, ShortName = parentShortName, Params = null, Type = MemberType.Type, ParentMemberId = parentMemberId };

        dbContext.Members.Add(typeMember);
        if (SaveChanges() > 0)
        {
          parentMemberId = typeMember.Id;
          TypesAdded++;
        }
      }
    }

    var descriptionText = GetDescriptionText(xElement);

    if (!docFile.MembersDictionary.TryGetValue(fullName, out var member))
    {
      member = new Member { OwnerFileId = docFile.Id, FullName = fullName, ShortName = name, Params = paramsStr, Type = memberType, ParentMemberId = parentMemberId, DescriptionText = descriptionText };

      dbContext.Members.Add(member);
      if (SaveChanges() > 0)
      {
        added = true;
      }
    }
    else
    {
      if (member.Params != paramsStr)
      {
        member.Params = paramsStr;
        updated = true;
      }
      if (member.ParentMemberId != parentMemberId)
      {
        member.ParentMemberId = parentMemberId;
        updated = true;
      }
      if (member.DescriptionText != descriptionText)
      {
        member.DescriptionText = descriptionText;
        updated = true;
      }
    }

    if (added)
    {
      switch (member.Type)
      {
        case MemberType.Type:
          TypesAdded++;
          break;
        case MemberType.Field:
          FieldsAdded++;
          break;
        case MemberType.Property:
          PropsAdded++;
          break;
      }
    }

    if (updated)
    {
      dbContext.Members.Update(member);
      if (SaveChanges() > 0)
        switch (member.Type)
        {
          case MemberType.Type:
            TypesUpdated++;
            break;
          case MemberType.Field:
            FieldsUpdated++;
            break;
          case MemberType.Property:
            PropsUpdated++;
            break;
        }
    }

    if (added)
      WriteLine("added");
    else if (updated)
      WriteLine("updated");
    else
      WriteLine("ok");

    return true;
  }

  internal string GetDescriptionText(XElement xElement)
  {
    var stringWriter = new StringWriter();
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { OmitXmlDeclaration = true, ConformanceLevel = ConformanceLevel.Fragment }))
      xElement.WriteTo(xmlWriter);
    var result = stringWriter.ToString();
    var k = result.IndexOf('>');
    var l = result.LastIndexOf('<');
    return result.Substring(k + 1, l - k - 1).Trim();
  }

}

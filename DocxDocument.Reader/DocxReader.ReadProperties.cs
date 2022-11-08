using XP = DocumentFormat.OpenXml.ExtendedProperties;
using Qhta.OpenXMLTools;

using DM = DocxDocument.Model;
using W = DocumentFormat.OpenXml.Wordprocessing;
using VT = DocumentFormat.OpenXml.VariantTypes;

namespace DocxDocument.Reader;

public partial class DocxReader
{
  public DM.DocumentProperties ReadDocumentProperties()
  {
    return ReadDocumentProperties(Parts.AllDocumentProperties);
  }

  public DM.DocumentProperties ReadDocumentProperties(Parts parts)
  {
    var dmProperties = new DM.DocumentProperties();
    if (parts.HasFlag(Parts.CoreFileProperties))
      ReadPackageProperties(dmProperties);
    if (parts.HasFlag(Parts.ExtendedFileProperties))
      ReadExtendedProperties(dmProperties);
    if (parts.HasFlag(Parts.CustomFileProperties))
      ReadCustomProperties(dmProperties);
    if ((parts | Parts.AllDocumentProperties) == Parts.AllDocumentProperties)
      ReadDocumentSettings(dmProperties);
    return dmProperties;
  }

  private void ReadPackageProperties(DM.DocumentProperties dmDocumentProperties)
  {
    var coreFileProperties = WordprocessingDocument.PackageProperties;
    dmDocumentProperties.Identifier = coreFileProperties.Identifier;
    dmDocumentProperties.Title = coreFileProperties.Title;
    dmDocumentProperties.Version = coreFileProperties.Version;
    dmDocumentProperties.Revision = coreFileProperties.Revision;
    dmDocumentProperties.Category = coreFileProperties.Category;
    dmDocumentProperties.Subject = coreFileProperties.Subject;
    dmDocumentProperties.Description = coreFileProperties.Description;
    dmDocumentProperties.Keywords = coreFileProperties.Keywords;
    dmDocumentProperties.Language = coreFileProperties.Language;
    dmDocumentProperties.ContentStatus = coreFileProperties.ContentStatus;
    dmDocumentProperties.ContentType = coreFileProperties.ContentType;

    dmDocumentProperties.Created = coreFileProperties.Created;
    dmDocumentProperties.Creator = coreFileProperties.Creator;
    dmDocumentProperties.LastModified = coreFileProperties.Modified;
    dmDocumentProperties.LastModifiedBy = coreFileProperties.LastModifiedBy;
    dmDocumentProperties.LastPrinted = coreFileProperties.LastPrinted;
  }

  private void ReadExtendedProperties(DM.DocumentProperties dmDocumentProperties)
  {
    var extFileProperties = WordprocessingDocument.ExtendedFilePropertiesPart?.Properties;
    if (extFileProperties != null)
    {
      dmDocumentProperties.Application = ReadString(extFileProperties.Application);
      dmDocumentProperties.ApplicationVersion = ReadString(extFileProperties.ApplicationVersion);
      dmDocumentProperties.Template = ReadString(extFileProperties.Template);
      dmDocumentProperties.Company = ReadString(extFileProperties.Company);
      dmDocumentProperties.Manager = ReadString(extFileProperties.Manager);
      //dmDocumentProperties.DigitalSignature = ReadBlob(extFileProperties.DigitalSignature?.VTBlob);
      dmDocumentProperties.DocumentSecurity = (DM.DocSecurity?)ReadInteger(extFileProperties.DocumentSecurity);
      dmDocumentProperties.SharedDocument = ReadBoolean(extFileProperties.SharedDocument);
      dmDocumentProperties.ScaleCrop = ReadBoolean(extFileProperties.ScaleCrop);
      dmDocumentProperties.LinksUpToDate = ReadBoolean(extFileProperties.LinksUpToDate);
      dmDocumentProperties.HyperlinksChanged = ReadBoolean(extFileProperties.HyperlinksChanged);
      dmDocumentProperties.HyperlinkBase = ReadString(extFileProperties.HyperlinkBase);
      dmDocumentProperties.TotalTime = ReadInteger(extFileProperties.TotalTime);
      dmDocumentProperties.Pages = ReadInteger(extFileProperties.Pages);
      dmDocumentProperties.Words = ReadInteger(extFileProperties.Words);
      dmDocumentProperties.Characters = ReadInteger(extFileProperties.Characters);
      dmDocumentProperties.CharactersWithSpaces = ReadInteger(extFileProperties.CharactersWithSpaces);
      dmDocumentProperties.Lines = ReadInteger(extFileProperties.Lines);
      dmDocumentProperties.Paragraphs = ReadInteger(extFileProperties.Paragraphs);

      dmDocumentProperties.HeadingPairs = ReadHeadingParts(extFileProperties.HeadingPairs);
      dmDocumentProperties.TitlesOfParts = ReadTitlesOfPairs(extFileProperties.TitlesOfParts);
      dmDocumentProperties.HyperlinkList = ReadHyperlinks(extFileProperties.HyperlinkList);
    }

  }

  public static DM.HeadingPairs? ReadHeadingParts(XP.HeadingPairs? docHeadingPairs)
  {
    var dmVariants = ReadVariants(docHeadingPairs?.VTVector);
    if (dmVariants != null)
    {
      if (dmVariants.Count() % 2 != 0)
        throw new InvalidDataException($"Non-conformed HeadingPairs element in ContentFileProperties");
      var dmHeadingPairs = new DM.HeadingPairs();
      for (int i = 0; i < dmVariants.Count; i += 2)
      {
        if (dmVariants[i] is string && dmVariants[i + 1] is int)
        {
          var name = (string)dmVariants[i];
          var count = (int)dmVariants[i + 1];
          dmHeadingPairs.Add(new DM.HeadingPair { Name = name, Count = count });
        }
        else
          throw new InvalidDataException($"Non-conformed HeadingPairs element in ContentFileProperties");
      }
      return dmHeadingPairs;
    }
    return null;
  }

  public static DM.Strings? ReadTitlesOfPairs(XP.TitlesOfParts? docTitlesOfParts)
  {
    var dmVariants = ReadVariants(docTitlesOfParts?.VTVector);
    if (dmVariants != null)
    {
      var dmTitlesOfParts = new DM.Strings();
      foreach (var item in dmVariants)
        if (item is string str)
          dmTitlesOfParts.Add(str);
        else
          throw new InvalidDataException($"Non-conformed TitlesOfParts element in ContentFileProperties");
      return dmTitlesOfParts;
    }
    return null;
  }

  public static DM.HyperlinkList? ReadHyperlinks(XP.HyperlinkList? docHyperlinkList)
    {
      var dmVariants = ReadVariants(docHyperlinkList?.VTVector);
    if (dmVariants != null)
    {
      if (dmVariants.Count() % 6 != 0)
        throw new InvalidDataException($"Non-conformed HyperlinkList element in ContentFileProperties");
      int hCount = dmVariants.Count() / 6;
      var dmHyperlinkList = new DM.HyperlinkList();
      for (int i = 0; i < hCount; i++)
      {
        var item = new DM.HyperlinkData();

        if (dmVariants[i * 6] is int n1)
          item.Data1 = n1;
        else
          throw new InvalidDataException($"Non-conformed HyperlinkList element in ContentFileProperties");

        if (dmVariants[i * 6 + 1] is int n2)
          item.Data2 = n2;
        else
          throw new InvalidDataException($"Non-conformed HyperlinkList element in ContentFileProperties");

        if (dmVariants[i * 6 + 2] is int n3)
          item.Data3 = n3;
        else
          throw new InvalidDataException($"Non-conformed HyperlinkList element in ContentFileProperties");

        if (dmVariants[i * 6 + 3] is int n4)
          item.Data4 = n4;
        else
          throw new InvalidDataException($"Non-conformed HyperlinkList element in ContentFileProperties");

        if (dmVariants[i * 6 + 4] is string s1)
          item.Target = s1;
        else
          throw new InvalidDataException($"Non-conformed HyperlinkList element in ContentFileProperties");

        if (dmVariants[i * 6 + 5] is string s2)
          item.Location = s2;
        else
          throw new InvalidDataException($"Non-conformed HyperlinkList element in ContentFileProperties");
      }
      return dmHyperlinkList;
    }
    return null;
  }

  private void ReadCustomProperties(DM.DocumentProperties dmDocumentProperties)
  {
    var customFileProperties = WordprocessingDocument.CustomFilePropertiesPart?.Properties;
    if (customFileProperties != null)
    {
      foreach (var cpProperty in customFileProperties
                 .Elements<DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty>())
      {
        var dmProperty = new DM.CustomDocumentProperty
        {
          PropertyId = cpProperty.PropertyId?.Value ?? 0,
          LinkTarget = cpProperty.LinkTarget?.Value,
          Name = cpProperty.Name?.Value ?? "",
          Value = ReadVariant(cpProperty.Elements().FirstOrDefault())
        };
        if (cpProperty.FormatId?.Value != null)
          dmProperty.FormatId = Guid.Parse(cpProperty.FormatId.Value);
        dmDocumentProperties.Add(dmProperty);
      }
    }
  }

  private void ReadDocumentSettings(DM.DocumentProperties dmDocumentProperties)
  {
    var docSettings = WordprocessingDocument.MainDocumentPart?.DocumentSettingsPart?.Settings;
    if (docSettings != null)
    {
      dmDocumentProperties.DocumentId = ReadHexInt(docSettings.GetDocumentId()?.Val);
      dmDocumentProperties.PersistentDocumentId = ReadGuid(docSettings.GetPersistentDocumentId()?.Val);
      dmDocumentProperties.ConflictMode = ReadBoolean(docSettings.GetConflictMode());
      dmDocumentProperties.RsIds = ReadRsIds(docSettings);
    }
  }

}
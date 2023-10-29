using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.Wordprocessing;
public partial class BuiltInProperties
{
  public BuiltInProperties (DM.Document document)
  {
    WordprocessingDocument = document.WordprocessingDocument;
    Load();
    Debug.Assert(_CoreProperties != null);
  }

  internal DXP.WordprocessingDocument WordprocessingDocument { get; private set; }

  public void Load()
  {
    LoadCoreProperties();
    LoadExtendedProperties();
  }

  #region CoreProperties

  internal void LoadCoreProperties()
  {
    var properties = WordprocessingDocument.PackageProperties;
    if (properties == null)
    {
      var packagePropertiesPart = WordprocessingDocument.AddCoreFilePropertiesPart();
      properties = WordprocessingDocument.PackageProperties;
    }
    _CoreProperties = properties;
  }

  internal PackageProperties _CoreProperties { get; private set; }

  public string? Title
  {
    get => _CoreProperties.Title;
    set => _CoreProperties.Title = value;
  }

  public string? CreatedBy
  {
    get => _CoreProperties.Creator;
    set => _CoreProperties.Creator = value;
  }

  public DateTime? CreatedAt
  {
    get => _CoreProperties.Created;
    set => _CoreProperties.Created = value;
  }

  public string? LastModifiedBy
  {
    get => _CoreProperties.LastModifiedBy;
    set => _CoreProperties.LastModifiedBy = value;
  }

  public DateTime? LastModifiedAt
  {
    get => _CoreProperties.Modified;
    set => _CoreProperties.Modified = value;
  }

  public DateTime? LastPrintedAt
  {
    get => _CoreProperties.LastPrinted;
    set => _CoreProperties.LastPrinted = value;
  }

  public string? Subject
  {
    get => _CoreProperties.Subject;
    set => _CoreProperties.Subject = value;
  }

  public string? Revision
  {
    get => _CoreProperties.Revision;
    set => _CoreProperties.Revision = value;
  }

  public string? Language
  {
    get => _CoreProperties.Language;
    set => _CoreProperties.Language = value;
  }

  public string? Keywords
  {
    get => _CoreProperties.Keywords;
    set => _CoreProperties.Keywords = value;
  }

  public string? CoreIdentifier
  {
    get => _CoreProperties.Identifier;
    set => _CoreProperties.Identifier = value;
  }

  public string? ContentType
  {
    get => _CoreProperties.ContentType;
    set => _CoreProperties.ContentType = value;
  }

  public string? ContentStatus
  {
    get => _CoreProperties.ContentStatus;
    set => _CoreProperties.ContentStatus = value;
  }

  public string? Category
  {
    get => _CoreProperties.Category;
    set => _CoreProperties.Category = value;
  }

  public string? Description
  {
    get => _CoreProperties.Description;
    set => _CoreProperties.Description = value;
  }

  public string? Version
  {
    get => _CoreProperties.Version;
    set => _CoreProperties.Version = value;
  }
  #endregion

  #region ExtendedProperties

  internal void LoadExtendedProperties()
  {
    var extendedFilePropertiesPart = WordprocessingDocument.ExtendedFilePropertiesPart;
    if (extendedFilePropertiesPart == null) 
      extendedFilePropertiesPart = WordprocessingDocument.AddExtendedFilePropertiesPart();

    var properties = extendedFilePropertiesPart.Properties;
    if (properties == null)
    {
      properties = new DXEP.Properties();
      extendedFilePropertiesPart.Properties = properties;
    }
    _ExtendedProperties = properties;
  }

  public bool HasExtendedProperties => WordprocessingDocument.ExtendedFilePropertiesPart?.Properties!=null;

  internal DXEP.Properties? _ExtendedProperties { get; private set; }
  
  private DXEP.Properties ExistedProperties
  {
    get
    {
      var propertiesPart = WordprocessingDocument.ExtendedFilePropertiesPart;
      if (propertiesPart == null)
      {
        propertiesPart = WordprocessingDocument.AddExtendedFilePropertiesPart();
      }
      var properties = propertiesPart.Properties;
      if (properties == null)
      {
        properties = new DXEP.Properties();
        propertiesPart.Properties = properties;
      }
      return properties;
    }
  }

  [Obsolete]
  public string? DigitalSignature
  {
    get => _ExtendedProperties?.DigitalSignature?.OuterXml;
    set
    {
      if (value != null)
        ExistedProperties.DigitalSignature = new DXEP.DigitalSignature(value);
      else
        ExistedProperties.DigitalSignature = null;
    }
  }

  public Array? TitlesOfParts
  {
    get => _ExtendedProperties?.TitlesOfParts?.VTVector.AsArray();
    set
    {
      if (value != null)
        ExistedProperties.TitlesOfParts = new DXEP.TitlesOfParts(value.AsChildArray()!);
      else
        ExistedProperties.TitlesOfParts = null;
    }
  }

  public Array? HeadingPairs
  {
    get => _ExtendedProperties?.HeadingPairs?.VTVector.AsArray();
    set
    {
      if (value != null)
        ExistedProperties.HeadingPairs = new DXEP.HeadingPairs(value.AsChildArray()!);
      else
        ExistedProperties.HeadingPairs = null;
    }
  }

  public Array? HyperlinkList
  {
    get => _ExtendedProperties?.HyperlinkList?.VTVector.AsArray();
    set
    {
      if (value != null)
        ExistedProperties.HyperlinkList = new DXEP.HyperlinkList(value.AsChildArray()!);
      else
        ExistedProperties.HyperlinkList = null;
    }
  }


  public int? DocumentSecurity
  {
    get => _ExtendedProperties?.DocumentSecurity?.AsInt();
    set
    {
      if (value != null)
        ExistedProperties.DocumentSecurity = new DXEP.DocumentSecurity(value.ToString()!);
      else
        ExistedProperties.DocumentSecurity = null;
    }
  }

  public Boolean? ScaleCrop
  {
    get => _ExtendedProperties?.ScaleCrop?.AsBoolean();
    set
    {
      if (value != null)
        ExistedProperties.ScaleCrop = new DXEP.ScaleCrop(value.ToString()!);
      else
        ExistedProperties.ScaleCrop = null;
    }
  }

  public Boolean? LinksUpToDate
  {
    get => _ExtendedProperties?.LinksUpToDate?.AsBoolean();
    set
    {
      if (value != null)
        ExistedProperties.LinksUpToDate = new DXEP.LinksUpToDate(value.ToString()!);
      else
        ExistedProperties.LinksUpToDate = null;
    }
  }

  public Boolean? SharedDocument
  {
    get => _ExtendedProperties?.SharedDocument?.AsBoolean();
    set
    {
      if (value != null)
        ExistedProperties.SharedDocument = new DXEP.SharedDocument(value.ToString()!);
      else
        ExistedProperties.SharedDocument = null;
    }
  }

  public Boolean? HyperlinksChanged
  {
    get => _ExtendedProperties?.HyperlinksChanged?.AsBoolean();
    set
    {
      if (value != null)
        ExistedProperties.HyperlinksChanged = new DXEP.HyperlinksChanged(value.ToString()!);
      else
        ExistedProperties.HyperlinksChanged = null;
    }
  }

  public string? HyperlinkBase
  {
    get => _ExtendedProperties?.HyperlinkBase?.InnerText;
    set
    {
      if (value != null)
        ExistedProperties.HyperlinkBase = new DXEP.HyperlinkBase(value);
      else
        ExistedProperties.HyperlinkBase = null;
    }
  }

  public string? Template
  {
    get => _ExtendedProperties?.Template?.InnerText;
    set
    {
      if (value != null)
        ExistedProperties.Template = new DXEP.Template(value);
      else
        ExistedProperties.Template = null;
    }
  }


  public string? Manager
  {
    get => _ExtendedProperties?.Manager?.InnerText;
    set
    {
      if (value != null)
        ExistedProperties.Manager = new DXEP.Manager(value);
      else
        ExistedProperties.Manager = null;
    }
  }

  public string? Company
  {
    get => _ExtendedProperties?.Company?.InnerText;
    set
    {
      if (value != null)
        ExistedProperties.Company = new DXEP.Company(value);
      else
        ExistedProperties.Company = null;
    }
  }

  public string? PresentationFormat
  {
    get => _ExtendedProperties?.PresentationFormat?.InnerText;
    set
    {
      if (value != null)
        ExistedProperties.PresentationFormat = new DXEP.PresentationFormat(value);
      else
        ExistedProperties.PresentationFormat = null;
    }
  }

  public string? Application
  {
    get => _ExtendedProperties?.Application?.InnerText;
    set
    {
      if (value != null)
        ExistedProperties.Application = new DXEP.Application(value);
      else
        ExistedProperties.Application = null;
    }
  }

  public string? ApplicationVersion
  {
    get => _ExtendedProperties?.ApplicationVersion?.InnerText;
    set
    {
      if (value != null)
        ExistedProperties.ApplicationVersion = new DXEP.ApplicationVersion(value);
      else
        ExistedProperties.ApplicationVersion = null;
    }
  }

  public int? Pages
  {
    get => _ExtendedProperties?.Pages?.AsInt();
    set
    {
      if (value != null)
        ExistedProperties.Pages = new DXEP.Pages(value.ToString()!);
      else
        ExistedProperties.Pages = null;
    }
  }

  public int? Words
  {
    get => _ExtendedProperties?.Words?.AsInt();
    set
    {
      if (value != null)
        ExistedProperties.Words = new DXEP.Words(value.ToString()!);
      else
        ExistedProperties.Words = null;
    }
  }

  public int? Characters
  {
    get => _ExtendedProperties?.Characters?.AsInt();
    set
    {
      if (value != null)
        ExistedProperties.Characters = new DXEP.Characters(value.ToString()!);
      else
        ExistedProperties.Characters = null;
    }
  }

  public int? CharactersWithSpaces
  {
    get => _ExtendedProperties?.CharactersWithSpaces?.AsInt();
    set
    {
      if (value != null)
        ExistedProperties.CharactersWithSpaces = new DXEP.CharactersWithSpaces(value.ToString()!);
      else
        ExistedProperties.CharactersWithSpaces = null;
    }
  }


  public int? Lines
  {
    get => _ExtendedProperties?.Lines?.AsInt();
    set
    {
      if (value != null)
        ExistedProperties.Lines = new DXEP.Lines(value.ToString()!);
      else
        ExistedProperties.Lines = null;
    }
  }

  public int? Paragraphs
  {
    get => _ExtendedProperties?.Paragraphs?.AsInt();
    set
    {
      if (value != null)
        ExistedProperties.Paragraphs = new DXEP.Paragraphs(value.ToString()!);
      else
        ExistedProperties.Paragraphs = null;
    }
  }

  public int? TotalTime
  {
    get => _ExtendedProperties?.TotalTime?.AsInt();
    set
    {
      if (value != null)
        ExistedProperties.TotalTime = new DXEP.TotalTime(value.ToString()!);
      else
        ExistedProperties.TotalTime = null;
    }
  }
  #endregion

}

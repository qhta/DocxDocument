using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel;
public partial class BuiltInProperties
{
  public BuiltInProperties(DMW.Document document)
  {
    WordprocessingDocument = document.WordprocessingDocument;
    Load();
    Debug.Assert(_CoreProperties != null);
  }

  internal DXP.WordprocessingDocument WordprocessingDocument { get; private set; }

  public void Load()
  {
    LoadCoreProperties();
    _ExtendedProperties = WordprocessingDocument.ExtendedFilePropertiesPart?.Properties;
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

  [DataMember]
  public string? Title
  {
    get => _CoreProperties.Title;
    set => _CoreProperties.Title = value;
  }

  [DataMember]
  public string? CreatedBy
  {
    get => _CoreProperties.Creator;
    set => _CoreProperties.Creator = value;
  }

  [DataMember]
  public DateTime? CreatedAt
  {
    get => _CoreProperties.Created;
    set => _CoreProperties.Created = value;
  }

  [DataMember]
  public string? LastModifiedBy
  {
    get => _CoreProperties.LastModifiedBy;
    set => _CoreProperties.LastModifiedBy = value;
  }

  [DataMember]
  public DateTime? LastModifiedAt
  {
    get => _CoreProperties.Modified;
    set => _CoreProperties.Modified = value;
  }

  [DataMember]
  public DateTime? LastPrintedAt
  {
    get => _CoreProperties.LastPrinted;
    set => _CoreProperties.LastPrinted = value;
  }

  [DataMember]
  public string? Subject
  {
    get => _CoreProperties.Subject;
    set => _CoreProperties.Subject = value;
  }

  [DataMember]
  public string? Revision
  {
    get => _CoreProperties.Revision;
    set => _CoreProperties.Revision = value;
  }

  [DataMember]
  public string? Language
  {
    get => _CoreProperties.Language;
    set => _CoreProperties.Language = value;
  }

  [DataMember]
  public string? Keywords
  {
    get => _CoreProperties.Keywords;
    set => _CoreProperties.Keywords = value;
  }

  [DataMember]
  public string? CoreIdentifier
  {
    get => _CoreProperties.Identifier;
    set => _CoreProperties.Identifier = value;
  }

  [DataMember]
  public string? ContentType
  {
    get => _CoreProperties.ContentType;
    set => _CoreProperties.ContentType = value;
  }

  [DataMember]
  public string? ContentStatus
  {
    get => _CoreProperties.ContentStatus;
    set => _CoreProperties.ContentStatus = value;
  }

  [DataMember]
  public string? Category
  {
    get => _CoreProperties.Category;
    set => _CoreProperties.Category = value;
  }

  [DataMember]
  public string? Description
  {
    get => _CoreProperties.Description;
    set => _CoreProperties.Description = value;
  }

  [DataMember]
  public string? Version
  {
    get => _CoreProperties.Version;
    set => _CoreProperties.Version = value;
  }
  #endregion

  #region ExtendedProperties

  public bool HasExtendedProperties => WordprocessingDocument.ExtendedFilePropertiesPart?.Properties != null;

  internal DXEP.Properties? _ExtendedProperties { get; private set; }

  private DXEP.Properties ExistingProperties
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
        ExistingProperties.DigitalSignature = new DXEP.DigitalSignature(value);
      else
        ExistingProperties.DigitalSignature = null;
    }
  }

  [DataMember]
  public Array? TitlesOfParts
  {
    get => _ExtendedProperties?.TitlesOfParts?.VTVector.AsArray();
    set
    {
      if (value != null)
        ExistingProperties.TitlesOfParts = new DXEP.TitlesOfParts(value.AsChildArray()!);
      else
        ExistingProperties.TitlesOfParts = null;
    }
  }

  [DataMember]
  public Array? HeadingPairs
  {
    get => _ExtendedProperties?.HeadingPairs?.VTVector.AsArray();
    set
    {
      if (value != null)
        ExistingProperties.HeadingPairs = new DXEP.HeadingPairs(value.AsChildArray()!);
      else
        ExistingProperties.HeadingPairs = null;
    }
  }

  [DataMember]
  public Array? HyperlinkList
  {
    get => _ExtendedProperties?.HyperlinkList?.VTVector.AsArray();
    set
    {
      if (value != null)
        ExistingProperties.HyperlinkList = new DXEP.HyperlinkList(value.AsChildArray()!);
      else
        ExistingProperties.HyperlinkList = null;
    }
  }


  [DataMember]
  public int? DocumentSecurity
  {
    get => _ExtendedProperties?.DocumentSecurity?.AsInt();
    set
    {
      if (value != null)
        ExistingProperties.DocumentSecurity = new DXEP.DocumentSecurity(value.ToString()!);
      else
        ExistingProperties.DocumentSecurity = null;
    }
  }

  [DataMember]
  public Boolean? ScaleCrop
  {
    get => _ExtendedProperties?.ScaleCrop?.AsBoolean();
    set
    {
      if (value != null)
        ExistingProperties.ScaleCrop = new DXEP.ScaleCrop(value.ToString()!);
      else
        ExistingProperties.ScaleCrop = null;
    }
  }

  [DataMember]
  public Boolean? LinksUpToDate
  {
    get => _ExtendedProperties?.LinksUpToDate?.AsBoolean();
    set
    {
      if (value != null)
        ExistingProperties.LinksUpToDate = new DXEP.LinksUpToDate(value.ToString()!);
      else
        ExistingProperties.LinksUpToDate = null;
    }
  }

  [DataMember]
  public Boolean? SharedDocument
  {
    get => _ExtendedProperties?.SharedDocument?.AsBoolean();
    set
    {
      if (value != null)
        ExistingProperties.SharedDocument = new DXEP.SharedDocument(value.ToString()!);
      else
        ExistingProperties.SharedDocument = null;
    }
  }

  [DataMember]
  public Boolean? HyperlinksChanged
  {
    get => _ExtendedProperties?.HyperlinksChanged?.AsBoolean();
    set
    {
      if (value != null)
        ExistingProperties.HyperlinksChanged = new DXEP.HyperlinksChanged(value.ToString()!);
      else
        ExistingProperties.HyperlinksChanged = null;
    }
  }

  [DataMember]
  public string? HyperlinkBase
  {
    get => _ExtendedProperties?.HyperlinkBase?.InnerText;
    set
    {
      if (value != null)
        ExistingProperties.HyperlinkBase = new DXEP.HyperlinkBase(value);
      else
        ExistingProperties.HyperlinkBase = null;
    }
  }

  [DataMember]
  public string? Template
  {
    get => _ExtendedProperties?.Template?.InnerText;
    set
    {
      if (value != null)
        ExistingProperties.Template = new DXEP.Template(value);
      else
        ExistingProperties.Template = null;
    }
  }


  [DataMember]
  public string? Manager
  {
    get => _ExtendedProperties?.Manager?.InnerText;
    set
    {
      if (value != null)
        ExistingProperties.Manager = new DXEP.Manager(value);
      else
        ExistingProperties.Manager = null;
    }
  }

  [DataMember]
  public string? Company
  {
    get => _ExtendedProperties?.Company?.InnerText;
    set
    {
      if (value != null)
        ExistingProperties.Company = new DXEP.Company(value);
      else
        ExistingProperties.Company = null;
    }
  }

  [DataMember]
  public string? PresentationFormat
  {
    get => _ExtendedProperties?.PresentationFormat?.InnerText;
    set
    {
      if (value != null)
        ExistingProperties.PresentationFormat = new DXEP.PresentationFormat(value);
      else
        ExistingProperties.PresentationFormat = null;
    }
  }

  [DataMember]
  public string? Application
  {
    get => _ExtendedProperties?.Application?.InnerText;
    set
    {
      if (value != null)
        ExistingProperties.Application = new DXEP.Application(value);
      else
        ExistingProperties.Application = null;
    }
  }

  [DataMember]
  public string? ApplicationVersion
  {
    get => _ExtendedProperties?.ApplicationVersion?.InnerText;
    set
    {
      if (value != null)
        ExistingProperties.ApplicationVersion = new DXEP.ApplicationVersion(value);
      else
        ExistingProperties.ApplicationVersion = null;
    }
  }

  [DataMember]
  public int? Pages
  {
    get => _ExtendedProperties?.Pages?.AsInt();
    set
    {
      if (value != null)
        ExistingProperties.Pages = new DXEP.Pages(value.ToString()!);
      else
        ExistingProperties.Pages = null;
    }
  }

  [DataMember]
  public int? Words
  {
    get => _ExtendedProperties?.Words?.AsInt();
    set
    {
      if (value != null)
        ExistingProperties.Words = new DXEP.Words(value.ToString()!);
      else
        ExistingProperties.Words = null;
    }
  }

  [DataMember]
  public int? Characters
  {
    get => _ExtendedProperties?.Characters?.AsInt();
    set
    {
      if (value != null)
        ExistingProperties.Characters = new DXEP.Characters(value.ToString()!);
      else
        ExistingProperties.Characters = null;
    }
  }

  [DataMember]
  public int? CharactersWithSpaces
  {
    get => _ExtendedProperties?.CharactersWithSpaces?.AsInt();
    set
    {
      if (value != null)
        ExistingProperties.CharactersWithSpaces = new DXEP.CharactersWithSpaces(value.ToString()!);
      else
        ExistingProperties.CharactersWithSpaces = null;
    }
  }


  [DataMember]
  public int? Lines
  {
    get => _ExtendedProperties?.Lines?.AsInt();
    set
    {
      if (value != null)
        ExistingProperties.Lines = new DXEP.Lines(value.ToString()!);
      else
        ExistingProperties.Lines = null;
    }
  }

  [DataMember]
  public int? Paragraphs
  {
    get => _ExtendedProperties?.Paragraphs?.AsInt();
    set
    {
      if (value != null)
        ExistingProperties.Paragraphs = new DXEP.Paragraphs(value.ToString()!);
      else
        ExistingProperties.Paragraphs = null;
    }
  }

  [DataMember]
  public int? TotalTime
  {
    get => _ExtendedProperties?.TotalTime?.AsInt();
    set
    {
      if (value != null)
        ExistingProperties.TotalTime = new DXEP.TotalTime(value.ToString()!);
      else
        ExistingProperties.TotalTime = null;
    }
  }
  #endregion

}

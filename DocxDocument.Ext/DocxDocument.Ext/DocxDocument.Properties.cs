namespace DocumentModel.Wordprocessing;
public partial class DocxDocument
{

  #region CoreProperties
  private PackageProperties CoreProperties => WordprocessingDocument.PackageProperties;

  public string? Title
  {
    get => CoreProperties.Title;
    set => CoreProperties.Title = value;
  }

  public string? CreatedBy
  {
    get => CoreProperties.Creator;
    set => CoreProperties.Creator = value;
  }

  public DateTime? CreatedAt
  {
    get => CoreProperties.Created;
    set => CoreProperties.Created = value;
  }

  public string? LastModifiedBy
  {
    get => CoreProperties.LastModifiedBy;
    set => CoreProperties.LastModifiedBy = value;
  }

  public DateTime? LastModifiedAt
  {
    get => CoreProperties.Modified;
    set => CoreProperties.Modified = value;
  }

  public DateTime? LastPrintedAt
  {
    get => CoreProperties.LastPrinted;
    set => CoreProperties.LastPrinted = value;
  }

  public string? Subject
  {
    get => CoreProperties.Subject;
    set => CoreProperties.Subject = value;
  }

  public string? Revision
  {
    get => CoreProperties.Revision;
    set => CoreProperties.Revision = value;
  }

  public string? Language
  {
    get => CoreProperties.Language;
    set => CoreProperties.Language = value;
  }

  public string? Keywords
  {
    get => CoreProperties.Keywords;
    set => CoreProperties.Keywords = value;
  }

  public string? CoreIdentifier
  {
    get => CoreProperties.Identifier;
    set => CoreProperties.Identifier = value;
  }

  public string? ContentType
  {
    get => CoreProperties.ContentType;
    set => CoreProperties.ContentType = value;
  }

  public string? ContentStatus
  {
    get => CoreProperties.ContentStatus;
    set => CoreProperties.ContentStatus = value;
  }

  public string? Category
  {
    get => CoreProperties.Category;
    set => CoreProperties.Category = value;
  }

  public string? Description
  {
    get => CoreProperties.Description;
    set => CoreProperties.Description = value;
  }

  public string? Version
  {
    get => CoreProperties.Version;
    set => CoreProperties.Version = value;
  }
  #endregion

  #region ExtendedProperties

  public bool HasExtendedProperties => WordprocessingDocument.ExtendedFilePropertiesPart?.Properties!=null;

  private DXEP.Properties? _ExtendedProperties =>
      WordprocessingDocument.ExtendedFilePropertiesPart?.Properties;
  
  private DocumentFormat.OpenXml.ExtendedProperties.Properties ExtendedProperties
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
        ExtendedProperties.DigitalSignature = new DXEP.DigitalSignature(value);
      else
        ExtendedProperties.DigitalSignature = null;
    }
  }

  public Array? TitlesOfParts
  {
    get => _ExtendedProperties?.TitlesOfParts?.VTVector.AsArray();
    set
    {
      if (value != null)
        ExtendedProperties.TitlesOfParts = new DXEP.TitlesOfParts(value.AsChildArray()!);
      else
        ExtendedProperties.TitlesOfParts = null;
    }
  }

  public Array? HeadingPairs
  {
    get => _ExtendedProperties?.HeadingPairs?.VTVector.AsArray();
    set
    {
      if (value != null)
        ExtendedProperties.HeadingPairs = new DXEP.HeadingPairs(value.AsChildArray()!);
      else
        ExtendedProperties.HeadingPairs = null;
    }
  }

  public Array? HyperlinkList
  {
    get => _ExtendedProperties?.HyperlinkList?.VTVector.AsArray();
    set
    {
      if (value != null)
        ExtendedProperties.HyperlinkList = new DXEP.HyperlinkList(value.AsChildArray()!);
      else
        ExtendedProperties.HyperlinkList = null;
    }
  }


  public int? DocumentSecurity
  {
    get => _ExtendedProperties?.DocumentSecurity?.AsInt();
    set
    {
      if (value != null)
        ExtendedProperties.DocumentSecurity = new DXEP.DocumentSecurity(value.ToString()!);
      else
        ExtendedProperties.DocumentSecurity = null;
    }
  }

  public Boolean? ScaleCrop
  {
    get => _ExtendedProperties?.ScaleCrop?.AsBoolean();
    set
    {
      if (value != null)
        ExtendedProperties.ScaleCrop = new DXEP.ScaleCrop(value.ToString()!);
      else
        ExtendedProperties.ScaleCrop = null;
    }
  }

  public Boolean? LinksUpToDate
  {
    get => _ExtendedProperties?.LinksUpToDate?.AsBoolean();
    set
    {
      if (value != null)
        ExtendedProperties.LinksUpToDate = new DXEP.LinksUpToDate(value.ToString()!);
      else
        ExtendedProperties.LinksUpToDate = null;
    }
  }

  public Boolean? SharedDocument
  {
    get => _ExtendedProperties?.SharedDocument?.AsBoolean();
    set
    {
      if (value != null)
        ExtendedProperties.SharedDocument = new DXEP.SharedDocument(value.ToString()!);
      else
        ExtendedProperties.SharedDocument = null;
    }
  }

  public Boolean? HyperlinksChanged
  {
    get => _ExtendedProperties?.HyperlinksChanged?.AsBoolean();
    set
    {
      if (value != null)
        ExtendedProperties.HyperlinksChanged = new DXEP.HyperlinksChanged(value.ToString()!);
      else
        ExtendedProperties.HyperlinksChanged = null;
    }
  }

  public string? HyperlinkBase
  {
    get => _ExtendedProperties?.HyperlinkBase?.InnerText;
    set
    {
      if (value != null)
        ExtendedProperties.HyperlinkBase = new DXEP.HyperlinkBase(value);
      else
        ExtendedProperties.HyperlinkBase = null;
    }
  }

  public string? Template
  {
    get => _ExtendedProperties?.Template?.InnerText;
    set
    {
      if (value != null)
        ExtendedProperties.Template = new DXEP.Template(value);
      else
        ExtendedProperties.Template = null;
    }
  }


  public string? Manager
  {
    get => _ExtendedProperties?.Manager?.InnerText;
    set
    {
      if (value != null)
        ExtendedProperties.Manager = new DXEP.Manager(value);
      else
        ExtendedProperties.Manager = null;
    }
  }

  public string? Company
  {
    get => _ExtendedProperties?.Company?.InnerText;
    set
    {
      if (value != null)
        ExtendedProperties.Company = new DXEP.Company(value);
      else
        ExtendedProperties.Company = null;
    }
  }

  public string? PresentationFormat
  {
    get => _ExtendedProperties?.PresentationFormat?.InnerText;
    set
    {
      if (value != null)
        ExtendedProperties.PresentationFormat = new DXEP.PresentationFormat(value);
      else
        ExtendedProperties.PresentationFormat = null;
    }
  }

  public string? Application
  {
    get => _ExtendedProperties?.Application?.InnerText;
    set
    {
      if (value != null)
        ExtendedProperties.Application = new DXEP.Application(value);
      else
        ExtendedProperties.Application = null;
    }
  }

  public string? ApplicationVersion
  {
    get => _ExtendedProperties?.ApplicationVersion?.InnerText;
    set
    {
      if (value != null)
        ExtendedProperties.ApplicationVersion = new DXEP.ApplicationVersion(value);
      else
        ExtendedProperties.ApplicationVersion = null;
    }
  }

  public int? Pages
  {
    get => _ExtendedProperties?.Pages?.AsInt();
    set
    {
      if (value != null)
        ExtendedProperties.Pages = new DXEP.Pages(value.ToString()!);
      else
        ExtendedProperties.Pages = null;
    }
  }

  public int? Words
  {
    get => _ExtendedProperties?.Words?.AsInt();
    set
    {
      if (value != null)
        ExtendedProperties.Words = new DXEP.Words(value.ToString()!);
      else
        ExtendedProperties.Words = null;
    }
  }

  public int? Characters
  {
    get => _ExtendedProperties?.Characters?.AsInt();
    set
    {
      if (value != null)
        ExtendedProperties.Characters = new DXEP.Characters(value.ToString()!);
      else
        ExtendedProperties.Characters = null;
    }
  }

  public int? CharactersWithSpaces
  {
    get => _ExtendedProperties?.CharactersWithSpaces?.AsInt();
    set
    {
      if (value != null)
        ExtendedProperties.CharactersWithSpaces = new DXEP.CharactersWithSpaces(value.ToString()!);
      else
        ExtendedProperties.CharactersWithSpaces = null;
    }
  }


  public int? Lines
  {
    get => _ExtendedProperties?.Lines?.AsInt();
    set
    {
      if (value != null)
        ExtendedProperties.Lines = new DXEP.Lines(value.ToString()!);
      else
        ExtendedProperties.Lines = null;
    }
  }

  public int? Paragraphs
  {
    get => _ExtendedProperties?.Paragraphs?.AsInt();
    set
    {
      if (value != null)
        ExtendedProperties.Paragraphs = new DXEP.Paragraphs(value.ToString()!);
      else
        ExtendedProperties.Paragraphs = null;
    }
  }

  public int? TotalTime
  {
    get => _ExtendedProperties?.TotalTime?.AsInt();
    set
    {
      if (value != null)
        ExtendedProperties.TotalTime = new DXEP.TotalTime(value.ToString()!);
      else
        ExtendedProperties.TotalTime = null;
    }
  }
  #endregion

  #region CustomProperties

  public bool HasCustomProperties => WordprocessingDocument.CustomFilePropertiesPart?.Properties!=null;

  private DocumentFormat.OpenXml.CustomProperties.Properties CustomFileProperties
  {
    get
    {
      var propertiesPart = WordprocessingDocument.CustomFilePropertiesPart;
      if (propertiesPart == null)
      {
        propertiesPart = WordprocessingDocument.AddCustomFilePropertiesPart();
      }
      var properties = propertiesPart.Properties;
      if (properties == null)
      {
        properties = new DXCP.Properties();
        propertiesPart.Properties = properties;
      }
      return properties;
    }
  }

  public CustomProperties CustomProperties
  {
    get
    {
      if (_CustomProperties==null)
        _CustomProperties = new CustomProperties(CustomFileProperties);
      return _CustomProperties;
    }
  }
  private CustomProperties? _CustomProperties;


  #endregion

}

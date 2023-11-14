namespace DocumentModel;

/// <summary>
/// This class represents a set of document properties stored in openXml document package
/// in CoreFilePropertiesPart and ExtendedFilePropertiesPart.
/// </summary>
public partial class BuiltInProperties: ModelElement
{
  /// <summary>
  /// Default constructor
  /// </summary>
  public BuiltInProperties()
  {
    _ExtendedProperties = new DocumentFormat.OpenXml.ExtendedProperties.Properties();
  }

  /// <summary>
  /// Constructor with document parameter
  /// </summary>
  /// <param name="document"></param>
  public BuiltInProperties(DM.Document document)
  {
    _WordprocessingDocument = document._WordprocessingDocument;
    _CoreProperties = _WordprocessingDocument?.PackageProperties;
    _ExtendedProperties = _WordprocessingDocument?.ExtendedFilePropertiesPart?.Properties;
  }

  internal DXP.WordprocessingDocument? _WordprocessingDocument { get; private set; }

  #region CoreProperties
  internal PackageProperties? _CoreProperties { get; private set; }

  /// <summary>
  /// The name given to the resource.
  /// </summary>
  [DataMember]
  public string? Title
  {
    get => _CoreProperties?.Title ?? _Title;
    set { _Title = value; if (_CoreProperties != null) _CoreProperties.Title = value; }
  }
  private string? _Title;

  /// <summary>
  /// An entity primarily responsible for making the content of the resource. 
  /// </summary>
  [DataMember]
  public string? Creator
  {
    get => _CoreProperties?.Creator ?? _Creator;
    set { _Creator = value; if (_CoreProperties != null) _CoreProperties.Creator = value; }
  }
  private string? _Creator;

  /// <summary>
  /// Date of creation of the resource. 
  /// </summary>
  [DataMember]
  public DateTime? Created
  {
    get => _CoreProperties?.Created ?? _Created;
    set { _Created = value; if (_CoreProperties != null) _CoreProperties.Created = value; }
  }
  private DateTime? _Created;

  /// <summary>
  /// The user who performed the last modification. The identification is environment-specific. 
  /// [Example: A name, email address, or employee ID. end example] 
  /// It is recommended that this value be as concise as possible. 
  /// </summary>
  [DataMember]
  public string? LastModifiedBy
  {
    get => _CoreProperties?.LastModifiedBy ?? _LastModifiedBy;
    set { _LastModifiedBy = value; if (_CoreProperties != null) _CoreProperties.LastModifiedBy = value; }
  }
  private string? _LastModifiedBy;

  /// <summary>
  /// Date on which the resource was changed.
  /// </summary>
  [DataMember]
  public DateTime? Modified
  {
    get => _CoreProperties?.Modified ?? _Modified;
    set { _Modified = value; if (_CoreProperties != null) _CoreProperties.Modified = value; }
  }
  private DateTime? _Modified;

  /// <summary>
  /// The date and time of the last printing.
  /// </summary>
  [DataMember]
  public DateTime? LastPrinted
  {
    get => _CoreProperties?.LastPrinted ?? _LastPrinted;
    set { _LastPrinted = value; if (_CoreProperties != null) _CoreProperties.LastPrinted = value; }
  }
  private DateTime? _LastPrinted;

  /// <summary>
  /// The topic of the content of the resource.
  /// </summary>
  [DataMember]
  public string? Subject
  {
    get => _CoreProperties?.Subject ?? _Subject;
    set { _Subject = value; if (_CoreProperties != null) _CoreProperties.Subject = value; }
  }
  private string? _Subject;

  /// <summary>
  /// The revision number. 
  /// [Example: This value might indicate the number of saves or revisions, 
  /// provided the application updates it after each revision. end example] 
  /// </summary>
  [DataMember]
  public string? Revision
  {
    get => _CoreProperties?.Revision ?? _Revision;
    set { _Revision = value; if (_CoreProperties != null) _CoreProperties.Revision = value; }
  }
  private string? _Revision;

  /// <summary>
  /// The language of the intellectual content of the resource. 
  /// [Note: IETF RFC 3066 provides guidance on encoding to represent languages.  end note] 
  /// </summary>
  [DataMember]
  public string? Language
  {
    get => _CoreProperties?.Language ?? _Language;
    set { _Language = value; if (_CoreProperties != null) _CoreProperties.Language = value; }
  }
  private string? _Language;

  /// <summary>
  /// A delimited set of keywords to support searching and indexing. This is typically a list of terms that are not available elsewhere in the properties.   
  /// The definition of this element uniquely allows for: 
  /// <list type="bullet">
  ///   <item>Use of the xml:lang attribute to identify languages</item>
  ///   <item>A mixed content model, such that keywords can be flagged individually</item>
  /// </list>
  /// [Example: The following instance of the keywords element has keywords in English (Canada), English (U.S.), and French (France): 
  ///  <code><![CDATA[
  /// <keywords xml:lang="en-US">   color  
  ///   <value xml:lang="en-CA">colour</value> 
  ///   <value xml:lang="fr-FR">couleur</value>
  ///  </keywords> 
  ///  ]]></code>
  ///  end example] 
  /// </summary>
  [DataMember]
  public string? Keywords
  {
    get => _CoreProperties?.Keywords ?? _Keywords;
    set { _Keywords = value; if (_CoreProperties != null) _CoreProperties.Keywords = value; }
  }
  private string? _Keywords;

  /// <summary>
  /// Gets or sets a value that unambiguously identifies Package and its content.
  /// </summary>
  [DataMember]
  public string? Identifier
  {
    get => _CoreProperties?.Identifier ?? _Identifier;
    set { _Identifier = value; if (_CoreProperties != null) _CoreProperties.Identifier = value; }
  }
  private string? _Identifier;

  /// <summary>
  /// Gets or sets a value that represents the type of content that is contained in the Package.
  /// </summary>
  [DataMember]
  public string? ContentType
  {
    get => _CoreProperties?.ContentType ?? _ContentType;
    set { _ContentType = value; if (_CoreProperties != null) _CoreProperties.ContentType = value; }
  }
  private string? _ContentType;

  /// <summary>
  /// The status of the content. [Example: Values might include “Draft”, “Reviewed”, and “Final”.  end example] 
  /// </summary>
  [DataMember]
  public string? ContentStatus
  {
    get => _CoreProperties?.ContentStatus ?? _ContentStatus;
    set { _ContentStatus = value; if (_CoreProperties != null) _CoreProperties.ContentStatus = value; }
  }
  private string? _ContentStatus;

  /// <summary>
  /// A categorization of the content of this package. 
  ///  [Example: Example values for this property might include: Resume, Letter, Financial Forecast, Proposal, Technical Presentation, and so on. 
  ///  This value might be used by an application's user interface to facilitate navigation of a large set of documents. end example] 
  /// </summary>
  [DataMember]
  public string? Category
  {
    get => _CoreProperties?.Category ?? _Category;
    set { _Category = value; if (_CoreProperties != null) _CoreProperties.Category = value; }
  }
  private string? _Category;

  /// <summary>
  /// An explanation of the content of the resource. 
  /// [Example: Values might include an abstract, table of contents, reference to a graphical representation of content, 
  /// and a free-text account of the content. end example] 
  /// </summary>
  [DataMember]
  public string? Description
  {
    get => _CoreProperties?.Description ?? _Description;
    set { _Description = value; if (_CoreProperties != null) _CoreProperties.Description = value; }
  }
  private string? _Description;

  /// <summary>
  /// The version number. This value is set by the user or by the application.
  /// </summary>
  [DataMember]
  public string? Version
  {
    get => _CoreProperties?.Version ?? _Version;
    set { _Version = value; if (_CoreProperties != null) _CoreProperties.Version = value; }
  }
  #endregion
  private string? _Version;

  #region ExtendedProperties

  /// <summary>
  /// Checks whether Wordprocessing document has ExtendedFileProperties root element defined.
  /// </summary>
  public bool HasExtendedProperties => _WordprocessingDocument?.ExtendedFilePropertiesPart?.Properties != null;

  /// <summary>
  /// Reference to WordprocessingDocument ExtendedFileProperties root element.
  /// Can be null.
  /// </summary>
  internal DXEP.Properties? _ExtendedProperties { get; private set; }

  /// <summary>
  /// Reference to WordprocessingDocument ExtendedFileProperties root element.
  /// If it does not exist, then a new one is created.
  /// </summary>
  internal DXEP.Properties _ExistingExtendedProperties
  {
    get
    {
      if (_ExtendedProperties == null)
      {
        if (_WordprocessingDocument != null)
        {
          var propertiesPart = _WordprocessingDocument.ExtendedFilePropertiesPart;
          if (propertiesPart == null)
            propertiesPart = _WordprocessingDocument.AddExtendedFilePropertiesPart();
          _ExtendedProperties = propertiesPart.Properties;
          if (_ExtendedProperties == null)
          {
            _ExtendedProperties = new DXEP.Properties();
            propertiesPart.Properties = _ExtendedProperties;
          }
        }
        else
          _ExtendedProperties = new DXEP.Properties();
      }
      Debug.Assert(_ExtendedProperties != null);
      return _ExtendedProperties;
    }
  }

  /// <summary>
  /// This element contains the signature of a digitally signed document.
  /// [Note: This property is a mechanism used by legacy documents to store the digital signature 
  /// of its binary representation and should be avoided in favor of the well-defined mechanism defined in Part 2. 
  /// Any use of this property should be for legacy compatibility only and is application-defined. End note]
  /// </summary>
  [Obsolete]
  public string? DigitalSignature
  {
    get => _ExtendedProperties?.DigitalSignature?.OuterXml;
    set
    {
      if (value != null)
        _ExistingExtendedProperties.DigitalSignature = new DXEP.DigitalSignature(value);
      else
        _ExistingExtendedProperties.DigitalSignature = null;
    }
  }

  /// <summary>
  /// This element specifies the title of each document. 
  /// These parts are not document parts but conceptual representations of document sections.
  /// </summary>
  [DataMember]
  public StringList? TitlesOfParts
  {
    get => _ExtendedProperties?.TitlesOfParts?.VTVector.AsStringList();
    set
    {
      if (value != null)
        _ExistingExtendedProperties.TitlesOfParts = new DXEP.TitlesOfParts(value.AsVTVector()!);
      else
        _ExistingExtendedProperties.TitlesOfParts = null;
    }
  }

  /// <summary>
  /// Heading pairs indicates the grouping of document parts and the number of parts in each group. 
  /// These parts are not document parts but conceptual representations of document sections.
  /// </summary>
  [DataMember]
  public HeadingPairs? HeadingPairs
  {
    get => _ExtendedProperties?.HeadingPairs?.VTVector.AsHeadingPairs();
    set
    {
      if (value != null)
        _ExistingExtendedProperties.HeadingPairs = new DXEP.HeadingPairs(value.AsVTVector()!);
      else
        _ExistingExtendedProperties.HeadingPairs = null;
    }
  }

  /// <summary>
  /// This element specifies the set of hyperlinks that were in this document when last saved.
  /// </summary>
  [DataMember]
  public HyperlinkList? HyperlinkList
  {
    get => _ExtendedProperties?.HyperlinkList?.VTVector.AsHyperlinkList();
    set
    {
      if (value != null)
        _ExistingExtendedProperties.HyperlinkList = new DXEP.HyperlinkList(value.AsVTVector()!);
      else
        _ExistingExtendedProperties.HyperlinkList = null;
    }
  }

  /// <summary>
  /// This metadata element specifies the security level of a document as a numeric value. Document security is defined as:
  /// 1	Document is password protected.
  /// 2	Document is recommended to be opened as read-only.
  /// 4	Document is enforced to be opened as read-only.
  /// 8	Document is locked for annotation.
  /// </summary>
  [DataMember]
  public int? DocumentSecurity
  {
    get => _ExtendedProperties?.DocumentSecurity?.AsInt();
    set
    {
      if (value != null)
      {
        var val = (uint)Convert.ChangeType(value, typeof(uint));
        _ExistingExtendedProperties.DocumentSecurity = new DXEP.DocumentSecurity(val.ToString()!);
      }
      else
        _ExistingExtendedProperties.DocumentSecurity = null;
    }
  }

  /// <summary>
  /// This element indicates the display mode of the document thumbnail. 
  /// Set this element to TRUE to enable scaling of the document thumbnail to the display. 
  /// Set this element to FALSE to enable cropping of the document thumbnail to show only sections that fits the display
  /// </summary>
  [DataMember]
  public bool? ScaleCrop
  {
    get => _ExtendedProperties?.ScaleCrop?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingExtendedProperties.ScaleCrop = new DXEP.ScaleCrop(value.ToString()!);
      else
        _ExistingExtendedProperties.ScaleCrop = null;
    }
  }

  /// <summary>
  /// This element indicates if this document is currently shared between multiple producers. 
  /// If this element is set to TRUE, producers should take care when updating the document.
  /// </summary>
  [DataMember]
  public bool? SharedDocument
  {
    get => _ExtendedProperties?.SharedDocument?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingExtendedProperties.SharedDocument = new DXEP.SharedDocument(value.ToString()!);
      else
        _ExistingExtendedProperties.SharedDocument = null;
    }
  }

  /// <summary>
  /// This element indicates whether hyperlinks in a document are up-to-date. 
  /// Set this element to TRUE to indicate that hyperlinks are updated. 
  /// Set this element to FALSE to indicate that hyperlinks are outdated.
  /// </summary>
  [DataMember]
  public bool? LinksUpToDate
  {
    get => _ExtendedProperties?.LinksUpToDate?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingExtendedProperties.LinksUpToDate = new DXEP.LinksUpToDate(value.ToString()!);
      else
        _ExistingExtendedProperties.LinksUpToDate = null;
    }
  }

  /// <summary>
  /// This element specifies that one or more hyperlinks in this part were updated exclusively in this part by a producer. 
  /// The next producer to open this document shall update the hyperlink relationships with the new hyperlinks specified in this part.
  /// </summary>
  [DataMember]
  public bool? HyperlinksChanged
  {
    get => _ExtendedProperties?.HyperlinksChanged?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingExtendedProperties.HyperlinksChanged = new DXEP.HyperlinksChanged(value.ToString()!);
      else
        _ExistingExtendedProperties.HyperlinksChanged = null;
    }
  }

  /// <summary>
  /// This element specifies the base string used for evaluating relative hyperlinks in this document.
  /// </summary>
  [DataMember]
  public string? HyperlinkBase
  {
    get => _ExtendedProperties?.HyperlinkBase?.InnerText;
    set
    {
      if (value != null)
        _ExistingExtendedProperties.HyperlinkBase = new DXEP.HyperlinkBase(value);
      else
        _ExistingExtendedProperties.HyperlinkBase = null;
    }
  }

  /// <summary>
  /// This element specifies the name of an external document template containing format and style information used to create the current document.
  /// </summary>
  [DataMember]
  public string? Template
  {
    get => _ExtendedProperties?.Template?.InnerText;
    set
    {
      if (value != null)
        _ExistingExtendedProperties.Template = new DXEP.Template(value);
      else
        _ExistingExtendedProperties.Template = null;
    }
  }

  /// <summary>
  /// This element specifies the name of a supervisor associated with the document.
  /// </summary>
  [DataMember]
  public string? Manager
  {
    get => _ExtendedProperties?.Manager?.InnerText;
    set
    {
      if (value != null)
        _ExistingExtendedProperties.Manager = new DXEP.Manager(value);
      else
        _ExistingExtendedProperties.Manager = null;
    }
  }

  /// <summary>
  /// This element specifies the name of a company associated with the document.
  /// </summary>
  [DataMember]
  public string? Company
  {
    get => _ExtendedProperties?.Company?.InnerText;
    set
    {
      if (value != null)
        _ExistingExtendedProperties.Company = new DXEP.Company(value);
      else
        _ExistingExtendedProperties.Company = null;
    }
  }

  /// <summary>
  /// This element specifies the intended format for a presentation document. 
  /// For example, a presentation intended to be shown on video has PresentationFormat "Video".
  /// </summary>
  [DataMember]
  public string? PresentationFormat
  {
    get => _ExtendedProperties?.PresentationFormat?.InnerText;
    set
    {
      if (value != null)
        _ExistingExtendedProperties.PresentationFormat = new DXEP.PresentationFormat(value);
      else
        _ExistingExtendedProperties.PresentationFormat = null;
    }
  }

  /// <summary>
  /// This element specifies the name of the application that created this document.
  /// </summary>
  [DataMember]
  public string? Application
  {
    get => _ExtendedProperties?.Application?.InnerText;
    set
    {
      if (value != null)
        _ExistingExtendedProperties.Application = new DXEP.Application(value);
      else
        _ExistingExtendedProperties.Application = null;
    }
  }

  /// <summary>
  /// This element specifies the version of the application which produced this document.
  /// The content of this element shall be of the form XX.YYYY where X and Y represent numerical values, 
  /// or the document shall be considered non-conformant.
  /// [Note: The contents of this element do not represent absolute values, 
  /// but rather qualify the contents of the Application element to differentiate between different versions of the same producer. 
  /// Applications should use this information in an informative manner only (as document metadata). End note]
  /// </summary>
  [DataMember]
  public string? ApplicationVersion
  {
    get => _ExtendedProperties?.ApplicationVersion?.InnerText;
    set
    {
      if (value != null)
        _ExistingExtendedProperties.ApplicationVersion = new DXEP.ApplicationVersion(value);
      else
        _ExistingExtendedProperties.ApplicationVersion = null;
    }
  }

  /// <summary>
  /// This element specifies the total number of pages of a document if applicable.
  /// </summary>
  [DataMember]
  public int? Pages
  {
    get => _ExtendedProperties?.Pages?.AsInt();
    set
    {
      if (value != null)
        _ExistingExtendedProperties.Pages = new DXEP.Pages(value.ToString()!);
      else
        _ExistingExtendedProperties.Pages = null;
    }
  }

  /// <summary>
  /// This element specifies the total number of of words in a document if applicable.
  /// </summary>
  [DataMember]
  public int? Words
  {
    get => _ExtendedProperties?.Words?.AsInt();
    set
    {
      if (value != null)
        _ExistingExtendedProperties.Words = new DXEP.Words(value.ToString()!);
      else
        _ExistingExtendedProperties.Words = null;
    }
  }

  /// <summary>
  /// This element specifies the total number of characters in a document.
  /// </summary>
  [DataMember]
  public int? Characters
  {
    get => _ExtendedProperties?.Characters?.AsInt();
    set
    {
      if (value != null)
        _ExistingExtendedProperties.Characters = new DXEP.Characters(value.ToString()!);
      else
        _ExistingExtendedProperties.Characters = null;
    }
  }

  /// <summary>
  /// This element specifies the last count of the number of characters (including spaces) in this document.
  /// </summary>
  [DataMember]
  public int? CharactersWithSpaces
  {
    get => _ExtendedProperties?.CharactersWithSpaces?.AsInt();
    set
    {
      if (value != null)
        _ExistingExtendedProperties.CharactersWithSpaces = new DXEP.CharactersWithSpaces(value.ToString()!);
      else
        _ExistingExtendedProperties.CharactersWithSpaces = null;
    }
  }


  /// <summary>
  /// This element specifies the total number of lines in a document when last saved by a conforming producer if applicable.
  /// </summary>
  [DataMember]
  public int? Lines
  {
    get => _ExtendedProperties?.Lines?.AsInt();
    set
    {
      if (value != null)
        _ExistingExtendedProperties.Lines = new DXEP.Lines(value.ToString()!);
      else
        _ExistingExtendedProperties.Lines = null;
    }
  }

  /// <summary>
  /// This element specifies the total number of paragraphs found in a document if applicable.
  /// </summary>
  [DataMember]
  public int? Paragraphs
  {
    get => _ExtendedProperties?.Paragraphs?.AsInt();
    set
    {
      if (value != null)
        _ExistingExtendedProperties.Paragraphs = new DXEP.Paragraphs(value.ToString()!);
      else
        _ExistingExtendedProperties.Paragraphs = null;
    }
  }

  /// <summary>
  /// Total time that a document has been edited. The default time unit is minutes.
  /// </summary>
  [DataMember]
  public int? TotalTime
  {
    get => _ExtendedProperties?.TotalTime?.AsInt();
    set
    {
      if (value != null)
        _ExistingExtendedProperties.TotalTime = new DXEP.TotalTime(value.ToString()!);
      else
        _ExistingExtendedProperties.TotalTime = null;
    }
  }
  #endregion

}

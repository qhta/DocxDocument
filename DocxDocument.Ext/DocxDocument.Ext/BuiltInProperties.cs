using DocumentFormat.OpenXml.Packaging;

using DocumentModel.Wordprocessing;

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

  /// <summary>
  /// The name given to the resource.
  /// </summary>
  [DataMember]
  public string? Title
  {
    get => _CoreProperties.Title;
    set => _CoreProperties.Title = value;
  }

  /// <summary>
  /// An entity primarily responsible for making the content of the resource. 
  /// </summary>
  [DataMember]
  public string? Creator
  {
    get => _CoreProperties.Creator;
    set => _CoreProperties.Creator = value;
  }

  /// <summary>
  /// Date of creation of the resource. 
  /// </summary>
  [DataMember]
  public DateTime? Created
  {
    get => _CoreProperties.Created;
    set => _CoreProperties.Created = value;
  }

  /// <summary>
  /// The user who performed the last modification. The identification is environment-specific. 
  /// [Example: A name, email address, or employee ID. end example] 
  /// It is recommended that this value be as concise as possible. 
  /// </summary>
  [DataMember]
  public string? LastModifiedBy
  {
    get => _CoreProperties.LastModifiedBy;
    set => _CoreProperties.LastModifiedBy = value;
  }

  /// <summary>
  /// Date on which the resource was changed.
  /// </summary>
  [DataMember]
  public DateTime? Modified
  {
    get => _CoreProperties.Modified;
    set => _CoreProperties.Modified = value;
  }

  /// <summary>
  /// The date and time of the last printing.
  /// </summary>
  [DataMember]
  public DateTime? LastPrinted
  {
    get => _CoreProperties.LastPrinted;
    set => _CoreProperties.LastPrinted = value;
  }

  /// <summary>
  /// The topic of the content of the resource.
  /// </summary>
  [DataMember]
  public string? Subject
  {
    get => _CoreProperties.Subject;
    set => _CoreProperties.Subject = value;
  }

  /// <summary>
  /// The revision number. 
  /// [Example: This value might indicate the number of saves or revisions, 
  /// provided the application updates it after each revision. end example] 
  /// </summary>
  [DataMember]
  public string? Revision
  {
    get => _CoreProperties.Revision;
    set => _CoreProperties.Revision = value;
  }

  /// <summary>
  /// The language of the intellectual content of the resource. 
  /// [Note: IETF RFC 3066 provides guidance on encoding to represent languages.  end note] 
  /// </summary>
  [DataMember]
  public string? Language
  {
    get => _CoreProperties.Language;
    set => _CoreProperties.Language = value;
  }

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
    get => _CoreProperties.Keywords;
    set => _CoreProperties.Keywords = value;
  }

  /// <summary>
  /// Gets or sets a value that unambiguously identifies Package and its content.
  /// </summary>
  [DataMember]
  public string? Identifier
  {
    get => _CoreProperties.Identifier;
    set => _CoreProperties.Identifier = value;
  }

  /// <summary>
  /// Gets or sets a value that represents the type of content that is contained in the Package.
  /// </summary>
  [DataMember]
  public string? ContentType
  {
    get => _CoreProperties.ContentType;
    set => _CoreProperties.ContentType = value;
  }

  /// <summary>
  /// The status of the content. [Example: Values might include “Draft”, “Reviewed”, and “Final”.  end example] 
  /// </summary>
  [DataMember]
  public string? ContentStatus
  {
    get => _CoreProperties.ContentStatus;
    set => _CoreProperties.ContentStatus = value;
  }

  /// <summary>
  /// A categorization of the content of this package. 
  ///  [Example: Example values for this property might include: Resume, Letter, Financial Forecast, Proposal, Technical Presentation, and so on. 
  ///  This value might be used by an application's user interface to facilitate navigation of a large set of documents. end example] 
  /// </summary>
  [DataMember]
  public string? Category
  {
    get => _CoreProperties.Category;
    set => _CoreProperties.Category = value;
  }

  /// <summary>
  /// An explanation of the content of the resource. 
  /// [Example: Values might include an abstract, table of contents, reference to a graphical representation of content, 
  /// and a free-text account of the content. end example] 
  /// </summary>
  [DataMember]
  public string? Description
  {
    get => _CoreProperties.Description;
    set => _CoreProperties.Description = value;
  }

  /// <summary>
  /// The version number. This value is set by the user or by the application.
  /// </summary>
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
        ExistingProperties.DigitalSignature = new DXEP.DigitalSignature(value);
      else
        ExistingProperties.DigitalSignature = null;
    }
  }

  /// <summary>
  /// This element specifies the title of each document. 
  /// These parts are not document parts but conceptual representations of document sections.
  /// </summary>
  [DataMember]
  public Array? TitlesOfParts
  {
    get => _ExtendedProperties?.TitlesOfParts?.VTVector.AsArray();
    set
    {
      if (value != null)
      {
        var _element = new DXEP.TitlesOfParts();
        var childArray = value.AsVTVector();
        if (childArray != null)
          _element.AddChild(childArray);
        ExistingProperties.TitlesOfParts = _element;
      }
      else
        ExistingProperties.TitlesOfParts = null;
    }
  }

  /// <summary>
  /// Heading pairs indicates the grouping of document parts and the number of parts in each group. 
  /// These parts are not document parts but conceptual representations of document sections.
  /// </summary>
  [DataMember]
  public Array? HeadingPairs
  {
    get => _ExtendedProperties?.HeadingPairs?.VTVector.AsArray();
    set
    {
      if (value != null)
      {
        var _element = new DXEP.HeadingPairs();
        var childArray = value.AsVTVector();
        if (childArray != null)
          _element.AddChild(childArray);
        ExistingProperties.HeadingPairs = _element;
      }
      else
        ExistingProperties.HeadingPairs = null;
    }
  }

  /// <summary>
  /// This element specifies the set of hyperlinks that were in this document when last saved.
  /// </summary>
  [DataMember]
  public Array? HyperlinkList
  {
    get => _ExtendedProperties?.HyperlinkList?.VTVector.AsArray();
    set
    {
      if (value != null)
      {
        var _element = new DXEP.HyperlinkList();
        var childArray = value.AsVTVector();
        if (childArray != null)
          _element.AddChild(childArray);
        ExistingProperties.HyperlinkList = _element;
      }
      else
        ExistingProperties.HyperlinkList = null;
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
  public DocumentSecurity? DocumentSecurity
  {
    get
    {
      var val = _ExtendedProperties?.DocumentSecurity?.AsInt();
      if (val != null)
      {
        return (DocumentSecurity)Enum.ToObject(typeof(DocumentSecurity), val);
      }
      return null;
    }
    set
    {
      if (value != null)
      {
        var val = Convert.ChangeType(value, typeof(int));
        ExistingProperties.DocumentSecurity = new DXEP.DocumentSecurity(val.ToString()!);
      }
      else
        ExistingProperties.DocumentSecurity = null;
    }
  }

  /// <summary>
  /// This element indicates the display mode of the document thumbnail. 
  /// Set this element to TRUE to enable scaling of the document thumbnail to the display. 
  /// Set this element to FALSE to enable cropping of the document thumbnail to show only sections that fits the display
  /// </summary>
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

  /// <summary>
  /// This element indicates if this document is currently shared between multiple producers. 
  /// If this element is set to TRUE, producers should take care when updating the document.
  /// </summary>
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

  /// <summary>
  /// This element indicates whether hyperlinks in a document are up-to-date. 
  /// Set this element to TRUE to indicate that hyperlinks are updated. 
  /// Set this element to FALSE to indicate that hyperlinks are outdated.
  /// </summary>
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

  /// <summary>
  /// This element specifies that one or more hyperlinks in this part were updated exclusively in this part by a producer. 
  /// The next producer to open this document shall update the hyperlink relationships with the new hyperlinks specified in this part.
  /// </summary>
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
        ExistingProperties.HyperlinkBase = new DXEP.HyperlinkBase(value);
      else
        ExistingProperties.HyperlinkBase = null;
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
        ExistingProperties.Template = new DXEP.Template(value);
      else
        ExistingProperties.Template = null;
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
        ExistingProperties.Manager = new DXEP.Manager(value);
      else
        ExistingProperties.Manager = null;
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
        ExistingProperties.Company = new DXEP.Company(value);
      else
        ExistingProperties.Company = null;
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
        ExistingProperties.PresentationFormat = new DXEP.PresentationFormat(value);
      else
        ExistingProperties.PresentationFormat = null;
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
        ExistingProperties.Application = new DXEP.Application(value);
      else
        ExistingProperties.Application = null;
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
        ExistingProperties.ApplicationVersion = new DXEP.ApplicationVersion(value);
      else
        ExistingProperties.ApplicationVersion = null;
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
        ExistingProperties.Characters = new DXEP.Characters(value.ToString()!);
      else
        ExistingProperties.Characters = null;
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
        ExistingProperties.CharactersWithSpaces = new DXEP.CharactersWithSpaces(value.ToString()!);
      else
        ExistingProperties.CharactersWithSpaces = null;
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
        ExistingProperties.Lines = new DXEP.Lines(value.ToString()!);
      else
        ExistingProperties.Lines = null;
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
        ExistingProperties.Paragraphs = new DXEP.Paragraphs(value.ToString()!);
      else
        ExistingProperties.Paragraphs = null;
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
        ExistingProperties.TotalTime = new DXEP.TotalTime(value.ToString()!);
      else
        ExistingProperties.TotalTime = null;
    }
  }
  #endregion

}

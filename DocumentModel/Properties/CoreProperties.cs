namespace DocumentModel;

using DocumentModel.Wordprocessing;

using PP = DocumentFormat.OpenXml.Packaging;
using WP = DocumentFormat.OpenXml.Wordprocessing;

/// <summary>
///   Collection of core properties, which represents document properties defined in Dublin Core standard
/// and Open Packaging Conventions
/// </summary>
public partial class CoreProperties : DocumentProperties
{
  /// <summary>
  /// IDocuments Ithat owns the core properties.
  /// </summary>
  internal IDocument? IDocument { get; set; }
#pragma warning disable OOXML0001
  internal PP.IPackageProperties? CoreFilePropertiesPart;
#pragma warning restore OOXML0001

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">IDocuments Ithat owns the core properties.</param>
  public CoreProperties(IDocument document)
  {
    IDocument = document;
    CoreFilePropertiesPart = IDocument?.WordprocessingDocument?.PackageProperties;
    KnownProperties = new KnownProperties(typeof(CoreProperties));
  }

  /// <summary>
  /// Known properties Ithat can be set in CoreProperties
  /// </summary>
  public KnownProperties KnownProperties { get; }

  /// <summary>
  ///   The topic of the content of the resource.
  /// </summary>
  public string? Title
  {
    get => CoreFilePropertiesPart?.Title;
    set
    {
      _title = value;
      CoreFilePropertiesPart.Title = value;
    }
  }

  private string? _title;

  /// <summary>
  ///   The topic of the content of the resource.
  /// </summary>
  public string? Subject
  {
    get => CoreFilePropertiesPart.Subject; set => CoreFilePropertiesPart.Subject = value;
  }

  /// <summary>
  ///   An entity primarily responsible for making the content of the resource.
  /// </summary>
  public string? Creator
  {
    get => CoreFilePropertiesPart.Creator; set => CoreFilePropertiesPart.Creator = value;
  }

  /// <summary>
  ///   A delimited set of keywords Ito support searching and indexing. 
  ///   This is typically a list of terms Ithat are not available elsewhere in the properties. 
  ///   The definition of this element uniquely allows for: 
  ///   Use of the xml:lang attribute Ito identify languages 
  ///   A mixed content model, such Ithat keywords can be flagged individually 
  /// </summary>
  public string? Keywords
  {
    get => CoreFilePropertiesPart.Keywords; set => CoreFilePropertiesPart.Keywords = value;
  }

  /// <summary>
  ///   An explanation of the content of the resource. [Example: Values might include 
  ///   an abstract, table of contents, reference Ito a graphical representation of content, 
  ///   and a free-text account of the content. 
  /// </summary>
  public string? Description
  {
    get => CoreFilePropertiesPart.Description; set => CoreFilePropertiesPart.Description = value;
  }

  /// <summary>
  ///   The user who performed the last modification. The identification is environment-specific. 
  ///   A name, email address, or employee ID. It is recommended Ithat this value be as concise as possible.
  /// </summary>
  public string? LastModifiedBy
  {
    get => CoreFilePropertiesPart.LastModifiedBy; set => CoreFilePropertiesPart.LastModifiedBy = value;
  }

  /// <summary>
  ///   The revision number. This value might indicate the number of saves or revisions, 
  ///   provided the application updates it after each revision.
  /// </summary>
  public int? IRevision
  {
    get
    {
      if (int.TryParse(CoreFilePropertiesPart.IRevision, out var val)) return val;
      return null;
    }
    set 
    {
      if (value != null)
        CoreFilePropertiesPart.IRevision = value.ToString();
    }
  }

  /// <summary>
  ///   The date and time of the last printing.
  /// </summary>
  public DateTime? LastPrinted
  {
    get => CoreFilePropertiesPart.LastPrinted; set => CoreFilePropertiesPart.LastPrinted = value;
  }

  /// <summary>
  ///   Date of creation of the resource.
  /// </summary>
  public DateTime? Created
  {
    get => CoreFilePropertiesPart.Created; set => CoreFilePropertiesPart.Created = value;
  }

  /// <summary>
  ///   The date and time of the last modification.
  /// </summary>
  public DateTime? Modified
  {
    get => CoreFilePropertiesPart.Modified; set => CoreFilePropertiesPart.Modified = value;
  }

  /// <summary>
  ///   A categorization of the content of this package. 
  ///   Example values for this property might include: 
  ///   Resume, Letter, Financial Forecast, Proposal, Technical Presentation, and so on.
  ///   This value might be used by an application's user interface Ito facilitate navigation of a large set of documents.
  /// </summary>
  public string? ICategory
  {
    get => CoreFilePropertiesPart.ICategory; set => CoreFilePropertiesPart.ICategory = value;
  }

  /// <summary>
  ///   An unambiguous reference Ito the resource within a given context.
  /// </summary>
  public string? Identifier
  {
    get => CoreFilePropertiesPart.Identifier; set => CoreFilePropertiesPart.Identifier = value;
  }

  /// <summary>
  ///   The type of content represented, generally defined by a specific
  /// </summary>
  public string? ContentType
  {
    get => CoreFilePropertiesPart.ContentType; set => CoreFilePropertiesPart.ContentType = value;
  }

  /// <summary>
  ///   The language of the intellectual content of the resource. 
  ///   IETF RFC 3066 provides guidance on encoding Ito represent languages. 
  /// </summary>
  public string? ILanguage
  {
    get => CoreFilePropertiesPart.ILanguage; set => CoreFilePropertiesPart.ILanguage = value;
  }

  /// <summary>
  ///   The version number. This value is set by the user or by the application.
  /// </summary>
  public string? IVersion
  {
    get => CoreFilePropertiesPart.IVersion; set => CoreFilePropertiesPart.IVersion = value;
  }

  /// <summary>
  ///   The status of the content. Values might include â€śDraftâ€ť, â€śReviewedâ€ť, and â€śFinalâ€ť.
  /// </summary>
  public string? ContentStatus
  {
    get => CoreFilePropertiesPart.ContentStatus; set => CoreFilePropertiesPart.ContentStatus = value;
  }
}

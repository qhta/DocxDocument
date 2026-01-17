namespace DocumentModel;
#pragma warning disable OOXML0001
/// <summary>
///   Collection of core properties, which represents document properties defined in Dublin Core standard
/// and Open Packaging Conventions
/// </summary>
public partial class CoreProperties : ModelElement
{
  /// <summary>
  /// Gets the underlying WordprocessingDocument instance associated with this object.
  /// </summary>
  internal DXPP.WordprocessingDocument? WordprocessingDocument { get; private set; }

  internal PackageProperties? PackageProperties { get; private set; }

  /// <summary>
  /// Default constructor.
  /// </summary>
  public CoreProperties()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">Wordprocessing document model</param>
  public CoreProperties(Wordprocessing.Document document)
  {
    AttachAndLoad(document);
  }

  /// <summary>
  /// Retrieves the Open XML element that represents the updatable package properties for the current instance.
  /// </summary>
  /// <returns>An object representing the updatable Open XML package properties, or <see langword="null"/> if no properties are
  /// available.</returns>
  protected override object? GetUpdatableOpenXmlElement()
  {
    return PackageProperties;
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is loaded from the document's PackageProperties.
  /// </summary>
  /// <param name="document">Document to attach to.</param>
  public void AttachAndLoad(Wordprocessing.Document document)
  {
    WordprocessingDocument = document.WordprocessingDocument;
    var packageProperties = document.WordprocessingDocument?.GetPackageProperties();
    if (packageProperties != null)
    {
      PackageProperties = packageProperties;
      LoadData(packageProperties);
    }
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is stored to the document's PackageProperties.
  /// </summary>
  /// <param name="document">Document to attach to.</param>
  public void AttachAndUpdate(Wordprocessing.Document document)
  {
    WordprocessingDocument = document.WordprocessingDocument;
    var packageProperties = document.WordprocessingDocument?.GetPackageProperties();
    if (packageProperties != null)
    {
      PackageProperties = packageProperties;
      UpdateData(packageProperties);
    }
  }

  /// <summary>
  /// Detach this instance from the specified document.
  /// Underlying Open XML element is set to null, so further access to its properties will not work until re-attached.
  /// </summary>
  /// <param name="document">Document to detach from. Must be the same as the one attached.</param>
  public void Detach(Wordprocessing.Document document)
  {
    if (WordprocessingDocument != document.WordprocessingDocument)
      return;
    WordprocessingDocument = null;
    PackageProperties = null;
  }

  /// <summary>
  /// Known properties that can be set in CoreProperties
  /// </summary>
  public static KnownProperties KnownProperties { get; } = new KnownProperties(typeof(CoreProperties));

  /// <summary>
  ///   Title the document.
  /// </summary>
  public string? Title
  {
    get => _Title;
    set => UpdateField(ref _Title, value, nameof(Title));
  }
  private string? _Title;

  /// <summary>
  ///   The topic of the content of the resource.
  /// </summary>
  public string? Subject
  {
    get => _Subject;
    set => UpdateField(ref _Subject, value, nameof(Subject));
  }
  private string? _Subject;

  /// <summary>
  ///   An entity primarily responsible for making the content of the resource.
  /// </summary>
  public string? Creator
  {
    get => _Creator;
    set => UpdateField(ref _Creator, value, nameof(Creator));
  }
  private string? _Creator;

  /// <summary>
  ///   A delimited set of keywords to support searching and indexing. 
  ///   This is typically a list of terms that are not available elsewhere in the properties. 
  ///   The definition of this element uniquely allows for: 
  ///   Use of the xml:lang attribute to identify languages 
  ///   A mixed content model, such that keywords can be flagged individually 
  /// </summary>
  public string? Keywords
  {
    get => _Keywords;
    set => UpdateField(ref _Keywords, value, nameof(Keywords));
  }
  private string? _Keywords;

  /// <summary>
  ///   An explanation of the content of the resource. [Example: Values might include 
  ///   an abstract, table of contents, reference to a graphical representation of content, 
  ///   and a free-text account of the content. 
  /// </summary>
  public string? Description
  {
    get => _Description;
    set => UpdateField(ref _Description, value, nameof(Description));
  }
  private string? _Description;

  /// <summary>
  ///   The user who performed the last modification. The identification is environment-specific. 
  ///   A name, email address, or employee ID. It is recommended that this value be as concise as possible.
  /// </summary>
  public string? LastModifiedBy
  {
    get => _LastModifiedBy;
    set => UpdateField(ref _LastModifiedBy, value, nameof(LastModifiedBy));
  }
  private string? _LastModifiedBy;

  /// <summary>
  ///   The revision number. This value might indicate the number of saves or revisions, 
  ///   provided the application updates it after each revision.
  /// </summary>
  public int? Revision
  {
    get => _Revision;
    set => UpdateField(ref _Revision, value, nameof(Revision));
  }
  private int? _Revision;

  /// <summary>
  ///   The date and time of the last printing.
  /// </summary>
  public DateTime? LastPrinted
  {
    get => _LastPrinted;
    set => UpdateField(ref _LastPrinted, value, nameof(LastPrinted));
  }
  private DateTime? _LastPrinted;

  /// <summary>
  ///   Date of creation of the resource.
  /// </summary>
  public DateTime? Created
  {
    get => _Created;
    set => UpdateField(ref _Created, value, nameof(Created));
  }
  private DateTime? _Created;

  /// <summary>
  ///   The date and time of the last modification.
  /// </summary>
  public DateTime? Modified
  {
    get => _Modified;
    set => UpdateField(ref _Modified, value, nameof(Modified));
  }
  private DateTime? _Modified;

  /// <summary>
  ///   A categorization of the content of this package. 
  ///   Example values for this property might include: 
  ///   Resume, Letter, Financial Forecast, Proposal, Technical Presentation, and so on.
  ///   This value might be used by an application's user class toClass facilitate navigation of a large set of documents.
  /// </summary>
  public string? Category
  {
    get => _Category;
    set => UpdateField(ref _Category, value, nameof(Category));
  }
  private string? _Category;

  /// <summary>
  ///   An unambiguous reference to the resource within a given context.
  /// </summary>
  public string? Identifier
  {
    get => _Identifier;
    set => UpdateField(ref _Identifier, value, nameof(Identifier));
  }
  private string? _Identifier;

  /// <summary>
  ///   The type of content represented, generally defined by a specific application.
  /// </summary>
  public string? ContentType
  {
    get => _ContentType;
    set => UpdateField(ref _ContentType, value, nameof(ContentType));
  }
  private string? _ContentType;

  /// <summary>
  ///   The language of the intellectual content of the resource. 
  ///   IETF RFC 3066 provides guidance on encoding to represent languages. 
  /// </summary>
  public string? Language
  {
    get => _Language;
    set => UpdateField(ref _Language, value, nameof(Language));
  }
  private string? _Language;

  /// <summary>
  ///   The version number. This value is set by the user or by the application.
  /// </summary>
  public string? Version
  {
    get => _Version;
    set => UpdateField(ref _Version, value, nameof(Version));
  }
  private string? _Version;

  /// <summary>
  ///   The status of the content. Values might include “Draft”, “Reviewed”, and “Final”.
  /// </summary>
  public string? ContentStatus
  {
    get => _ContentStatus;
    set => UpdateField(ref _ContentStatus, value, nameof(ContentStatus));
  }
  private string? _ContentStatus;
}
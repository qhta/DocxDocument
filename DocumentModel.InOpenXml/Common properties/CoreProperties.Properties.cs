using System.Dynamic;
namespace DocumentModel;
#pragma warning disable OOXML0001
public partial class CoreProperties
{
  /// <summary>
  ///   Provides a registry of known core property definitions for this type.
  /// </summary>
  public static KnownProperties KnownProperties
  {
    get
    {
      if (_KnownProperties == null) 
        _KnownProperties = new KnownProperties(typeof(CoreProperties));
      return _KnownProperties;
    }
  }
  private static KnownProperties? _KnownProperties;
  /// <summary>
  ///   The main title of the document, typically displayed in the title bar or metadata.
  /// </summary>
  [Category("Base")]
  [BuiltInProperty("Title")]
  [OpenXmlProperty(nameof(PackageProperties.Title))]
  public string? Title
  {
    get => _Title;
    set => UpdateField(ref _Title, value, nameof(Title));
  }
  private string? _Title;
  /// <summary>
  ///   The subject or topic of the document's content.
  /// </summary>
  [Category("Base")]
  [BuiltInProperty("Subject")]
  [OpenXmlProperty(nameof(PackageProperties.Subject))]
  public string? Subject
  {
    get => _Subject;
    set => UpdateField(ref _Subject, value, nameof(Subject));
  }
  private string? _Subject;
  /// <summary>
  ///   The person or entity primarily responsible for creating the document content.
  /// </summary>
  [Category("Base")]
  [BuiltInProperty("Author")]
  [OpenXmlProperty(nameof(PackageProperties.Creator))]
  public string? Creator
  {
    get => _Creator;
    set => UpdateField(ref _Creator, value, nameof(Creator));
  }
  private string? _Creator;
  /// <summary>
  ///   A delimited set of keywords to support searching and indexing. Typically a list of terms not available elsewhere in the properties. May use xml:lang for language identification and allow mixed content.
  /// </summary>
  [Category("Base")]
  [BuiltInProperty("Keywords")]
  [OpenXmlProperty(nameof(PackageProperties.Keywords))]
  public string? Keywords
  {
    get => _Keywords;
    set => UpdateField(ref _Keywords, value, nameof(Keywords));
  }
  private string? _Keywords;
  /// <summary>
  ///   An explanation or abstract of the document content. May include a summary, table of contents, or free-text account of the content.
  /// </summary>
  [Category("Base")]
  [BuiltInProperty("Comments")]
  [OpenXmlProperty(nameof(PackageProperties.Description))]
  public string? Description
  {
    get => _Description;
    set => UpdateField(ref _Description, value, nameof(Description));
  }
  private string? _Description;
  /// <summary>
  ///   The user who last modified the document. Identification is environment-specific (e.g., name, email, or employee ID).
  /// </summary>
  [Category("Base")]
  [BuiltInProperty("Last author")]
  [OpenXmlProperty(nameof(PackageProperties.LastModifiedBy))]
  public string? LastModifiedBy
  {
    get => _LastModifiedBy;
    set => UpdateField(ref _LastModifiedBy, value, nameof(LastModifiedBy));
  }
  private string? _LastModifiedBy;
  /// <summary>
  ///   The revision number, typically incremented after each save or revision.
  /// </summary>
  [Category("Versioning")]
  [BuiltInProperty("Revision number")]
  public int? Revision
  {
    get => _Revision;
    set => UpdateField(ref _Revision, value, nameof(Revision));
  }
  private int? _Revision;
  /// <summary>
  ///   The date and time when the document was last printed.
  /// </summary>
  [Category("Base")]
  [BuiltInProperty("Last print date")]
  [OpenXmlProperty(nameof(PackageProperties.LastPrinted))]
  public DateTime? LastPrinted
  {
    get => _LastPrinted;
    set => UpdateField(ref _LastPrinted, value, nameof(LastPrinted));
  }
  private DateTime? _LastPrinted;
  /// <summary>
  ///   The date and time when the document was created.
  /// </summary>
  [Category("Base")]
  [BuiltInProperty("Creation date")]
  [OpenXmlProperty(nameof(PackageProperties.Created))]
  public DateTime? Created
  {
    get => _Created;
    set => UpdateField(ref _Created, value, nameof(Created));
  }
  private DateTime? _Created;
  /// <summary>
  ///   The date and time when the document was last modified.
  /// </summary>
  [Category("Base")]
  [BuiltInProperty("Last save time")]
  [OpenXmlProperty(nameof(PackageProperties.Modified))]
  public DateTime? Modified
  {
    get => _Modified;
    set => UpdateField(ref _Modified, value, nameof(Modified));
  }
  private DateTime? _Modified;
  /// <summary>
  ///   A categorization of the document content, such as Resume, Letter, Proposal, or Technical Presentation. May be used for navigation or filtering.
  /// </summary>
  [Category("Base")]
  [BuiltInProperty("Category")]
  [OpenXmlProperty(nameof(PackageProperties.Category))]
  public string? Category
  {
    get => _Category;
    set => UpdateField(ref _Category, value, nameof(Category));
  }
  private string? _Category;
  /// <summary>
  ///   An unambiguous reference to the document within a given context.
  /// </summary>
  [Category("Identification")]
  [OpenXmlProperty(nameof(PackageProperties.Identifier))]
  public string? Identifier
  {
    get => _Identifier;
    set => UpdateField(ref _Identifier, value, nameof(Identifier));
  }
  private string? _Identifier;
  /// <summary>
  ///   The type of content represented, as defined by a specific application.
  /// </summary>
  [Category("Base")]
  [BuiltInProperty("Content type")]
  [OpenXmlProperty(nameof(PackageProperties.ContentType))]
  public string? ContentType
  {
    get => _ContentType;
    set => UpdateField(ref _ContentType, value, nameof(ContentType));
  }
  private string? _ContentType;
  /// <summary>
  ///   The language of the document content, typically encoded per IETF RFC 3066.
  /// </summary>
  [Category("Base")]
  [BuiltInProperty("Language")]
  [OpenXmlProperty(nameof(PackageProperties.Language))]
  public string? Language
  {
    get => _Language;
    set => UpdateField(ref _Language, value, nameof(Language));
  }
  private string? _Language;
  /// <summary>
  ///   The version number of the document, set by the user or application.
  /// </summary>
  [Category("Versioning")]
  [BuiltInProperty("Document version")]
  [OpenXmlProperty(nameof(PackageProperties.Version))]
  public string? Version
  {
    get => _Version;
    set => UpdateField(ref _Version, value, nameof(Version));
  }
  private string? _Version;
  /// <summary>
  ///   The status of the document content, such as Draft, Reviewed, or Final.
  /// </summary>
  [Category("Base")]
  [BuiltInProperty("Content status")]
  [OpenXmlProperty(nameof(PackageProperties.ContentStatus))]
  public string? ContentStatus
  {
    get => _ContentStatus;
    set => UpdateField(ref _ContentStatus, value, nameof(ContentStatus));
  }
  private string? _ContentStatus;
}
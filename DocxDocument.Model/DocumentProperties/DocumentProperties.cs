namespace DocxDocument.Model;

public class DocumentProperties : IDocumentProperties, ICoreDocumentProperties, IContentDocumentProperties, 
  IStatisticDocumentProperties, IExtraDocumentProperties, ICustomDocumentProperties
{
  //const string DateTimeFormat = "yyyy-MM-ddThh:mm:sszzz";

  private static SortedSet<string> BuiltInPropertyNames = new ();
  private Dictionary<object?> Items { get; } = new();
  public CustomDocumentProperties CustomDocumentProperties { get; set; } = new CustomDocumentProperties ();


  static DocumentProperties()
  {
    var coreProperties = typeof(ICoreDocumentProperties).GetProperties();
    foreach (var prop in coreProperties)
      BuiltInPropertyNames.Add(prop.Name);
    var contentProperties = typeof(IContentDocumentProperties).GetProperties();
    foreach (var prop in contentProperties)
      BuiltInPropertyNames.Add(prop.Name);
    var statisticProperties = typeof(IStatisticDocumentProperties).GetProperties();
    foreach (var prop in statisticProperties)
      BuiltInPropertyNames.Add(prop.Name);
    var extraProperties = typeof(IExtraDocumentProperties).GetProperties();
    foreach (var prop in extraProperties)
      BuiltInPropertyNames.Add(prop.Name);
  }

  [XmlIgnore] 
  [JsonIgnore]
  public Document Document { get; set; } = null!;

  #region IDocumentProperties implementation

  public int Count => Items.Count;

  IEnumerator IEnumerable.GetEnumerator()
  {
    return Items.GetEnumerator();
  }

  public IEnumerator<KeyValuePair<string, object?>> GetEnumerator()
  {
    return (Items as IEnumerable<KeyValuePair<string, object?>>).GetEnumerator();
  }

  public object? this[string name] => Items[name];
  public object? Get(string name) => Items.ContainsKey(name) ? Items[name] : null;

  #endregion

  #region ICore Properties implementation

  /// <summary>
  /// The title od the document.
  /// </summary>
  public string? Title
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// The subject of the document.
  /// </summary>
  public string? Subject
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// The category of the document.
  /// </summary>
  public string? Category
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// The type of document represented, generally defined by a specific
  /// use and intended audience. Example values include "Whitepaper",
  /// "Security Bulletin", and "Exam". (This property is distinct from
  /// MIME content types as defined in RFC 2045.) 
  /// </summary>
  public string? ContentType
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// The status of the content. Example values include "Draft",
  /// "Reviewed", and "Final".
  /// </summary>
  public string? ContentStatus
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// The short description of the document.
  /// </summary>
  public string? Description
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// Comma or semicolon delimited list of keywords.
  /// </summary>
  public string? Keywords
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// The author who created the document. Usually name of the person.
  /// </summary>
  public string? Creator
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// The creation date and time.
  /// </summary>
  [XmlElement(IsNullable = true)]
  public DateTime? Created
  {
    get => (DateTime?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// The user who performed the last modification.
  /// </summary>
  public string? LastModifiedBy
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// The date and time of the last modification.
  /// </summary>
  [XmlElement(IsNullable = true)]
  public DateTime? LastModified
  {
    get => (DateTime?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// The date and time of the last printing.
  /// </summary>
  [XmlElement(IsNullable = true)]
  public DateTime? LastPrinted
  {
    get => (DateTime?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// The primary language of the document.
  /// </summary>
  public string? Language
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// A unique identifier.
  /// </summary>
  public string? Identifier
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }


  /// <summary>
  /// The version number.
  /// </summary>
  public string? Version
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary>
  /// The revision number. Modified after each save.
  /// </summary>
  public string? Revision
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  #endregion

  #region IContentDocumentProperties implementation

  /// <summary> 
  /// This element specifies the name of the application that created this document.
  ///</summary> 
  public String? Application
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the version of the application which produced this document.
  /// The content of this element shall be of the form XX.YYYY where X and Y represent numerical values,
  /// or the document shall be considered non-conformant.
  ///</summary> 
  public String? ApplicationVersion
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the name of a company associated with the document.
  ///</summary> 
  public String? Company
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element contains the signature of a digitally signed document.
  /// </summary>
  [Obsolete]
  public byte[]? DigitalSignature
  {
    get => (byte[]?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This metadata element specifies the security level of a document.
  ///</summary> 
  [DefaultValue(0)]
  public DocSecurity? DocumentSecurity
  {
    get => (DocSecurity?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// Heading pairs indicates the grouping of document parts and the number of parts in each group.
  /// These parts are not document parts but conceptual representations of document sections.
  ///</summary> 
  public HeadingPairs? HeadingPairs
  {
    get => (HeadingPairs?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the number of hidden slides in a presentation document.
  ///</summary>
  [DefaultValue(0)]
  public int? HiddenSlides
  {
    get => (int?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the set of hyperlinks that were in this document when last saved.
  ///</summary> 
  public HyperlinkList? HyperlinkList
  {
    get => (HyperlinkList?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the base string used for evaluating relative hyperlinks in this document.
  ///</summary> 
  public String? HyperlinkBase
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies that one or more hyperlinks in this part
  /// were updated exclusively in this part by a producer.
  /// The next producer to open this document shall update the hyperlink relationships
  /// with the new hyperlinks specified in this part.
  ///</summary>
  [DefaultValue(false)]
  public Boolean? HyperlinksChanged
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element indicates whether hyperlinks in a document are up-to-date.
  /// Set this element to TRUE to indicate that hyperlinks are updated.
  /// Set this element to FALSE to indicate that hyperlinks are outdated.
  ///</summary>
  public Boolean? LinksUpToDate
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the name of a supervisor associated with the document.
  ///</summary> 
  public String? Manager
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the intended format for a presentation document.
  /// For example, a presentation intended to be shown on video has PresentationFormat Video.
  ///</summary> 
  public String? PresentationFormat
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element indicates the display mode of the document thumbnail. Set this element to TRUE to enable scaling
  /// of the document thumbnail to the display.Set this element to FALSE to enable cropping of the document
  /// thumbnail to show only sections that fits the display.
  ///</summary> 
  public Boolean? ScaleCrop
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element indicates if this document is currently shared between multiple producers.
  /// If this element is set to TRUE, producers should take care when updating the document.
  ///</summary> 
  public Boolean? SharedDocument
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the name of an external document template containing format and style information used to create the current document.
  ///</summary> 
  public String? Template
  {
    get => (string?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the title of each document. These parts are not document parts but conceptual representations of document sections.
  ///</summary> 
  public Strings? TitlesOfParts
  {
    get => (Strings?)Items._Get();
    set => Items._Set(value);
  }

  #endregion

  #region IStatisticProperties implementation

  /// <summary> 
  /// Total time that a document has been edited. The default time unit is minutes.
  ///</summary> 
  [DefaultValue(0)]
  public int? TotalTime
  {
    get => (int?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the total number of characters in a document.
  ///</summary>
  [DefaultValue(0)]
  public int? Characters
  {
    get => (int?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the last count of the number of characters (including spaces) in this document.
  ///</summary> 
  [DefaultValue(0)]
  public int? CharactersWithSpaces
  {
    get => (int?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the total number of words contained in a document when last saved.
  ///</summary> 
  [DefaultValue(0)]
  public int? Words
  {
    get => (int?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the total number of lines in a document when last saved by a conforming producer if applicable.
  ///</summary> 
  [DefaultValue(0)]
  public int? Lines
  {
    get => (int?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the total number of pages of a document if applicable.
  ///</summary> 
  [DefaultValue(0)]
  public int? Pages
  {
    get => (int?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the total number of paragraphs found in a document if applicable.
  ///</summary> 
  [DefaultValue(0)]
  public int? Paragraphs
  {
    get => (int?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the total number of sound or video clips that are present in the document.
  ///</summary> 
  [DefaultValue(0)]
  public int? MultimediaClips
  {
    get => (int?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the number of slides in a presentation containing notes.
  ///</summary> 
  [DefaultValue(0)]
  public int? Notes
  {
    get => (int?)Items._Get();
    set => Items._Set(value);
  }

  /// <summary> 
  /// This element specifies the total number of slides in a presentation document.
  ///</summary> 
  [DefaultValue(0)]
  public int? Slides
  {
    get => (int?)Items._Get();
    set => Items._Set(value);
  }

  #endregion

  #region IExtraDocumentProperties implementation
  public HexInt? DocumentId
  {
    get => (HexInt?)Items._Get();
    set => Items._Set(value);
  }

  public Guid? PersistentDocumentId
  {
    get => (Guid?)Items._Get();
    set => Items._Set(value);
  }

  public bool? ConflictMode
  {
    get => (bool?)Items._Get();
    set => Items._Set(value);
  }

  public IRsIds? Revisions { get; set;}

  #endregion

  #region ICustomProperties implementation

  int ICustomDocumentProperties.Count => CustomDocumentProperties.Count();

  IEnumerator<ICustomDocumentProperty> IEnumerable<ICustomDocumentProperty>.GetEnumerator()
  {
    return CustomDocumentProperties.GetEnumerator();
  }

  public void Add(ICustomDocumentProperty property)
  {
    CustomDocumentProperties.Add(property);
  }

  public bool Remove(ICustomDocumentProperty property)
  {
    return CustomDocumentProperties.Remove(property);
  }
  #endregion

  public bool IsEmpty()
  {
    return !Items.Any() && !CustomDocumentProperties.Any();
  }
}
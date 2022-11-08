namespace DocxDocument.Model;

public class DocumentProperties : IDocumentProperties, ICoreDocumentProperties, IContentDocumentProperties, 
  IStatisticDocumentProperties, IExtraDocumentProperties, ICustomProperties
{
  //const string DateTimeFormat = "yyyy-MM-ddThh:mm:sszzz";

  private static SortedSet<string> BuiltInPropertyNames = new ();

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

  public List<IDocumentProperty> Items { get; } = new List<IDocumentProperty> { };

  #region IDocumentProperties implementation
  public int Count => Items.Count;

  IEnumerator IEnumerable.GetEnumerator()
  {
    return Items.GetEnumerator();
  }

  public IEnumerator<IDocumentProperty> GetEnumerator()
  {
    return Items.GetEnumerator();
  }

  public IDocumentProperty this[int n] => Items[n];

  public IDocumentProperty this[string name] => Items.FirstOrDefault(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

  public void Add(IDocumentProperty property)
  {
    if (this[property.Name] != null)
      throw new InvalidOperationException($"Document property \"{property.Name}\" already exists");
    Items.Add(property);
  }

  public bool Remove(IDocumentProperty property)
  {
    if (this[property.Name] == null)
      return false;
    Items.Remove(property);
    return true;
  }

  public void Add(string name, PropertyType type, object? value)
  {
    if (this[name] != null)
      throw new InvalidOperationException($"Document property \"{name}\" already exists");
    if (BuiltInPropertyNames.Contains(name, StringComparer.OrdinalIgnoreCase))
      Items.Add(new DocumentProperty { Name = name, Type = type, Value = value });
    else
      Items.Add(new CustomDocumentProperty { Name = name, Type = type, Value = value });
  }

  public bool Remove(string name)
  {
    var property = this[name];
    if (property == null)
      return false;
    Items.Remove(property);
    return true;
  }

  public bool Change(string name, object? value)
  {
    var property = this[name];
    if (property == null)
      return false;
    property.Value = value;
    return true;
  }

  public void Set(string name, PropertyType type, object? value)
  {
    var property = this[name];
    if (property != null)
    {
      if (value == null)
      {
        Remove(property);
      }
      else
      {
        property.Type = type;
        property.Value = value;
      }
    }
    if (value ==null)
      return;
    property = new DocumentProperty { Name = name, Type = type, Value = value };
    Items.Add(property);
  }

  public object? Get(string name)
  {
    var property = this[name];
    if (property != null)
      return property.Value;
    return null;
  }

  #endregion

  #region ICore Properties implementation

  /// <summary>
  /// The title od the document.
  /// </summary>
  public string? Title
  {
    get => (string?)Get("Title");
    set => Set("Title", PropertyType.String, value);
  }

  /// <summary>
  /// The subject of the document.
  /// </summary>
  public string? Subject
  {
    get => (string?)Get("Subject");
    set => Set("Subject", PropertyType.String, value);
  }

  /// <summary>
  /// The category of the document.
  /// </summary>
  public string? Category
  {
    get => (string?)Get("Category");
    set => Set("Category", PropertyType.String, value);
  }

  /// <summary>
  /// The type of document represented, generally defined by a specific
  /// use and intended audience. Example values include "Whitepaper",
  /// "Security Bulletin", and "Exam". (This property is distinct from
  /// MIME content types as defined in RFC 2045.) 
  /// </summary>
  public string? ContentType
  {
    get => (string?)Get("ContentType");
    set => Set("ContentType", PropertyType.String, value);
  }

  /// <summary>
  /// The status of the content. Example values include "Draft",
  /// "Reviewed", and "Final".
  /// </summary>
  public string? ContentStatus
  {
    get => (string?)Get("ContentStatus");
    set => Set("ContentStatus", PropertyType.String, value);
  }

  /// <summary>
  /// The short description of the document.
  /// </summary>
  public string? Description
  {
    get => (string?)Get("Description");
    set => Set("Description", PropertyType.String, value);
  }

  /// <summary>
  /// Comma or semicolon delimited list of keywords.
  /// </summary>
  public string? Keywords
  {
    get => (string?)Get("Keywords");
    set => Set("Keywords", PropertyType.String, value);
  }

  /// <summary>
  /// The author who created the document. Usually name of the person.
  /// </summary>
  public string? Creator
  {
    get => (string?)Get("Creator");
    set => Set("Creator", PropertyType.String, value);
  }

  /// <summary>
  /// The creation date and time.
  /// </summary>
  [XmlElement(IsNullable = true)]
  public DateTime? Created
  {
    get => (DateTime?)Get("Created");
    set => Set("Created", PropertyType.Date, value);
  }

  /// <summary>
  /// The user who performed the last modification.
  /// </summary>
  public string? LastModifiedBy
  {
    get => (string?)Get("LastModifiedBy");
    set => Set("LastModifiedBy", PropertyType.String, value);
  }

  /// <summary>
  /// The date and time of the last modification.
  /// </summary>
  [XmlElement(IsNullable = true)]
  public DateTime? LastModified
  {
    get => (DateTime?)Get("LastModified");
    set => Set("LastModified", PropertyType.Date, value);
  }

  /// <summary>
  /// The date and time of the last printing.
  /// </summary>
  [XmlElement(IsNullable = true)]
  public DateTime? LastPrinted
  {
    get => (DateTime?)Get("LastPrinted");
    set => Set("LastPrinted", PropertyType.Date, value);
  }

  /// <summary>
  /// The primary language of the document.
  /// </summary>
  public string? Language
  {
    get => (string?)Get("Language");
    set => Set("Language", PropertyType.String, value);
  }

  /// <summary>
  /// A unique identifier.
  /// </summary>
  public string? Identifier
  {
    get => (string?)Get("Identifier");
    set => Set("Identifier", PropertyType.String, value);
  }


  /// <summary>
  /// The version number.
  /// </summary>
  public string? Version
  {
    get => (string?)Get("Version");
    set => Set("Version", PropertyType.String, value);
  }

  /// <summary>
  /// The revision number. Modified after each save.
  /// </summary>
  public string? Revision
  {
    get => (string?)Get("Revision");
    set => Set("Revision", PropertyType.String, value);
  }

  #endregion

  #region IContentDocumentProperties implementation

  /// <summary> 
  /// This element specifies the name of the application that created this document.
  ///</summary> 
  public String? Application
  {
    get => (string?)Get("Application");
    set => Set("Application", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the version of the application which produced this document.
  /// The content of this element shall be of the form XX.YYYY where X and Y represent numerical values,
  /// or the document shall be considered non-conformant.
  ///</summary> 
  public String? ApplicationVersion
  {
    get => (string?)Get("ApplicationVersion");
    set => Set("ApplicationVersion", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the name of a company associated with the document.
  ///</summary> 
  public String? Company
  {
    get => (string?)Get("Company");
    set => Set("Company", PropertyType.String, value);
  }

  /// <summary> 
  /// This element contains the signature of a digitally signed document.
  /// </summary>
  [Obsolete]
  public byte[]? DigitalSignature
  {
    get => (byte[]?)Get("DigitalSignature");
    set => Set("DigitalSignature", PropertyType.Object, value);
  }

  /// <summary> 
  /// This metadata element specifies the security level of a document.
  ///</summary> 
  [DefaultValue(0)]
  public DocSecurity? DocumentSecurity
  {
    get => (DocSecurity?)Get("DocumentSecurity");
    set => Set("DocumentSecurity", PropertyType.Object, value);
  }

  /// <summary> 
  /// Heading pairs indicates the grouping of document parts and the number of parts in each group.
  /// These parts are not document parts but conceptual representations of document sections.
  ///</summary> 
  public HeadingPairs? HeadingPairs
  {
    get => (HeadingPairs?)Get("HeadingPairs");
    set => Set("HeadingPairs", PropertyType.Object, value);
  }

  /// <summary> 
  /// This element specifies the number of hidden slides in a presentation document.
  ///</summary>
  [DefaultValue(0)]
  public int? HiddenSlides
  {
    get => (int?)Get("HiddenSlides");
    set => Set("HiddenSlides", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the set of hyperlinks that were in this document when last saved.
  ///</summary> 
  public HyperlinkList? HyperlinkList
  {
    get => (HyperlinkList?)Get("HyperlinkList");
    set => Set("HyperlinkList", PropertyType.Object, value);
  }

  /// <summary> 
  /// This element specifies the base string used for evaluating relative hyperlinks in this document.
  ///</summary> 
  public String? HyperlinkBase
  {
    get => (string?)Get("HyperlinkBase");
    set => Set("HyperlinkBase", PropertyType.String, value);
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
    get => (bool?)Get("ScaleCrop");
    set => Set("ScaleCrop", PropertyType.String, value);
  }

  /// <summary> 
  /// This element indicates whether hyperlinks in a document are up-to-date.
  /// Set this element to TRUE to indicate that hyperlinks are updated.
  /// Set this element to FALSE to indicate that hyperlinks are outdated.
  ///</summary>
  public Boolean? LinksUpToDate
  {
    get => (bool?)Get("LinksUpToDate");
    set => Set("LinksUpToDate", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the name of a supervisor associated with the document.
  ///</summary> 
  public String? Manager
  {
    get => (string?)Get("Manager");
    set => Set("Manager", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the intended format for a presentation document.
  /// For example, a presentation intended to be shown on video has PresentationFormat Video.
  ///</summary> 
  public String? PresentationFormat
  {
    get => (string?)Get("PresentationFormat");
    set => Set("PresentationFormat", PropertyType.String, value);
  }

  /// <summary> 
  /// This element indicates the display mode of the document thumbnail. Set this element to TRUE to enable scaling
  /// of the document thumbnail to the display.Set this element to FALSE to enable cropping of the document
  /// thumbnail to show only sections that fits the display.
  ///</summary> 
  public Boolean? ScaleCrop
  {
    get => (bool?)Get("ScaleCrop");
    set => Set("ScaleCrop", PropertyType.String, value);
  }

  /// <summary> 
  /// This element indicates if this document is currently shared between multiple producers.
  /// If this element is set to TRUE, producers should take care when updating the document.
  ///</summary> 
  public Boolean? SharedDocument
  {
    get => (bool?)Get("SharedDocument");
    set => Set("SharedDocument", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the name of an external document template containing format and style information used to create the current document.
  ///</summary> 
  public String? Template
  {
    get => (string?)Get("Template");
    set => Set("Template", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the title of each document. These parts are not document parts but conceptual representations of document sections.
  ///</summary> 
  public Strings? TitlesOfParts
  {
    get => (Strings?)Get("TitlesOfParts");
    set => Set("TitlesOfParts", PropertyType.Object, value);
  }

  #endregion

  #region IStatisticProperties implementation

  /// <summary> 
  /// Total time that a document has been edited. The default time unit is minutes.
  ///</summary> 
  [DefaultValue(0)]
  public int? TotalTime
  {
    get => (int?)Get("TotalTime");
    set => Set("TotalTime", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the total number of characters in a document.
  ///</summary>
  [DefaultValue(0)]
  public int? Characters
  {
    get => (int?)Get("Characters");
    set => Set("Characters", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the last count of the number of characters (including spaces) in this document.
  ///</summary> 
  [DefaultValue(0)]
  public int? CharactersWithSpaces
  {
    get => (int?)Get("CharactersWithSpaces");
    set => Set("CharactersWithSpaces", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the total number of words contained in a document when last saved.
  ///</summary> 
  [DefaultValue(0)]
  public int? Words
  {
    get => (int?)Get("Words");
    set => Set("Words", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the total number of lines in a document when last saved by a conforming producer if applicable.
  ///</summary> 
  [DefaultValue(0)]
  public int? Lines
  {
    get => (int?)Get("Lines");
    set => Set("Lines", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the total number of pages of a document if applicable.
  ///</summary> 
  [DefaultValue(0)]
  public int? Pages
  {
    get => (int?)Get("Pages");
    set => Set("Pages", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the total number of paragraphs found in a document if applicable.
  ///</summary> 
  [DefaultValue(0)]
  public int? Paragraphs
  {
    get => (int?)Get("Paragraphs");
    set => Set("Paragraphs", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the total number of sound or video clips that are present in the document.
  ///</summary> 
  [DefaultValue(0)]
  public int? MultimediaClips
  {
    get => (int?)Get("MultimediaClips");
    set => Set("MultimediaClips", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the number of slides in a presentation containing notes.
  ///</summary> 
  [DefaultValue(0)]
  public int? Notes
  {
    get => (int?)Get("Notes");
    set => Set("Notes", PropertyType.String, value);
  }

  /// <summary> 
  /// This element specifies the total number of slides in a presentation document.
  ///</summary> 
  [DefaultValue(0)]
  public int? Slides
  {
    get => (int?)Get("Slides");
    set => Set("Slides", PropertyType.String, value);
  }

  #endregion

  #region IExtraDocumentProperties implementation
  public HexInt? DocumentId
  {
    get => (HexInt?)Get("DocumentId");
    set => Set("DocumentId", PropertyType.String, value);
  }

  public Guid? PersistentDocumentId
  {
    get => (Guid?)Get("PersistentDocumentId");
    set => Set("PersistentDocumentId", PropertyType.String, value);
  }

  public bool? ConflictMode
  {
    get => (bool?)Get("ConflictMode");
    set => Set("ConflictMode", PropertyType.String, value);
  }

  public IRsIds? RsIds { get; set;}

  #endregion

  #region ICustomProperties implementation

  int ICustomProperties.Count => Items.OfType<CustomDocumentProperty>().Count();

  IEnumerator<ICustomDocumentProperty> IEnumerable<ICustomDocumentProperty>.GetEnumerator()
  {
    return Items.OfType<ICustomDocumentProperty>().GetEnumerator();
  }

  public void Add(ICustomDocumentProperty property)
  {
    Items.Add(property);
  }

  public bool Remove(ICustomDocumentProperty property)
  {
    return Items.Remove(property);
  }
  #endregion

  public bool IsEmpty()
  {
    return !Items.Any();
  }
}
namespace DocumentModel;
#pragma warning disable OOXML0001
/// <summary>
///   Collection of core properties, which represents document properties defined in Dublin Core standard
/// and Open Packaging Conventions
/// </summary>
[OpenXmlType(typeof(PackageProperties))]
[DataContract]
[XmlRoot("CoreProperties", Namespace = "DocumentModel")]
public partial class CoreProperties : BaseBuiltInProperties
{
  private PackageProperties? _PackageProperties;

  /// <summary>
  /// Default constructor.
  /// </summary>
  public CoreProperties() : base(KnownProperties)
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name = "document">Wordprocessing document model</param>
  public CoreProperties(Wordprocessing.Document document) : this()
  {
    SetParent(document);
    if (document.WordprocessingDocument != null)
      AttachAndLoad(document.WordprocessingDocument);
  }

  /// <summary>
  /// Retrieves the Open XML element that represents the updatable package properties for the current instance.
  /// </summary>
  /// <returns>An object representing the updatable Open XML package properties, or <see langword="null"/> if no properties are
  /// available.</returns>
  public override object? GetUpdatableObject()
  {
    if (WordprocessingDocument != null)
      return WordprocessingDocument.GetPackageProperties();
    return null;
  }

  /// <summary>
  ///   Assigns the wrapped OpenXml element instance.
  /// </summary>
  /// <param name = "element">The OpenXml element to assign.</param>
  public new void SetUpdatableObject(object? element)
  {
    if (element == null)
      _PackageProperties = null;
    else if (element is PackageProperties packageProperties)
      _PackageProperties = packageProperties;
    else
      throw new ArgumentException($"Expected an element of type {typeof(PackageProperties).FullName}, but received {element.GetType().FullName}.");
  }

  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument.
  /// Data is loaded from the wordprocessingDocument's CoreProperties part.
  /// </summary>
  /// <param name = "wordprocessingDocument">Document to attach to.</param>
  public sealed override void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    var packageProperties = wordprocessingDocument.GetCoreProperties(false);
    if (packageProperties != null)
    {
      SetUpdatableObject(packageProperties);
      LoadData(packageProperties);
    }
  }

  /// <summary>
  /// Override of UpdateData that updates the attached OpenXmlElement with current data. 
  /// </summary>
  public override bool UpdateData()
  {
    var updatableObject = GetUpdatableObject();
    if (updatableObject != null)
    {
      UpdateData(updatableObject);
      return true;
    }
    return false;
  }

  /// <summary>
  /// Populates the properties of the current instance with values from the specified Open XML element.
  /// </summary>
  /// <remarks>This method matches properties by name between the Open XML element and the current instance.
  /// Only writable properties are set. Type conversion is performed if the property types do not match
  /// exactly.</remarks>
  /// <param name = "openXmlObject">The Open XML element containing property values to load. Must be an instance of the expected Open XML type.</param>
  public override bool LoadData(object openXmlObject)
  {
    SetIsLoading(true);
    var currentType = GetType();
    var openXmlType = typeof(PackageProperties);
    foreach (var openXmlProperty in openXmlType.GetOpenXmlProperties())
    {
      var modelProperty = currentType.GetProperty(openXmlProperty.Name);
      if (modelProperty != null && modelProperty.CanWrite)
      {
        var openXmlValue = openXmlProperty.GetValue(openXmlObject);
        if (!modelProperty.PropertyType.IsInstanceOfType(openXmlValue))
          openXmlValue = OpenXmlModelConverter.ConvertTo(openXmlValue, modelProperty.PropertyType.GetNotNullableType());
        modelProperty.SetValue(this, openXmlValue);
      }
    }
    SetIsLoading(false);
    return true;
  }

  /// <summary>
  /// Updates the specified Open XML element with the current property values of this instance.
  /// </summary>
  /// <remarks>This method maps the public instance properties of the current object to properties of the Open
  /// XML element with matching names. Only properties that exist and are writable on the Open XML element are updated.
  /// Property values are converted to the appropriate Open XML types as needed.</remarks>
  /// <param name = "openXmlObject">The Open XML element to update. Must be an instance of the expected Open XML type that supports writable
  /// properties corresponding to this model.</param>
  public override bool UpdateData(object openXmlObject)
  {
    var modelType = GetType();
    var openXmlType = typeof(PackageProperties);
    foreach (var modelProperty in modelType.GetModelProperties())
    {
      var openXmlProperty = openXmlType.GetProperty(modelProperty.Name);
      if (openXmlProperty != null && openXmlProperty.CanWrite)
      {
        var modelValue = modelProperty.GetValue(this);
        if (!openXmlProperty.PropertyType.IsInstanceOfType(modelValue))
          modelValue = OpenXmlModelConverter.ConvertTo(modelValue, openXmlProperty.PropertyType);
        openXmlProperty.SetValue(openXmlObject, modelValue);
      }
    }
    return true; 
  }

  /// <summary>
  /// Updates the corresponding Open XML property with the current value of the specified model property.
  /// </summary>
  /// <remarks>If the property value is not directly compatible with the Open XML property type, it will be
  /// converted before assignment. No action is taken if the specified property does not exist or cannot be
  /// updated.</remarks>
  /// <param name = "propertyName">The name of the model property whose value will be synchronized to the Open XML property. Must correspond to a
  /// property defined on this instance.</param>
  public override void UpdatePropertyData(string propertyName)
  {
    var openXmlElement = GetUpdatableElement();
    if (openXmlElement == null)
      return;
    var modelProperty = this.GetType().GetProperty(propertyName);
    if (modelProperty == null)
      return;
    var openXmlType = typeof(PackageProperties);
    var openXmlProperty = openXmlType.GetProperty(modelProperty.Name);
    if (openXmlProperty == null)
      return;
    var modelValue = modelProperty.GetValue(this);
    if (!openXmlProperty.PropertyType.IsInstanceOfType(modelValue))
      modelValue = OpenXmlModelConverter.ConvertTo(modelValue, openXmlProperty.PropertyType);
    openXmlProperty.SetValue(openXmlElement, modelValue);
    if (WordprocessingDocument != null)
    {
      var coreProperties = WordprocessingDocument.GetCoreProperties(true);
    }
  }

  /// <summary>
  /// Copies data from the specified CoreProperties instance to this instance.
  /// </summary>
  /// <param name = "properties">CoreProperties instance containing the model property value.</param>
  public void CopyFrom(CoreProperties properties)
  {
    var modelType = properties.GetType();
    foreach (var modelProperty in modelType.GetModelProperties())
    {
      var value = modelProperty.GetValue(properties);
      modelProperty.SetValue(this, value);
    }

    var updatableElement = GetUpdatableElement();
    if (updatableElement != null)
      UpdateData(updatableElement);
  }

  /// <summary>
  ///   Provides a registry of known core property definitions for this type.
  /// </summary>
  public static KnownProperties KnownProperties => _KnownProperties ??= new KnownProperties(typeof(CoreProperties));

  private static KnownProperties? _KnownProperties;

  /// <summary>
  ///   The main title of the document, typically displayed in the title bar or metadata.
  /// </summary>
  [MultiCategory("Base")]
  [BuiltInProperty("Title")]
  [OpenXmlProperty(nameof(CoreProperties.Title))]
  public string? Title 
  { 
    get => _Title ??= GetProperty<string?>(nameof(Title));
    set => UpdateField(ref _Title, value, nameof(Title));
  }
  private string? _Title;

  /// <summary>
  ///   The subject or topic of the document's content.
  /// </summary>
  [MultiCategory("Base")]
  [BuiltInProperty("Subject")]
  [OpenXmlProperty(nameof(CoreProperties.Subject))]
  public string? Subject
  {
    get => _Subject ??= GetProperty<string?>(nameof(Subject));
    set => UpdateField(ref _Subject, value, nameof(Subject));
  }
  private string? _Subject;

  /// <summary>
  ///   The person or entity primarily responsible for creating the document content.
  /// </summary>
  [MultiCategory("Base")]
  [BuiltInProperty("Author")]
  [OpenXmlProperty(nameof(CoreProperties.Creator))]
  public string? Creator
  {
    get => _Creator ??= GetProperty<string?>(nameof(Creator));
    set => UpdateField(ref _Creator, value, nameof(Creator));
  }
  private string? _Creator;

  /// <summary>
  ///   A delimited set of keywords to support searching and indexing. Typically a list of terms not available elsewhere in the properties. May use xml:lang for language identification and allow mixed content.
  /// </summary>
  [MultiCategory("Base")]
  [BuiltInProperty("Keywords")]
  [OpenXmlProperty(nameof(CoreProperties.Keywords))]
  public string? Keywords
  {
    get => _Keywords ??= GetProperty<string?>(nameof(Keywords));
    set => UpdateField(ref _Keywords, value, nameof(Keywords));
  }
  private string? _Keywords;

  /// <summary>
  ///   An explanation or abstract of the document content. May include a summary, table of contents, or free-text account of the content.
  /// </summary>
  [MultiCategory("Base")]
  [BuiltInProperty("Comments")]
  [OpenXmlProperty(nameof(CoreProperties.Description))]
  public string? Description
  {
    get => _Description ??= GetProperty<string?>(nameof(Description));
    set => UpdateField(ref _Description, value, nameof(Description));
  }
  private string? _Description;

  /// <summary>
  ///   The user who last modified the document. Identification is environment-specific (e.g., name, email, or employee ID).
  /// </summary>
  [MultiCategory("Base")]
  [BuiltInProperty("Last author")]
  [OpenXmlProperty(nameof(PackageProperties.LastModifiedBy))]
  public string? LastModifiedBy
  {
    get => _LastModifiedBy ??= GetProperty<string?>(nameof(LastModifiedBy));
    set => UpdateField(ref _LastModifiedBy, value, nameof(LastModifiedBy));
  }
  private string? _LastModifiedBy;

  /// <summary>
  ///   The revision number, typically incremented after each save or revision.
  /// </summary>
  [MultiCategory("Versioning")]
  [BuiltInProperty("Revision number")]
  public int? Revision
  {
    get => _Revision ??= GetProperty<int?>(nameof(Revision));
    set => UpdateField(ref _Revision, value, nameof(Revision));
  }
  private int? _Revision;

  /// <summary>
  ///   The date and time when the document was last printed.
  /// </summary>
  [MultiCategory("Base")]
  [BuiltInProperty("Last print date")]
  [OpenXmlProperty(nameof(PackageProperties.LastPrinted))]
  public DateTime? LastPrinted
  {
    get => _LastPrinted ??= GetProperty<DateTime?>(nameof(LastPrinted));
    set => UpdateField(ref _LastPrinted, value, nameof(LastPrinted));
  }
  private DateTime? _LastPrinted;

  /// <summary>
  ///   The date and time when the document was created.
  /// </summary>
  [MultiCategory("Base")]
  [BuiltInProperty("Creation date")]
  [OpenXmlProperty(nameof(PackageProperties.Created))]
  public DateTime? Created
  {
    get => _Created ??= GetProperty<DateTime?>(nameof(Created));
    set => UpdateField(ref _Created, value, nameof(Created));
  }
  private DateTime? _Created;

  /// <summary>
  ///   The date and time when the document was last modified.
  /// </summary>
  [MultiCategory("Base")]
  [BuiltInProperty("Last save time")]
  [OpenXmlProperty(nameof(PackageProperties.Modified))]
  public DateTime? Modified
  {
    get => _Modified ??= GetProperty<DateTime?>(nameof(Modified));
    set => UpdateField(ref _Modified, value, nameof(Modified));
  }
  private DateTime? _Modified;

  /// <summary>
  ///   A categorization of the document content, such as Resume, Letter, Proposal, or Technical Presentation. May be used for navigation or filtering.
  /// </summary>
  [MultiCategory("Base")]
  [BuiltInProperty("Category")]
  [OpenXmlProperty(nameof(PackageProperties.Category))]
  public string? Category
  {
    get => _Category ??= GetProperty<string?>(nameof(Category));
    set => UpdateField(ref _Category, value, nameof(Category));
  }
  private string? _Category;

  /// <summary>
  ///   An unambiguous reference to the document within a given context.
  /// </summary>
  [MultiCategory("Identification")]
  [BuiltInProperty("Identifier")]
  [OpenXmlProperty(nameof(PackageProperties.Identifier))]
  public string? Identifier
  {
    get => _Identifier ??= GetProperty<string?>(nameof(Identifier));
    set => UpdateField(ref _Identifier, value, nameof(Identifier));
  }
  private string? _Identifier;

  /// <summary>
  ///   The type of content represented, as defined by a specific application.
  /// </summary>
  [MultiCategory("Base")]
  [BuiltInProperty("Content type")]
  [OpenXmlProperty(nameof(PackageProperties.ContentType))]
  public string? ContentType
  {
    get => _ContentType ??= GetProperty<string?>(nameof(ContentType));
    set => UpdateField(ref _ContentType, value, nameof(ContentType));
  }
  private string? _ContentType;

  /// <summary>
  ///   The language of the document content, typically encoded per IETF RFC 3066.
  /// </summary>
  [MultiCategory("Base")]
  [BuiltInProperty("Language")]
  [OpenXmlProperty(nameof(PackageProperties.Language))]
  public string? Language
  {
    get => _Language ??= GetProperty<string?>(nameof(Language));
    set => UpdateField(ref _Language, value, nameof(Language));
  }
  private string? _Language;

  /// <summary>
  ///   The version number of the document, set by the user or application.
  /// </summary>
  [MultiCategory("Versioning")]
  [BuiltInProperty("Document version")]
  [OpenXmlProperty(nameof(PackageProperties.Version))]
  public string? Version
  {
    get => _Version ??= GetProperty<string?>(nameof(Version));
    set => UpdateField(ref _Version, value, nameof(Version));
  }
  private string? _Version;

  /// <summary>
  ///   The status of the document content, such as Draft, Reviewed, or Final.
  /// </summary>
  [MultiCategory("Base")]
  [BuiltInProperty("Content status")]
  [OpenXmlProperty(nameof(PackageProperties.ContentStatus))]
  public string? ContentStatus
  {
    get => _ContentStatus ??= GetProperty<string?>(nameof(ContentStatus));
    set => UpdateField(ref _ContentStatus, value, nameof(ContentStatus));
  }
  private string? _ContentStatus;
}
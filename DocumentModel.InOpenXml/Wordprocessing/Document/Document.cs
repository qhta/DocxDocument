
using DocumentModel.XmlSerialization;

using Qhta.OpenXmlTools;

namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a WordprocessingML document, providing access to its settings, properties, and lifecycle management.
///   Enables loading, saving, and manipulating document-level metadata, content, and configuration for Open XML word processing documents.
/// </summary>
[XmlRoot("Document", Namespace = "DocumentModel.Wordprocessing")]
public partial class Document : ModelElement, IWordprocessingDocumentAware, IDisposable, IModifiable
{
  /// <summary>
  ///  Default constructor - needed for serialization.
  /// </summary>
  public Document()
  {
  }

  /// <summary>
  /// Creates a new instance of the <see cref = "Document"/> class and opens a WordprocessingML document from the specified file path.
  /// </summary>
  /// <param name = "filePath">The file path of the WordprocessingML document to open.</param>
  /// <param name = "mode">The file mode to open. Create, Open, and OpenOrCreate are recognized. Default is OpenOrCreate</param>
  /// <param name = "access">The file access mode to open. Read, Write, and ReadWrite are recognized. Default is ReadWrite</param>
  public static Document Open(string filePath, FileMode mode = FileMode.OpenOrCreate, FileAccess access = FileAccess.ReadWrite)
  {
    var result = new Document();
    if (mode == FileMode.CreateNew)
    {
      if (File.Exists(filePath))
        File.Delete(filePath);
      result.CreateDocument(filePath);
    }
    else if (mode == FileMode.Create || mode == FileMode.OpenOrCreate && !File.Exists(filePath))
      result.CreateDocument(filePath);
    else if (mode == FileMode.Open || mode == FileMode.OpenOrCreate)
      result.OpenDocument(filePath, access is FileAccess.ReadWrite or FileAccess.Write);
    if (access != FileAccess.ReadWrite && access != FileAccess.Write && access != FileAccess.Read)
      result.IsEditable = false;
    result._IsNotificationEnabled = true;
    return result;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref = "Document"/> class and attaches it to the specified Open XML word processing document.
  /// </summary>
  /// <param name = "wordprocessingDocument">The Open XML word processing document to attach to.</param>
  public Document(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    _WordprocessingDocument = wordprocessingDocument;
    _IsNotificationEnabled = true;
  }

  /// <summary>
  ///   The underlying Open XML word processing document associated with this instance.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public DXPP.WordprocessingDocument? WordprocessingDocument
  {
    [DebuggerStepThrough]
    get => _WordprocessingDocument; 
  }
  private DXPP.WordprocessingDocument? _WordprocessingDocument;

  /// <summary>
  /// Implements the IWordprocessingDocumentAware interface to attach this instance to the specified word processing document.
  /// </summary>
  /// <param name="wordprocessingDocument"></param>
  public void Attach(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    AttachAndLoad(wordprocessingDocument);
  }

  /// <summary>
  ///   Attaches this instance to the specified word processing document and loads data from its package properties and settings.
  /// </summary>
  /// <param name = "wordprocessingDocument">The word processing document to attach and load from.</param>
  public void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    _IsNotificationEnabled = false;
    _WordprocessingDocument = wordprocessingDocument;
    //wordprocessingDocument.GetPackageProperties();
    //CoreProperties.AttachAndLoad(wordprocessingDocument);
    _IsNotificationEnabled = null;
  }

  /// <summary>
  ///   Attaches this instance to the specified word processing document and updates its package properties and settings with current data.
  /// </summary>
  /// <param name = "wordprocessingDocument">The word processing document to attach and update.</param>
  public void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    _WordprocessingDocument = wordprocessingDocument;
    //CoreProperties.AttachAndUpdate(wordprocessingDocument);
  }

  /// <summary>
  ///   Detaches the document and all associated property objects from their underlying data sources, releasing any held resources.
  ///   After calling this method, the document and its property objects are no longer connected to their original data.
  ///   Further operations on these objects may not be valid until they are reattached or reinitialized.
  /// </summary>
  public void Detach()
  {
    _WordprocessingDocument = null;
    _CoreProperties?.Detach();
    _ContentProperties?.Detach();
    _StatisticProperties?.Detach();
    _CustomProperties?.Detach();
    _DocumentSettings?.Detach();
  }

  /// <summary>
  ///   Creates a new WordprocessingML document at the specified file path.
  /// </summary>
  /// <param name = "filePath">The file path for the new document.</param>
  /// <returns>A new <see cref = "Document"/> instance representing the created file.</returns>
  public void CreateDocument(string filePath)
  {
    OpenDocument(filePath);
  }

  /// <summary>
  ///   Opens a WordprocessingML document from the specified file path.
  /// </summary>
  /// <param name = "filePath">The full path to the file to open. The file must exist and be a valid Word document.</param>
  /// <param name = "editable">Determines if the document should be opened in editable mode.</param>
  /// <returns>A <see cref = "Document"/>The instance representing the opened file.</returns>
  public void OpenDocument(string filePath, bool editable = true)
  {
    _IsNotificationEnabled = false;
    Filename = filePath;
    IsEditable = editable;
    var wordprocessingDocument = (!File.Exists(filePath)) ? WordprocessingHelper.CreateWordDocument(filePath) : WordprocessingHelper.OpenWordDocument(Filename, editable);
    AttachAndLoad(wordprocessingDocument);
    _IsNotificationEnabled = true;
  }

  /// <summary>
  ///  Serializes the current state of the document, including its properties and settings, to an XML string representation.
  /// </summary>
  /// <returns>An XML string representing the current state of the document.</returns>
  public string GetModelXml()
  {
    return XmlSerializationHelper.SerializeObjectToXml(this);
  }

  /// <summary>
  /// Filename of the document, which can be used for display purposes or to track the source of the document.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public string? Filename
  {
    get => _Filename;
    set
    {
      if (_Filename != value)
      {
        _Filename = value;
        NotifyPropertyChanged(nameof(Filename));
      }
    }
  }
  private string? _Filename;

  /// <summary>
  /// Checks if the document is currently opened in an editable mode,
  /// which determines whether changes can be made to the document's content and properties.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public bool IsEditable
  {
    get => _IsEditable;
    set
    {
      if (_IsEditable != value)
      {
        _IsEditable = value;
        NotifyPropertyChanged(nameof(IsEditable));
      }
    }
  }
  private bool _IsEditable;

  /// <summary>
  /// Notifies listeners that the value of a property has changed.
  /// </summary>
  /// <remarks>Call this method after updating a property value to ensure that any data bindings or listeners
  /// are notified of the change. Property change notifications are only sent if notifications are currently
  /// enabled.</remarks>
  /// <param name = "propertyName">The name of the property that has changed. This value is used to identify the property in the change notification.</param>
  public override void NotifyPropertyChanged(string propertyName)
  {
    if (IsNotificationEnabled)
      OnPropertyChanged(propertyName);
  }

  /// <summary>
  /// Saves the current state of the document to its underlying data source, such as a file or stream.
  /// </summary>
  public void Save()
  {
    if (Filename == null)
      return;
    if (!IsEditable)
      return;
    if (WordprocessingDocument == null)
      throw new InvalidOperationException("Document is not attached.");
    if (WordprocessingDocument.CanSave)
      WordprocessingDocument.Save();
    SetIsModified(false);
  }

  /// <summary>
  /// Closes a document and detached WordprocessingDocument. Disposes the underlying Open XML document and detaches all property objects.
  /// </summary>
  public void Close()
  {
    if (WordprocessingDocument != null)
    {
      var customPropertiesPart = WordprocessingDocument.CustomFilePropertiesPart;
      if (customPropertiesPart != null)
      {
        var customProperties = customPropertiesPart.Properties;
        if (customProperties != null && !customProperties.HasChildren)
        {
          WordprocessingDocument.DeletePart(customPropertiesPart);
        }
      }
      WordprocessingDocument.Dispose();
    }
    Detach();
    NotifyPropertyChanged(nameof(WordprocessingDocument));
  }

  /// <summary>
  ///   Releases resources used by the document and notifies property change.
  ///   Disposes the underlying Open XML document and detaches all property objects.
  /// </summary>
  public void Dispose()
  {
    Close();
  }

  /// <summary>
  ///   Returns the updatable Open XML element associated with this document (the underlying <see cref = "DXPP.WordprocessingDocument"/>).
  /// </summary>
  /// <returns>The updatable Open XML element for this document.</returns>
  public override object? GetUpdatableElement()
  {
    return WordprocessingDocument;
  }

  /// <summary>
  ///   Core document properties such as title, author, and subject.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public CoreProperties CoreProperties
  {
    get => _CoreProperties ??= new CoreProperties(this);
    set => CoreProperties.CopyFrom(value);
  }
  private CoreProperties? _CoreProperties;

  /// <summary>
  ///   Content-specific document properties, such as content type and structure.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public ContentProperties ContentProperties
  {
    get => _ContentProperties ??= new ContentProperties(this);
    set => ContentProperties.CopyFrom(value);
  }
  private ContentProperties? _ContentProperties;

  /// <summary>
  ///   Statistical document properties such as word count and page count.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public StatisticProperties StatisticProperties
  {
    get => _StatisticProperties ??= new StatisticProperties(this);
    set => StatisticProperties.CopyFrom(value);
  }
  private StatisticProperties? _StatisticProperties;

  /// <summary>
  ///   Custom document properties, allowing storage of user-defined metadata.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public CustomProperties CustomProperties
  {
    get => _CustomProperties ??= new CustomProperties(this);
    set => CustomProperties.CopyFrom(value);
  }
  private CustomProperties? _CustomProperties;


  /// <summary>
  /// Gets the built-in properties of the document.
  /// This property allows access to all built-in document properties through a single collection interface.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public BuiltInProperties BuiltInProperties
  {
    get => _builtInProperties ??= new BuiltInProperties(this);
    set => UpdateField(ref _builtInProperties, value, nameof(BuiltInProperties));
  }
  private BuiltInProperties? _builtInProperties;


  /// <summary>
  /// Gets the document properties of the document.
  /// This property allows access to all document properties through a single collection interface.
  /// </summary>
  public DocumentProperties DocumentProperties
  {
    get => _DocumentProperties ??= new DocumentProperties(this);
    set => UpdateField(ref _DocumentProperties, value, nameof(DocumentProperties));
  }
  private DocumentProperties? _DocumentProperties;

  /// <summary>
  ///   Document-level settings, including compatibility, protection, and view options.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public DocumentSettings DocumentSettings
  {
    get => _DocumentSettings ??= new DocumentSettings(this);
    set => DocumentSettings.CopyFrom(value);
  }
  private DocumentSettings? _DocumentSettings;

  /// <summary>
  /// Collection of all known document properties.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public KnownProperties KnownProperties
  {
    get
    {
      if (_KnownProperties == null)
      {
        _KnownProperties = new KnownProperties();
        foreach (var propModel in CoreProperties.KnownProperties.Values)
          _KnownProperties.Add(new PropertyModel(propModel.PropertyInfo) { Component = CoreProperties });
        //foreach (var propModel in ContentProperties.KnownProperties.Values)
        //  _KnownProperties.Add(new PropertyModel(propModel.PropertyInfo) { Component = ContentProperties });
        //foreach (var propModel in StatisticProperties.KnownProperties.Values)
        //  _KnownProperties.Add(new PropertyModel(propModel.PropertyInfo) { Component = StatisticProperties });
        //foreach (var propModel in DocumentSettings.KnownProperties.Values)
        //  _KnownProperties.Add(new PropertyModel(propModel.PropertyInfo) { Component = DocumentSettings });
        //foreach (var propModel in CompatibilitySettings.KnownProperties.Values)
        //  _KnownProperties.Add(new PropertyModel(propModel.PropertyInfo) { Component = CompatibilitySettings });
        //_KnownProperties.AddRange(CompatibilitySettings.KnownProperties);
        //_KnownProperties.AddRange(MailMerge.KnownProperties);
        //_KnownProperties.AddRange(DMM.MathProperties.KnownProperties);
      }

      return _KnownProperties!;
    }

    set => UpdateField(ref _KnownProperties, value, nameof(KnownProperties));
  }
  private KnownProperties? _KnownProperties;

  /// <summary>
  ///   Collection of revision IDs for tracked changes in the document.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public Rsids Rsids
  {
    get => _Rsids ??= new Rsids(this);
    set => Rsids.CopyFrom(value);
  }
  private Rsids? _Rsids;

  /// <summary>
  ///   Collection of DocumentVariables used in the document.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public DocumentVariables DocumentVariables
  {
    get => _DocumentVariables ??= new DocumentVariables(this);
    set => DocumentVariables.CopyFrom(value);
  }
  private DocumentVariables? _DocumentVariables;

  /// <summary>
  ///   Font table for the document, providing access to font definitions used within the document.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public FontTable FontTable
  {
    get => _FontTable ??= new FontTable(this);
    set => FontTable.CopyFrom(value);
  }
  private FontTable? _FontTable;


  /// <summary>
  ///   Theme colors and fonts.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public DMD.Theme Theme
  {
    get => _Theme ??= new DMD.Theme(this);
    set => UpdateField(ref _Theme, value, nameof(Theme));
  }
  private DMD.Theme? _Theme;

  /// <summary>
  ///   Styles for the document, providing access to style definitions used within the document.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public Styles Styles
  {
    get => _Styles ??= new Styles(this);
    set => Styles.CopyFrom(value);
  }
  private Styles? _Styles;

  /// <summary>
  /// Numbering definitions for the document, providing access to numbering formats and instances used within the document.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public Numbering Numbering
  {
    get => _Numbering ??= new Numbering(this);
    set => Numbering.CopyFrom(value);
  }
  private Numbering? _Numbering;

  /// <summary>
  ///   Main document body.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public Body Body
  {
    get => _Body ??= new Body(this, WordprocessingDocument?.GetBody());
    set => UpdateField(ref _Body, value, nameof(Body));
  }
  private Body? _Body;
}
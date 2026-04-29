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
  public Document(string filePath, FileMode mode = FileMode.OpenOrCreate, FileAccess access = FileAccess.ReadWrite)
  {
    if (mode == FileMode.CreateNew)
    {
      if (File.Exists(filePath))
        File.Delete(filePath);
      CreateDocument(filePath);
    }
    else if (mode == FileMode.Create || mode == FileMode.OpenOrCreate && !File.Exists(filePath))
      CreateDocument(filePath);
    else if (mode == FileMode.Open || mode == FileMode.OpenOrCreate)
      OpenDocument(filePath, access is FileAccess.ReadWrite or FileAccess.Write);
    if (access != FileAccess.ReadWrite && access != FileAccess.Write && access != FileAccess.Read)
      IsEditable = false;
    _IsNotificationEnabled = true;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref = "Document"/> class and attaches it to the specified Open XML word processing document.
  /// </summary>
  /// <param name = "wordprocessingDocument">The Open XML word processing document to attach to.</param>
  public Document(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
    _IsNotificationEnabled = true;
  }

  /// <summary>
  ///   The underlying Open XML word processing document associated with this instance.
  /// </summary>
  public DXPP.WordprocessingDocument? WordprocessingDocument
  {
    [DebuggerStepThrough]
    get => _WordprocessingDocument; set => UpdateField(ref _WordprocessingDocument, value, nameof(WordprocessingDocument));
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
    WordprocessingDocument = wordprocessingDocument;
    wordprocessingDocument.GetPackageProperties();
    CoreProperties.AttachAndLoad(wordprocessingDocument);
    ContentProperties.AttachAndLoad(wordprocessingDocument);
    StatisticProperties.AttachAndLoad(wordprocessingDocument);
    CustomProperties?.AttachAndLoad(wordprocessingDocument);
    _IsNotificationEnabled = null;
  }

  /// <summary>
  ///   Attaches this instance to the specified word processing document and updates its package properties and settings with current data.
  /// </summary>
  /// <param name = "wordprocessingDocument">The word processing document to attach and update.</param>
  public void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
    CoreProperties.AttachAndUpdate(wordprocessingDocument);
    ContentProperties.AttachAndUpdate(wordprocessingDocument);
    StatisticProperties.AttachAndUpdate(wordprocessingDocument);
    CustomProperties?.AttachAndUpdate(wordprocessingDocument);
  }

  /// <summary>
  ///   Detaches the document and all associated property objects from their underlying data sources, releasing any held resources.
  ///   After calling this method, the document and its property objects are no longer connected to their original data.
  ///   Further operations on these objects may not be valid until they are reattached or reinitialized.
  /// </summary>
  public void Detach()
  {
    WordprocessingDocument = null;
    CoreProperties.Detach();
    ContentProperties.Detach();
    StatisticProperties.Detach();
    CustomProperties?.Detach();
    DocumentSettings?.Detach();
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
  /// Filename of the document, which can be used for display purposes or to track the source of the document.
  /// </summary>
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
  ///   Releases resources used by the document and notifies property change.
  ///   Disposes the underlying Open XML document and detaches all property objects.
  /// </summary>
  public void Dispose()
  {
    if (WordprocessingDocument != null)
      WordprocessingDocument.Dispose();
    Detach();
    NotifyPropertyChanged(nameof(WordprocessingDocument));
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
  [NotMapped]
  public CoreProperties CoreProperties
  {
    get => _CoreProperties ??= new CoreProperties(this);
    set
    {
      if (!Equals(CoreProperties, value))
        CoreProperties.CopyFrom(value);
    }
  }
  private CoreProperties? _CoreProperties;

  /// <summary>
  ///   Content-specific document properties, such as content type and structure.
  /// </summary>
  [NotMapped]
  public ContentProperties ContentProperties
  {
    get
    {
      if (_ContentProperties == null)
        _ContentProperties = new ContentProperties(this);
      return _ContentProperties!;
    }

    set => UpdateField(ref _ContentProperties!, value, nameof(ContentProperties));
  }
  private ContentProperties? _ContentProperties;

  /// <summary>
  ///   Statistical document properties such as word count and page count.
  /// </summary>
  [NotMapped]
  public StatisticProperties StatisticProperties
  {
    get
    {
      if (_StatisticProperties == null)
        _StatisticProperties = new StatisticProperties(this);
      return _StatisticProperties!;
    }

    set => UpdateField(ref _StatisticProperties!, value, nameof(StatisticProperties));
  }
  private StatisticProperties? _StatisticProperties;

  /// <summary>
  ///   Custom document properties, allowing storage of user-defined metadata.
  /// </summary>
  public CustomProperties CustomProperties
  {
    get => _CustomProperties ??= new CustomProperties(this);
    set => UpdateField(ref _CustomProperties, value, nameof(CustomProperties));
  }
  private CustomProperties? _CustomProperties;

  /// <summary>
  ///   Document-level settings, including compatibility, protection, and view options.
  /// </summary>
  public DocumentSettings DocumentSettings
  {
    get => _DocumentSettings ??= new DocumentSettings(this);
    set
    {
      if (!Equals(DocumentSettings, value))
      {
        DocumentSettings.CopyFrom(value);
      }
    }
  }

  private DocumentSettings? _DocumentSettings;
  ///// <summary>
  /////   Document-level settings, including compatibility, protection, and view options.
  ///// </summary>
  //public CompatibilitySettings? CompatibilitySettings
  //{
  //  get
  //  {
  //    if (_DocumentSettings == null)
  //      _DocumentSettings = new DocumentSettings(this);
  //    if (CompatibilitySettings == null)
  //      CompatibilitySettings = new CompatibilitySettings(this);
  //    return _CompatibilitySettings;
  //  }
  //  set => UpdateField(ref _CompatibilitySettings, value, nameof(CompatibilitySettings));
  //}
  //private CompatibilitySettings? _CompatibilitySettings;

  /// <summary>
  /// Collection of all known document properties.
  /// </summary>
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
  public Rsids? Rsids
  {
    get
    {
      if (_Rsids == null && WordprocessingDocument?.MainDocumentPart?.DocumentSettingsPart != null)
        _Rsids = new Rsids(this);
      return _Rsids;
    }

    set => UpdateField(ref _Rsids, value, nameof(Rsids));
  }
  private Rsids? _Rsids;

  /// <summary>
  ///   Collection of DocumentVariables used in the document.
  /// </summary>
  public DocumentVariables? DocumentVariables
  {
    get
    {
      if (_DocumentVariables == null && WordprocessingDocument?.MainDocumentPart?.DocumentSettingsPart != null)
        _DocumentVariables = new DocumentVariables(this);
      return _DocumentVariables;
    }

    set => UpdateField(ref _DocumentVariables, value, nameof(DocumentVariables));
  }
  private DocumentVariables? _DocumentVariables;

  /// <summary>
  ///   TextFormat table for the document, providing access to font definitions used within the document.
  /// </summary>
  public FontTable? FontTableTable
  {
    get
    {
      if (_FontTable == null && WordprocessingDocument?.MainDocumentPart?.FontTablePart != null)
        _FontTable = new FontTable(this);
      return _FontTable;
    }

    set => UpdateField(ref _FontTable, value, nameof(FontTableTable));
  }
  private FontTable? _FontTable;

  /// <summary>
  ///   Document-level settings, including compatibility, protection, and view options.
  /// </summary>
  public DMD.Theme? Theme
  {
    get => _Theme ??= new DMD.Theme(this);
    set => UpdateField(ref _Theme, value, nameof(Theme));
  }
  private DMD.Theme? _Theme;

  /// <summary>
  ///   Styles for the document, providing access to style definitions used within the document.
  /// </summary>
  public Styles? Styles
  {
    get
    {
      if (_Styles == null && WordprocessingDocument?.MainDocumentPart?.StyleDefinitionsPart != null)
        _Styles = new Styles(this);
      return _Styles;
    }

    set => UpdateField(ref _Styles, value, nameof(Styles));
  }
  private Styles? _Styles;

  /// <summary>
  /// Numbering definitions for the document, providing access to numbering formats and instances used within the document.
  /// </summary>
  public Numbering? Numbering
  {
    get
    {
      if (_Numbering == null && WordprocessingDocument?.MainDocumentPart?.NumberingDefinitionsPart != null)
        _Numbering = new Numbering(this);
      return _Numbering;
    }

    set => UpdateField(ref _Numbering, value, nameof(Numbering));
  }
  private Numbering? _Numbering;
}
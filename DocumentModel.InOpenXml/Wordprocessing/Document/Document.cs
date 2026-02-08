namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a WordprocessingML document, providing access to its settings, properties, and lifecycle management.
///   Enables loading, saving, and manipulating document-level metadata, content, and configuration for Open XML word processing documents.
/// </summary>
public partial class Document : ModelElement, IWordprocessingDocumentAware, IDisposable
{
  /// <summary>
  ///   Initializes a new instance of the <see cref="Document"/> class with default property objects.
  /// </summary>
  public Document()
  {
    _CoreProperties = new CoreProperties(this);
    _ContentProperties = new ContentProperties(this);
    _StatisticProperties = new StatisticProperties(this);
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="Document"/> class and attaches it to the specified Open XML word processing document.
  /// </summary>
  /// <param name="wordprocessingDocument">The Open XML word processing document to attach to.</param>
  public Document(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
    wordprocessingDocument.GetPackageProperties();
    _CoreProperties = new CoreProperties(this);
    _ContentProperties = new ContentProperties(this);
    _StatisticProperties = new StatisticProperties(this);
  }

  /// <summary>
  ///   The underlying Open XML word processing document associated with this instance.
  /// </summary>
  public DXPP.WordprocessingDocument? WordprocessingDocument
  {
    get => _WordprocessingDocument;
    set => UpdateField(ref _WordprocessingDocument, value, nameof(WordprocessingDocument));
  }

  private DXPP.WordprocessingDocument? _WordprocessingDocument;

  /// <summary>
  ///   Attaches this instance to the specified word processing document and loads data from its package properties and settings.
  /// </summary>
  /// <param name="wordprocessingDocument">The word processing document to attach and load from.</param>
  public void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
    _CoreProperties.AttachAndLoad(wordprocessingDocument);
    _ContentProperties.AttachAndLoad(wordprocessingDocument);
    _StatisticProperties.AttachAndLoad(wordprocessingDocument);
    _CustomProperties?.AttachAndLoad(wordprocessingDocument);
    _DocumentSettings?.AttachAndLoad(wordprocessingDocument);
  }

  /// <summary>
  ///   Attaches this instance to the specified word processing document and updates its package properties and settings with current data.
  /// </summary>
  /// <param name="wordprocessingDocument">The word processing document to attach and update.</param>
  public void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
    _CoreProperties.AttachAndUpdate(wordprocessingDocument);
    _ContentProperties.AttachAndUpdate(wordprocessingDocument);
    _StatisticProperties.AttachAndUpdate(wordprocessingDocument);
    _CustomProperties?.AttachAndUpdate(wordprocessingDocument);
    _DocumentSettings?.AttachAndUpdate(wordprocessingDocument);
  }

  /// <summary>
  ///   Detaches the document and all associated property objects from their underlying data sources, releasing any held resources.
  ///   After calling this method, the document and its property objects are no longer connected to their original data.
  ///   Further operations on these objects may not be valid until they are reattached or reinitialized.
  /// </summary>
  public void Detach()
  {
    WordprocessingDocument = null;
    _CoreProperties.Detach();
    _ContentProperties.Detach();
    _StatisticProperties.Detach();
    _CustomProperties?.Detach();
  }

  /// <summary>
  ///   Creates a new WordprocessingML document at the specified file path.
  /// </summary>
  /// <param name="filePath">The file path for the new document.</param>
  /// <returns>A new <see cref="Document"/> instance representing the created file.</returns>
  public static Document CreateDocument(string filePath)
  {
    var newDocument = new Document(WordprocessingHelper.CreateWordDocument(filePath));
    return newDocument;
  }

  /// <summary>
  ///   Opens a WordprocessingML document from the specified file path and returns a new <see cref="Document"/> instance representing it.
  /// </summary>
  /// <param name="filePath">The full path to the file to open. The file must exist and be a valid Word document.</param>
  /// <returns>A <see cref="Document"/> instance representing the opened file.</returns>
  public static Document OpenDocument(string filePath)
  {
    var newDocument = new Document(WordprocessingHelper.OpenWordDocument(filePath));
    return newDocument;
  }

  /// <summary>
  ///   Releases resources used by the document and notifies property change.
  ///   Disposes the underlying Open XML document and detaches all property objects.
  /// </summary>
  public void Dispose()
  {
    WordprocessingDocument?.Dispose();
    WordprocessingDocument = null;
    Detach();
    NotifyPropertyChanged(nameof(WordprocessingDocument));
  }

  /// <summary>
  ///   Returns the updatable Open XML element associated with this document (the underlying <see cref="DXPP.WordprocessingDocument"/>).
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
    get => _CoreProperties;
    set
    {
      if (!Equals(_CoreProperties, value))
      {
        _CoreProperties.CopyFrom(value);
      }
    }
  }

  private readonly CoreProperties _CoreProperties;

  /// <summary>
  ///   Content-specific document properties, such as content type and structure.
  /// </summary>
  [NotMapped]
  public ContentProperties ContentProperties
  {
    get => _ContentProperties;
    set => UpdateField(ref _ContentProperties!, value, nameof(ContentProperties));
  }

  private ContentProperties _ContentProperties;

  /// <summary>
  ///   Statistical document properties such as word count and page count.
  /// </summary>
  [NotMapped]
  public StatisticProperties StatisticProperties
  {
    get => _StatisticProperties;
    set => UpdateField(ref _StatisticProperties!, value, nameof(StatisticProperties));
  }

  private StatisticProperties _StatisticProperties;

  /// <summary>
  ///   Custom document properties, allowing storage of user-defined metadata.
  /// </summary>
  public CustomProperties? CustomProperties
  {
    get
    {
      if (_CustomProperties == null && WordprocessingDocument?.CustomFilePropertiesPart != null)
        _CustomProperties = new CustomProperties(this);
      return _CustomProperties;
    }
    set => UpdateField(ref _CustomProperties, value, nameof(CustomProperties));
  }

  private CustomProperties? _CustomProperties;

  /// <summary>
  ///   Document-level settings, including compatibility, protection, and view options.
  /// </summary>
  public DocumentSettings? DocumentSettings
  {
    get
    {
      if (_DocumentSettings == null && WordprocessingDocument?.MainDocumentPart?.DocumentSettingsPart != null)
        _DocumentSettings = new DocumentSettings(this);
      return _DocumentSettings;
    }
    set => UpdateField(ref _DocumentSettings, value, nameof(DocumentSettings));
  }

  private DocumentSettings? _DocumentSettings;

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
        _KnownProperties.AddRange(CoreProperties.KnownProperties);
        _KnownProperties.AddRange(ContentProperties.KnownProperties);
        _KnownProperties.AddRange(StatisticProperties.KnownProperties);
        _KnownProperties.AddRange(DocumentSettings.KnownProperties);
        _KnownProperties.AddRange(CompatibilitySettings.KnownProperties);
        _KnownProperties.AddRange(MailMerge.KnownProperties);
        _KnownProperties.AddRange(DMM.MathProperties.KnownProperties);

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
  ///   Font table for the document, providing access to font definitions used within the document.
  /// </summary>
  public Fonts? Fonts
  {
    get
    {
      if (_Fonts == null && WordprocessingDocument?.MainDocumentPart?.FontTablePart != null)
        _Fonts = new Fonts(this);
      return _Fonts;
    }
    set => UpdateField(ref _Fonts, value, nameof(Fonts));
  }

  private Fonts? _Fonts;


  /// <summary>
  ///   Font table for the document, providing access to font definitions used within the document.
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
}
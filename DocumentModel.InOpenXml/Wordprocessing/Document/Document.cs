namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a Wordprocessing document and provides access to its settings and lifecycle management.
/// </summary>
public class Document : ModelElement, IWordprocessingDocumentAware, IDisposable
{

  /// <summary>
  /// Initializes a new instance of the Document class.
  /// </summary>
  public Document()
  {
    _CoreProperties = new CoreProperties(this);
    _ContentProperties = new ContentProperties(this);
    _StatisticProperties = new StatisticProperties(this);

  }

  /// <summary>
  /// Initializes a new instance of the Document class.
  /// </summary>
  public Document(DXPP.WordprocessingDocument? wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
    _CoreProperties = new CoreProperties(this);
    _ContentProperties = new ContentProperties(this);
    _StatisticProperties = new StatisticProperties(this);

  }

  /// <summary>
  /// Gets the underlying Open XML word processing document associated with this instance.
  /// </summary>
  public DXPP.WordprocessingDocument? WordprocessingDocument { get; private set; }

  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument. Data is loaded from the wordprocessingDocument's PackageProperties.
  /// </summary>
  /// <param name="wordprocessingDocument"></param>
  public void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
    _CoreProperties.AttachAndLoad(wordprocessingDocument);
    _ContentProperties.AttachAndLoad(wordprocessingDocument);
    _StatisticProperties.AttachAndLoad(wordprocessingDocument);
    _CustomProperties?.AttachAndLoad(wordprocessingDocument);
  }

  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument. Data is stored to the wordprocessingDocument's PackageProperties.
  /// </summary>
  /// <param name="wordprocessingDocument"></param>
  public void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
    _CoreProperties.AttachAndUpdate(wordprocessingDocument);
    _ContentProperties.AttachAndUpdate(wordprocessingDocument);
    _StatisticProperties.AttachAndUpdate(wordprocessingDocument);
    _CustomProperties?.AttachAndUpdate(wordprocessingDocument);
  }

  /// <summary>
  /// Detaches the document and all associated property objects from their underlying data sources, releasing any held
  /// resources.  
  /// </summary>
  /// <remarks>After calling this method, the document and its property objects are no longer connected to their
  /// original data. Further operations on these objects may not be valid until they are reattached or
  /// reinitialized.</remarks>
  public void Detach()
  {
    WordprocessingDocument = null;
    _CoreProperties.Detach();
    _ContentProperties.Detach();
    _StatisticProperties.Detach();
    _CustomProperties?.Detach();
  }


  /// <summary>
  /// Creates a new Wordprocessing document at the specified file path.
  /// </summary>
  /// <param name="filePath">The file path for the new document.</param>
  /// <returns>A new Document instance.</returns>
  public static Document CreateDocument(string filePath)
  {
    var newDocument = new Document(WordprocessingHelper.CreateWordDocument(filePath));
    return newDocument;
  }

  /// <summary>
  /// Opens a document from the specified file path and returns a new Document instance representing it.
  /// </summary>
  /// <param name="filePath">The full path to the file to open. The file must exist and be a valid Word document.</param>
  /// <returns>A Document instance representing the opened file.</returns>
  public static Document OpenDocument(string filePath)
  {
    var newDocument = new Document(WordprocessingHelper.OpenWordDocument(filePath));
    return newDocument;
  }

  /// <summary>
  /// Releases resources used by the document and notifies property change.
  /// </summary>
  public void Dispose()
  {
    Detach();
    WordprocessingDocument?.Dispose();
    WordprocessingDocument = null;
    NotifyPropertyChanged(nameof(WordprocessingDocument));
  }

  protected override object? GetUpdatableOpenXmlElement()
  {
    return WordprocessingDocument;
  }

  /// <summary>
  /// Provides access to core document properties such as title, author, and subject.
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
  /// Provides access to content-specific document properties.
  /// </summary>
  [NotMapped]
  public ContentProperties ContentProperties
  {
    get => _ContentProperties;
    set => UpdateField(ref _ContentProperties, value, nameof(ContentProperties));
  }
  private ContentProperties _ContentProperties;

  /// <summary>
  /// Provides access to statistical document properties such as word count and page count.
  /// </summary>
  [NotMapped]
  public StatisticProperties StatisticProperties
  {
    get => _StatisticProperties;
    set => UpdateField(ref _StatisticProperties, value, nameof(StatisticProperties));
  }
  private StatisticProperties _StatisticProperties;


  /// <summary>
  /// Provides access to custom document properties.
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
  /// Provides access to document-level settings and properties.
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

}
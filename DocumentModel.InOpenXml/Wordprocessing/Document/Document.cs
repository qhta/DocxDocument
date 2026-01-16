namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a Wordprocessing document and provides access to its settings and lifecycle management.
/// </summary>
public class Document : ModelElement<DXPP.WordprocessingDocument>, IDisposable
{
  /// <summary>
  /// Gets the underlying Open XML word processing document associated with this instance.
  /// </summary>
  public DXPP.WordprocessingDocument? WordprocessingDocument => GetOpenXmlElement();

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
  public Document(DXPP.WordprocessingDocument? WordprocessingDocument)
  {
    SetOpenXmlElement(WordprocessingDocument);
    _CoreProperties = new CoreProperties(this);
    _ContentProperties = new ContentProperties(this);
    _StatisticProperties = new StatisticProperties(this);
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
    _CoreProperties.Detach(this);
    _ContentProperties.Detach(this);
    var wordprocessingDocument = GetOpenXmlElement();
    wordprocessingDocument?.Dispose();
    wordprocessingDocument = null;
    NotifyPropertyChanged(nameof(wordprocessingDocument));
  }

  /// <summary>
  /// Provides access to core document properties such as title, author, and subject.
  /// </summary>
  public CoreProperties CoreProperties
  {
    get => _CoreProperties;
    set
    {
      if (!Equals(_CoreProperties, value))
      {
        _CoreProperties.Detach(this);
        value.AttachAndUpdate(this);
        _CoreProperties = value;

      }
    }
  }
  private CoreProperties _CoreProperties;

  /// <summary>
  /// Provides access to content-specific document properties.
  /// </summary>
  public ContentProperties ContentProperties
  {
    get => _ContentProperties;
    set
    {
      if (!Equals(_ContentProperties, value))
      {
        _ContentProperties.Detach(this);
        value.AttachAndUpdate(this);
        _ContentProperties = value;

      }
    }
  }
  private ContentProperties _ContentProperties;

  /// <summary>
  /// Provides access to statistical document properties such as word count and page count.
  /// </summary>
  public StatisticProperties StatisticProperties
  {
    get => _StatisticProperties;
    set
    {
      if (!Equals(_StatisticProperties, value))
      {
        _StatisticProperties.Detach(this);
        value.AttachAndUpdate(this);
        _StatisticProperties = value;

      }
    }
  }

  private StatisticProperties _StatisticProperties;

  /// <summary>
  /// Provides access to document-level settings and properties.
  /// </summary>
  public DocumentSettings DocumentSettings { get; private set; } = new DocumentSettings();
}
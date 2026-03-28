namespace DocumentModel.Wordprocessing;

/// <summary>
/// Model class that represents all document properties and settings, including core properties, content properties,
/// statistic properties, custom properties, document settings, and web settings.
/// This class serves as a container for all types of document metadata and configuration settings
/// in a Wordprocessing document.
/// </summary>
public class PropertiesAndSettings: DocumentProperties
{

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
  ///   Initializes a new instance of the <see cref="Document"/> class with default property objects.
  /// </summary>
  public PropertiesAndSettings()
  {
    _CoreProperties = new CoreProperties();
    _ContentProperties = new ContentProperties();
    _StatisticProperties = new StatisticProperties();
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="Document"/> class with default property objects.
  /// </summary>
  public PropertiesAndSettings(Document document)
  {
    ParentDocument = document;
    _CoreProperties = new CoreProperties(document);
    _ContentProperties = new ContentProperties(document);
    _StatisticProperties = new StatisticProperties(document);
  }

  /// <summary>
  /// Reference to the parent Document instance that contains this PropertiesAndSettings object.
  /// This reference allows the properties and settings to access contextual information from the parent document if needed.
  /// </summary>
  public Document? ParentDocument { get; private set; }

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
    _CoreProperties?.AttachAndLoad(wordprocessingDocument);
    _ContentProperties?.AttachAndLoad(wordprocessingDocument);
    _StatisticProperties?.AttachAndLoad(wordprocessingDocument);
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
    _CoreProperties?.AttachAndUpdate(wordprocessingDocument);
    _ContentProperties?.AttachAndUpdate(wordprocessingDocument);
    _StatisticProperties?.AttachAndUpdate(wordprocessingDocument);
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
    _CoreProperties?.Detach();
    _ContentProperties?.Detach();
    _StatisticProperties?.Detach();
    _CustomProperties?.Detach();
    _DocumentSettings?.Detach();
  }

  /// <summary>
  /// Collection of custom-defined document properties.
  /// </summary>
  [XmlIgnore]
  public DocumentSettings? DocumentSettings
  {
    get => _DocumentSettings;
    set => UpdateField(ref _DocumentSettings, value, nameof(DocumentSettings));
  }

  private DocumentSettings? _DocumentSettings;
}
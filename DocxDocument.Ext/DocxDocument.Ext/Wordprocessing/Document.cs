namespace DocumentModel.Wordprocessing;

public partial class Document : IDisposable
{
#pragma warning disable CS0618 // Type or member is obsolete
  public Document(DXP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }
#pragma warning restore CS0618 // Type or member is obsolete

  internal DXP.WordprocessingDocument WordprocessingDocument { get; private set; }

  #region Open/Create static methods
  public static Document Open(string path, bool isEditable)
    => Open(path, isEditable, new DXP.OpenSettings());

  public static Document Create(string path)
      => Create(path, DX.WordprocessingDocumentType.Document, true);

  public static Document Create(Stream stream)
      => Create(stream, DX.WordprocessingDocumentType.Document, true);

  public static Document Create(Package package)
      => Create(package, DX.WordprocessingDocumentType.Document, true);

  public static Document Open(string path, bool isEditable, DXP.OpenSettings openSettings)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Open(path, isEditable, openSettings);
    return new Document(wordprocessingDocument);
  }

  public static Document Open(Stream stream, bool isEditable)
    => Open(stream, isEditable, new DXP.OpenSettings());

  public static Document Open(Stream stream, bool isEditable, DXP.OpenSettings openSettings)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Open(stream, isEditable, openSettings);
    return new Document(wordprocessingDocument);
  }

  public static Document Open(Package stream)
    => Open(stream, new DXP.OpenSettings());

  public static Document Open(Package stream, DXP.OpenSettings openSettings)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Open(stream, openSettings);
    return new Document(wordprocessingDocument);
  }

  public static Document Create(string path, DX.WordprocessingDocumentType type)
      => Create(path, type, true);

  public static Document Create(Stream stream, DX.WordprocessingDocumentType type)
      => Create(stream, type, true);

  public static Document Create(Package package, DX.WordprocessingDocumentType type)
      => Create(package, type, true);


  public static Document Create(string path, DX.WordprocessingDocumentType type, bool autoSave)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Create(path, type, autoSave);
    if (wordprocessingDocument.MainDocumentPart==null)
      wordprocessingDocument.AddMainDocumentPart();
    return new Document(wordprocessingDocument);
  }

  public static Document Create(Stream stream, DX.WordprocessingDocumentType type, bool autoSave)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Create(stream, type, autoSave);
    return new Document(wordprocessingDocument);
  }

  public static Document Create(Package package, DX.WordprocessingDocumentType type, bool autoSave)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Create(package, type, autoSave);
    return new Document(wordprocessingDocument);
  }

  public static Document CreateFromTemplate(string path)
      => CreateFromTemplate(path, true);
  public static Document CreateFromTemplate(string path, bool isTemplateAttached)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.CreateFromTemplate(path, isTemplateAttached);
    return new Document(wordprocessingDocument);
  }
  #endregion

  public void Dispose()
  {
    (WordprocessingDocument).Dispose();
  }

  public DX.WordprocessingDocumentType DocumentType => WordprocessingDocument.DocumentType;

  public BuiltInProperties BuiltInProperties
  {
    get
    {
      if (_BuiltInProperties==null)
      {
        _BuiltInProperties = new BuiltInProperties(this);
        _BuiltInProperties.Load();
      }
      return _BuiltInProperties;
    }
  }
  private BuiltInProperties? _BuiltInProperties;


  public bool HasCustomProperties => WordprocessingDocument.CustomFilePropertiesPart?.Properties!=null;

  public CustomProperties CustomProperties
  {
    get
    {
      if (_CustomProperties==null)
      {
        _CustomProperties = new CustomProperties(this);
        _CustomProperties.Load();
      }
      return _CustomProperties;
    }
  }
  private CustomProperties? _CustomProperties;

  public bool HasDocumentSettings => WordprocessingDocument.MainDocumentPart?.DocumentSettingsPart?.Settings != null;

  public DocumentSettings DocumentSettings
  {
    get
    {
      if (_DocumentSettings==null)
      {
        _DocumentSettings = new DocumentSettings(this);
        _DocumentSettings.Load();
      }
      return _DocumentSettings;
    }
  }
  private DocumentSettings? _DocumentSettings;
}

namespace DocumentModel;

/// <summary>
/// The main class representing the whole wordprocessing document.
/// </summary>
[DataContract]
[XmlSerializerFormat]
public partial class Document : ModelElement, IDisposable
{
#pragma warning disable CS0618 // Type or member is obsolete


  internal DXP.WordprocessingDocument? _WordprocessingDocument { get; private set; }


  //internal DXP.WordprocessingDocument _WordprocessingDocument
  //{
  //  get
  //  {
  //    if (_WordprocessingDocument == null)
  //    {
  //      MemStream = new MemoryStream();
  //      _WordprocessingDocument = DXP.WordprocessingDocument.Create(MemStream, DX.WordprocessingDocumentType.Document, true);
  //    }
  //    return _WordprocessingDocument;
  //  }
  //  private set => _WordprocessingDocument = value;
  //}
  internal Stream? MemStream { get; private set; }

  [DataMember]
  [XmlAttribute]
  public DX.WordprocessingDocumentType? DocumentType
  {
    get => _WordprocessingDocument?.DocumentType ?? _DocumentType;
    set => _DocumentType = value;
  }
  private DX.WordprocessingDocumentType? _DocumentType;

  public Document()
  {
    MemStream = new MemoryStream();
    _WordprocessingDocument = DXP.WordprocessingDocument.Create(MemStream, DX.WordprocessingDocumentType.Document, true);
  }

  public void Dispose()
  {
    _WordprocessingDocument?.Dispose();
    MemStream?.Dispose();
  }

  public Document(DXP.WordprocessingDocument wordprocessingDocument)
  {
    _WordprocessingDocument = wordprocessingDocument;
  }

  public void Serialize(string fileName)
  {
    var knownTypes = typeof(Document).Assembly.GetTypes();
    FileStream writer = new FileStream(fileName, FileMode.Create);
    DataContractSerializer serializer = new DataContractSerializer(typeof(Document), knownTypes);
    serializer.WriteObject(writer, this);
    writer.Close();
  }

  public void Deserialize(string fileName)
  {
    var knownTypes = typeof(Document).Assembly.GetTypes();
    FileStream reader = new FileStream(fileName, FileMode.Open);
    DataContractSerializer serializer = new DataContractSerializer(typeof(Document), knownTypes);
    var result = serializer.ReadObject(reader);
    if (result is Document document)
    {
      this.BuiltInProperties = document.BuiltInProperties;
    }
    else
      throw new InvalidDataException($"Deserialized type is not Document");
  }

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
    if (wordprocessingDocument.MainDocumentPart == null)
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

  [DataMember]
  public BuiltInProperties BuiltInProperties
  {
    get
    {
      if (_BuiltInProperties == null)
        _BuiltInProperties = new BuiltInProperties(this);
      return _BuiltInProperties;
    }
    set
    {
      if (_BuiltInProperties != value)
      {
        _BuiltInProperties = value;
        if (_BuiltInProperties != null)
        {
          if (_WordprocessingDocument != null)
          {
            var packageProperties = _WordprocessingDocument.PackageProperties;
            if (packageProperties == null)
            {
              var packagePropertiesPart = _WordprocessingDocument.AddCoreFilePropertiesPart();
              packageProperties = _WordprocessingDocument.PackageProperties;
            }
            _BuiltInProperties.CopyTo(packageProperties);
            if (BuiltInProperties._ExtendedProperties != null)
            {
              var extendedPropertiesPart = _WordprocessingDocument.ExtendedFilePropertiesPart;
              if (extendedPropertiesPart == null)
                extendedPropertiesPart = _WordprocessingDocument.AddExtendedFilePropertiesPart();
              extendedPropertiesPart.Properties = BuiltInProperties._ExtendedProperties;
            }
          }
        }
      }
    }
  }
  internal BuiltInProperties? _BuiltInProperties { get; private set; }


  public bool HasCustomProperties => _WordprocessingDocument?.CustomFilePropertiesPart?.Properties != null;

  [DataMember]
  public CustomProperties? CustomProperties
  {
    get
    {
      if (HasCustomProperties)
        return ExistingCustomProperties;
      return _CustomProperties;
    }
    set
    {
      if (_CustomProperties != value)
      {
        _CustomProperties = value;
        if (_CustomProperties != null)
        {
          if (_WordprocessingDocument != null)
          {
            var customFilePropertiesPart = _WordprocessingDocument.CustomFilePropertiesPart;
            if (customFilePropertiesPart == null)
              customFilePropertiesPart = _WordprocessingDocument.AddCustomFilePropertiesPart();

            customFilePropertiesPart.Properties = _CustomProperties._CustomFileProperties;
          }
        }
      }
    }
  }
  internal CustomProperties? _CustomProperties { get; private set; }

  internal CustomProperties ExistingCustomProperties
  {
    get
    {
      if (_CustomProperties == null)
      {
        if (_WordprocessingDocument != null)
        {
          var customFilePropertiesPart = _WordprocessingDocument.CustomFilePropertiesPart;
          if (customFilePropertiesPart == null)
            customFilePropertiesPart = _WordprocessingDocument.AddCustomFilePropertiesPart();

          var properties = customFilePropertiesPart.Properties;
          if (properties == null)
          {
            properties = new DXCP.Properties();
            customFilePropertiesPart.Properties = properties;
          }
          _CustomProperties = new CustomProperties(properties);
        }
        else
        {
          var properties = new DXCP.Properties();
          _CustomProperties = new CustomProperties(properties);
        }
      }
      return _CustomProperties;
    }
  }

  public bool HasDocumentSettings => _WordprocessingDocument?.MainDocumentPart?.DocumentSettingsPart?.Settings != null;

  [DataMember]
  public DMW.DocumentSettings? DocumentSettings
  {
    get
    {
      if (HasDocumentSettings && _DocumentSettings == null)
        _DocumentSettings = new DMW.DocumentSettings(this);
      return _DocumentSettings;
    }
    set
    {
      if (_DocumentSettings != value)
      {
        _DocumentSettings = value;
      }
    }
  }
  internal DMW.DocumentSettings? _DocumentSettings { get; private set; }


}

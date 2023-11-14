using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel;

/// <summary>
/// The main class representing the whole wordprocessing document.
/// </summary>
[DataContract]
[XmlSerializerFormat]
public partial class Document : ModelElement, IDisposable
{

  internal DXP.WordprocessingDocument? _WordprocessingDocument { get; private set; }

  internal Stream? MemStream { get; private set; }

  /// <summary>
  /// Specifies a wordprocessing document type.
  /// It may be any of:
  /// <list type="bullet">
  ///   <item>Word Document (*.docx)</item>
  ///   <item>Word Template (*.dotx)</item>
  ///   <item>Word Macro-Enabled Document (*.docm))</item>
  ///   <item>Word Macro-Enabled Template (*.dotm)</item>
  /// </list>
  /// </summary>
  [DataMember]
  [XmlAttribute]
  public DX.WordprocessingDocumentType? DocumentType
  {
    get => _WordprocessingDocument?.DocumentType ?? _DocumentType;
    set => _DocumentType = value;
  }
  private DX.WordprocessingDocumentType? _DocumentType;

  /// <summary>
  /// Default constructor. Creates a Wordprocessing document in a memory stream 
  /// and adds a MainDocumentPart().
  /// </summary>
  public Document()
  {
    MemStream = new MemoryStream();
    _WordprocessingDocument = DXP.WordprocessingDocument.Create(MemStream, DX.WordprocessingDocumentType.Document, true);
    _WordprocessingDocument.AddMainDocumentPart();
  }


  /// <summary>
  /// Saves a document in the specified docx file.
  /// </summary>
  /// <param name="fileName"></param>
  public void SaveAs(string fileName)
  {
    Debug.Assert(_WordprocessingDocument != null);
    using (var clone = _WordprocessingDocument?.Clone(fileName))
    {
      // Do nothing. Just dispose.
    }
  }

  /// <summary>
  /// Saves a document in the specified docx file in flat OPC format.
  /// </summary>
  /// <param name="fileName"></param>
  public void SaveAsFlatOpc(string fileName)
  {
    Debug.Assert(_WordprocessingDocument != null);
    var flatOpcStr = _WordprocessingDocument.ToFlatOpcDocument();
    using (var writer = File.CreateText(fileName))
    {
      writer.Write(flatOpcStr);
    }
  }

  /// <summary>
  /// Disposes resources in Wordprocessing document and optionally a memory stream.
  /// </summary>
  public void Dispose()
  {
    _WordprocessingDocument?.Dispose();
    MemStream?.Dispose();
  }

  /// <summary>
  /// Constructor with WordprocessingDocument parameter.
  /// </summary>
  /// <param name="wordprocessingDocument"></param>
  public Document(DXP.WordprocessingDocument wordprocessingDocument)
  {
    _WordprocessingDocument = wordprocessingDocument;
  }

  /// <summary>
  /// Serializes the document to the file using DataContractSerializer.
  /// </summary>
  /// <param name="fileName"></param>
  public void Serialize(string fileName)
  {
    var knownTypes = typeof(Document).Assembly.GetTypes();
    FileStream writer = new FileStream(fileName, FileMode.Create);
    DataContractSerializer serializer = new DataContractSerializer(typeof(Document), knownTypes);
    serializer.WriteObject(writer, this);
    writer.Close();
  }

  /// <summary>
  /// Deserializes the content of the document from the file using DataContractSerializer.
  /// </summary>
  /// <param name="fileName"></param>
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

  #region Open static methods
  /// <summary>
  /// Opens a document from the Word document file 
  /// deciding whether it is editable or not.
  /// </summary>
  /// <param name="path"></param>
  /// <param name="isEditable"></param>
  /// <returns></returns>
  public static Document Open(string path, bool isEditable)
    => Open(path, isEditable, new DXP.OpenSettings());

  /// <summary>
  ///  Opens a document from the Word document file 
  /// deciding whether it is editable or not
  /// and using specific OpenSettings parameter.
  /// </summary>
  /// <param name="path"></param>
  /// <param name="isEditable"></param>
  /// <param name="openSettings"></param>
  /// <returns></returns>
  public static Document Open(string path, bool isEditable, DXP.OpenSettings openSettings)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Open(path, isEditable, openSettings);
    return new Document(wordprocessingDocument);
  }

  /// <summary>
  /// Opens a document from the specified stream 
  /// deciding whether it is editable or not.
  /// </summary>
  /// <param name="stream"></param>
  /// <param name="isEditable"></param>
  /// <returns></returns>
  public static Document Open(Stream stream, bool isEditable)
    => Open(stream, isEditable, new DXP.OpenSettings());

  /// <summary>
  /// Opens a document from the specified stream 
  /// deciding whether it is editable or not
  /// and using specific OpenSettings parameter.
  /// </summary>
  /// <param name="stream"></param>
  /// <param name="isEditable"></param>
  /// <param name="openSettings"></param>
  /// <returns></returns>
  public static Document Open(Stream stream, bool isEditable, DXP.OpenSettings openSettings)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Open(stream, isEditable, openSettings);
    return new Document(wordprocessingDocument);
  }

  /// <summary>
  /// Opens a document from the specified ZIP package.
  /// </summary>
  /// <param name="stream"></param>
  /// <returns></returns>
  public static Document Open(Package stream)
    => Open(stream, new DXP.OpenSettings());

  /// <summary>
  /// Opens a document from the specified ZIP package 
  /// using specific OpenSettings parameter.
  /// </summary>
  /// <param name="stream"></param>
  /// <param name="openSettings"></param>
  /// <returns></returns>
  public static Document Open(Package stream, DXP.OpenSettings openSettings)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Open(stream, openSettings);
    return new Document(wordprocessingDocument);
  }
  #endregion

  #region Create static methods
  /// <summary>
  /// Creates a document in the Word document file.
  /// The document is auto-saved.
  /// </summary>
  /// <param name="path"></param>
  /// <returns></returns>
  public static Document Create(string path)
      => Create(path, DX.WordprocessingDocumentType.Document, true);

  /// <summary>
  /// Creates a document in the specified stream.
  /// The document is auto-saved.
  /// </summary>
  /// <param name="stream"></param>
  /// <returns></returns>
  public static Document Create(Stream stream)
      => Create(stream, DX.WordprocessingDocumentType.Document, true);

  /// <summary>
  /// Creates a document in the specified ZIP package.
  /// The document is auto-saved.
  /// </summary>
  /// <param name="package"></param>
  /// <returns></returns>
  public static Document Create(Package package)
      => Create(package, DX.WordprocessingDocumentType.Document, true);

  /// <summary>
  /// Creates a document in the specified document file
  /// specifying its document type.
  /// The document is auto-saved. 
  /// </summary>
  /// <param name="path"></param>
  /// <param name="type"></param>
  /// <returns></returns>
  public static Document Create(string path, DX.WordprocessingDocumentType type)
      => Create(path, type, true);

  /// <summary>
  /// Creates a document in the specified stream
  /// specifying its document type.
  /// The document is auto-saved.  
  /// </summary>
  /// <param name="stream"></param>
  /// <param name="type"></param>
  /// <returns></returns>
  public static Document Create(Stream stream, DX.WordprocessingDocumentType type)
      => Create(stream, type, true);

  /// <summary>
  /// Creates a document in the specified ZIP package
  /// specifying its document type.
  /// The document is auto-saved.
  /// </summary>
  /// <param name="package"></param>
  /// <param name="type"></param>
  /// <returns></returns>
  public static Document Create(Package package, DX.WordprocessingDocumentType type)
      => Create(package, type, true);


  /// <summary>
  /// Creates a document in the specified document file
  /// specifying its document type
  /// and deciding whether the document is auto-saved. 
  /// </summary>
  /// <param name="path"></param>
  /// <param name="type"></param>
  /// <param name="autoSave"></param>
  /// <returns></returns>
  public static Document Create(string path, DX.WordprocessingDocumentType type, bool autoSave)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Create(path, type, autoSave);
    if (wordprocessingDocument.MainDocumentPart == null)
      wordprocessingDocument.AddMainDocumentPart();
    return new Document(wordprocessingDocument);
  }

  /// <summary>
  /// Creates a document in the specified stream
  /// specifying its document type
  /// and deciding whether the document is auto-saved. 
  /// </summary>
  /// <param name="stream"></param>
  /// <param name="type"></param>
  /// <param name="autoSave"></param>
  /// <returns></returns>
  public static Document Create(Stream stream, DX.WordprocessingDocumentType type, bool autoSave)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Create(stream, type, autoSave);
    return new Document(wordprocessingDocument);
  }

  /// <summary>
  /// Creates a document in the specified ZIP package
  /// specifying its document type
  /// and deciding whether the document is auto-saved. 
  /// </summary>
  /// <param name="package"></param>
  /// <param name="type"></param>
  /// <param name="autoSave"></param>
  /// <returns></returns>
  public static Document Create(Package package, DX.WordprocessingDocumentType type, bool autoSave)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Create(package, type, autoSave);
    return new Document(wordprocessingDocument);
  }

  /// <summary>
  /// Creates a document from the Word template file.
  /// The template is attached to the document.
  /// </summary>
  /// <param name="path"></param>
  /// <returns></returns>
  public static Document CreateFromTemplate(string path)
      => CreateFromTemplate(path, true);

  /// <summary>
  /// Creates a document from the Word template file
  /// deciding whether the template is attached to the document
  /// </summary>
  /// <param name="path"></param>
  /// <param name="isTemplateAttached"></param>
  /// <returns></returns>
  public static Document CreateFromTemplate(string path, bool isTemplateAttached)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.CreateFromTemplate(path, isTemplateAttached);
    return new Document(wordprocessingDocument);
  }
  #endregion

  /// <summary>
  /// Built-in document properties. Include CoreFileProperties and ExtendedFileProperties.
  /// </summary>
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
            _BuiltInProperties.CopyCorePropertiesTo(packageProperties);
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


  /// <summary>
  /// Determines whether the WordprocessingDocument has CustomFileProperties root element defined.
  /// </summary>
  public bool HasCustomProperties => _WordprocessingDocument?.CustomFilePropertiesPart?.Properties != null;

  /// <summary>
  /// Model of WordprocessingDocument CustomFileProperties.
  /// May be null if the WordprocessingDocument has no CustomFileProperties root element defined.
  /// </summary>
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

            customFilePropertiesPart.Properties = _CustomProperties._ExistingElement;
          }
        }
      }
    }
  }

  [XmlIgnore]
  internal CustomProperties? _CustomProperties { get; private set; }

  /// <summary>
  /// Model of WordprocessingDocument CustomFileProperties.
  /// If the WordprocessingDocument has no CustomFileProperties root element defined,
  /// then the new instance of these properties is created.
  /// Requires that the WordprocessingDocument is editable.
  /// </summary>
  [XmlIgnore]
  public CustomProperties ExistingCustomProperties
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

  /// <summary>
  /// Determines whether the WordprocessingDocument has DocumentSettingsPart root element defined.
  /// </summary>
  public bool HasDocumentSettings => _WordprocessingDocument?.MainDocumentPart?.DocumentSettingsPart?.Settings != null;

  /// <summary>
  /// Model of WordprocessingDocument DocumentSettings.
  /// May be null if the WordprocessingDocument has no DocumentSettings root element defined.
  /// </summary>
  [DataMember]
  public DMW.DocumentSettings? DocumentSettings
  {
    get
    {
      if (_DocumentSettings == null)
      {
        _DocumentSettings = new DMW.DocumentSettings(this);
      }
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

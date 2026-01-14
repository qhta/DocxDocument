namespace DocumentModel;

/// <summary>
/// Specifies all document-level settings which affect the handling of the current document.
/// There are no predefined settings. Instead, various document parts can register their settings here.
/// </summary>
public class DocumentSettings: ElementCollection<DocumentSetting>
{

  internal DXWP.Settings? OpenXmlSettings { get; private set; }


  /// <summary>
  /// Default constructor.
  /// </summary>
  public DocumentSettings()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">Wordprocessing document model</param>
  public DocumentSettings(Wordprocessing.Document document)
  {
    OpenXmlSettings = document.WordprocessingDocument?.GetDocumentSettings();
    GetValuesFromOpenXmlWordprocessingSettings();
    document.PropertyChanged += Document_PropertyChanged;
  }

  /// <summary>
  /// Triggered when the underlying document's WordprocessingDocument changes.
  /// </summary>
  /// <param name="sender">Should be the Wordprocessing.Document instance</param>
  /// <param name="e">PropertyChangedEventArgs with propertyName = "WordprocessingDocument"</param>
  /// <remarks>
  /// If new value is null then CustomFileProperties are set to null to avoid errors on properties access.
  /// If new value is not null then CustomFileProperties are updated to the new document's PackageProperties.
  /// </remarks>
  private void Document_PropertyChanged(object? sender, PropertyChangedEventArgs e)
  {
    if (sender is Wordprocessing.Document document)
      if (e.PropertyName == nameof(Wordprocessing.Document.WordprocessingDocument))
      {
        if (document.WordprocessingDocument == null)
        {
          OpenXmlSettings = null;
        }
        else
        {
          var isEmpty = OpenXmlSettings == null;
          OpenXmlSettings = document.WordprocessingDocument?.GetDocumentSettings();
          if (isEmpty)
            GetValuesFromOpenXmlWordprocessingSettings();
          else
            SetValuesToOpenXmlWordprocessingSettings();
        }
      }
  }

  /// <summary>
  /// Gets values from OpenXmlElement to this instance. The type of OpenXmlElement must be registered.
  /// </summary>
  private void GetValuesFromOpenXmlWordprocessingSettings()
  {
    this.Clear();
    foreach (var openXmlElement in OpenXmlSettings!.ChildElements)
    {
      var elementType = openXmlElement.GetType();
      var documentSetting = new DocumentSetting(this, openXmlElement);
      this.Add(documentSetting);
    }
  }

  /// <summary>
  /// Sets values from this instance to CustomFileProperties.
  /// </summary>
  private void SetValuesToOpenXmlWordprocessingSettings()
  {
    OpenXmlSettings!.RemoveAllChildren();
    foreach (var documentSetting in this)
    {
      DX.OpenXmlElement element = CreateOpenXmlSetting(documentSetting);
      OpenXmlSettings.AppendChild(element);
    }
  }

  /// <summary>
  /// Registers a new document setting type.
  /// </summary>
  /// <param name="openXmlElementType">It must be a subclass of OpenXmlElement.</param>
  public static void RegisterSetting(Type openXmlElementType)
  {
    Debug.Assert(openXmlElementType.IsSubclassOf(typeof(DX.OpenXmlElement)), 
      "The registered type must be a subclass of OpenXmlElement.");
    TypeModel typeModel = new (openXmlElementType);
    KnownTypes.Add(openXmlElementType.Name, typeModel);
  }

  /// <summary>
  /// Collection of known document settings, i.e. document settings which can be included in this collection.
  /// </summary>
  public static KnownTypes KnownTypes { get; } = new ();

  private DX.OpenXmlElement CreateOpenXmlSetting(DocumentSetting documentSetting)
  {
    throw new NotImplementedException();
  }
}
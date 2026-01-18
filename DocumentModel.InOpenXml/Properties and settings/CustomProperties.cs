namespace DocumentModel;

/// <summary>
/// Custom properties enable users to define custom metadata properties through a set of well-defined data types.
/// </summary>
[XmlRoot("CustomProperties")]
[OpenXmlType(typeof(DXCP.Properties))]
public class CustomProperties : ModelElementCollection<CustomProperty, DXCP.Properties>
{

  /// <summary>
  /// Gets the underlying WordprocessingDocument instance associated with this object.
  /// </summary>
  internal DXPP.WordprocessingDocument? WordprocessingDocument { get; private set; }

  /// <summary>
  /// Default constructor.
  /// </summary>
  public CustomProperties()
  {
  }


  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">Wordprocessing document model</param>
  public CustomProperties(Wordprocessing.Document document) : base()
  {
    AttachAndLoad(document);
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is loaded from the document's PackageProperties.
  /// </summary>
  /// <param name="document">Document to attach to.</param>
  public void AttachAndLoad(Wordprocessing.Document document)
  {
    WordprocessingDocument = document.WordprocessingDocument;
    var customFileProperties = document.WordprocessingDocument?.GetCustomFileProperties();
    if (customFileProperties != null)
    {
      SetOpenXmlElement(customFileProperties);
      LoadData(customFileProperties);
    }
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is stored to the document's PackageProperties.
  /// </summary>
  /// <param name="document">Document to attach to.</param>
  public void AttachAndUpdate(Wordprocessing.Document document)
  {
    WordprocessingDocument = document.WordprocessingDocument;
    var customFileProperties = document.WordprocessingDocument?.GetCustomFileProperties();
    if (customFileProperties != null)
    {
      SetOpenXmlElement(customFileProperties);
      UpdateData(customFileProperties);
    }
  }

  /// <summary>
  /// Detach this instance from the specified document.
  /// Underlying Open XML element is set to null, so further access to its properties will not work until re-attached.
  /// </summary>
  /// <param name="document">Document to detach from. Must be the same as the one attached.</param>
  public void Detach(Wordprocessing.Document document)
  {
    if (WordprocessingDocument != document.WordprocessingDocument)
      return;
    WordprocessingDocument = null;
    SetOpenXmlElement(null);
  }


  /// <summary>
  /// Loads data from customFileProperties to this instance.
  /// </summary>
  protected override void LoadDataCollection(DXCP.Properties customFileProperties)
  {
    this.Clear();
    foreach (var openXmlCustomDocumentProperty in customFileProperties!.ChildElements.Cast<DXCP.CustomDocumentProperty>())
    {
      var customDocumentProperty = new CustomProperty(this, openXmlCustomDocumentProperty);
      this.Add(customDocumentProperty);
    }
  }


  /// <summary>
  /// Store data from this instance to CustomFileProperties.
  /// </summary>
  protected override void UpdateDataCollection(DXCP.Properties customFileProperties)
  {
    customFileProperties!.RemoveAllChildren();
    foreach (var customDocumentProperty in this)
    {
      customFileProperties.AppendChild(customDocumentProperty.CreateOpenCustomDocumentProperty());
    }
  }

  /// <summary>
  /// Automatically assigns PropertyId if not set, then adds the item to the collection.
  /// First PropertyId is 2, then increments from the highest existing PropertyId.
  /// </summary>
  /// <param name="item"></param>
  public new void Add(CustomProperty item)
  {
    if (item.PropertyId == null)
    {
      item.PropertyId = Count == 0 ? 2 : this.Max(p => p.PropertyId)!.Value + 1;
    }
    base.Add(item);
  }

}
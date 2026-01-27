namespace DocumentModel;

/// <summary>
/// Custom properties enable users to define custom metadata properties through a set of well-defined data types.
/// </summary>
[XmlRoot("CustomProperties")]
[OpenXmlType(typeof(DXCP.Properties))]
public sealed class CustomProperties : ModelElementCollection<CustomProperty, DXCP.Properties>
{

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
    if (document.WordprocessingDocument != null)
       AttachAndLoad(document.WordprocessingDocument);
  }

  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument. Data is loaded from the wordprocessingDocument's PackageProperties.
  /// </summary>
  /// <param name="wordprocessingDocument">Document to attach to.</param>
  public override void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndLoad(wordprocessingDocument);
    var customFileProperties = wordprocessingDocument.GetCustomFileProperties();
    SetOpenXmlElement(customFileProperties);
    LoadData(customFileProperties);
  }

  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument. Data is stored to the wordprocessingDocument's PackageProperties.
  /// </summary>
  /// <param name="wordprocessingDocument">Document to attach to.</param>
  public override void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndUpdate(wordprocessingDocument);
    var customFileProperties = wordprocessingDocument.GetCustomFileProperties();
    SetOpenXmlElement(customFileProperties);
    UpdateData(customFileProperties);
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
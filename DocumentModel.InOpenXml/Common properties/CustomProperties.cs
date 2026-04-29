namespace DocumentModel;
/// <summary>
/// Custom properties enable users to define custom metadata properties through a set of well-defined data types.
/// </summary>
[XmlRoot("CustomProperties")]
[OpenXmlType(typeof(DXCP.Properties))]
public sealed partial class CustomProperties : ModelElementCollection<CustomProperty, DXCP.Properties>
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
  public CustomProperties(Wordprocessing.Document document): base(document)
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
  //Debug.WriteLine($"Attaching CustomProperties to WordprocessingDocument: {wordprocessingDocument}");
    base.AttachAndLoad(wordprocessingDocument);
    var customFileProperties = wordprocessingDocument.GetCustomFileProperties();
    SetUpdatableElement(customFileProperties);
    LoadData(customFileProperties);
  }
  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument. Data is stored to the wordprocessingDocument's PackageProperties.
  /// </summary>
  /// <param name="wordprocessingDocument">Document to attach to.</param>
  public override void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
  //Debug.WriteLine($"Attaching CustomProperties to WordprocessingDocument for update: {wordprocessingDocument}");
    WordprocessingDocument = wordprocessingDocument;
    var customFileProperties = wordprocessingDocument.GetCustomFileProperties();
    SetUpdatableElement(customFileProperties);
    UpdateData(customFileProperties);
  }
  /// <summary>
  /// Loads data from customFileProperties to this instance.
  /// </summary>
  protected override void LoadDataCollection(DXCP.Properties customFileProperties)
  { 
    IsLoading = true;
    _IsNotificationEnabled = false;
    Clear();
    foreach (var openXmlCustomDocumentProperty in customFileProperties!.ChildElements.Cast<DXCP.CustomDocumentProperty>())
    {
      var customDocumentProperty = new CustomProperty(this, openXmlCustomDocumentProperty);
      Add(customDocumentProperty);
    }
    _IsNotificationEnabled = null;
    IsLoading = false;
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
      item.PropertyId = Count == 0 ? 2 : this.Max<CustomProperty, int?>(p => p.PropertyId)!.Value + 1;
    }
    base.Add(item);
  }

  /// <summary>
  /// Adds a new CustomProperty to the collection with the specified name and value. The PropertyId is automatically assigned if not set.
  /// </summary>
  /// <param name="name"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  public CustomProperty Add(string name, object value)
  {
    var newItem = new CustomProperty
    {
      Name = name,
      Value = new Variant(value)
    };
    Add(newItem);
    return newItem;
  }
}
namespace DocumentModel;

/// <summary>
/// Custom properties enable users to define custom metadata properties through a set of well-defined data types.
/// </summary>
[XmlRoot("CustomProperties")]
[OpenXmlType(typeof(DXCP.Properties))]
public sealed partial class CustomProperties: ModelElementCollection<CustomProperty, DXCP.Properties, DXCP.CustomDocumentProperty>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public CustomProperties() { }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">Wordprocessing document model</param>
  public CustomProperties(Wordprocessing.Document document): base(document, document.WordprocessingDocument?.GetCustomFileProperties())
  {
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
namespace DocumentModel;

/// <summary>
/// Custom properties enable users to define custom metadata properties through a set of well-defined data types.
/// </summary>
[DataContract]
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
  /// <param name="item">The custom property to add to the collection.</param>
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
  /// <param name="name">The name of the custom property.</param>
  /// <param name="value">The value of the custom property.</param>
  /// <returns>The newly added custom property.</returns>
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

  /// <summary>
  /// Tries to get a CustomProperty from the collection by its name. Returns true if found, false otherwise. The out parameter 'property' will contain the found CustomProperty or null if not found.
  /// </summary>
  /// <param name="index">The name of the custom property.</param>
  /// <param name="property">When this method returns, contains the custom property with the specified name, if found; otherwise, null.</param>
  /// <returns>True if the custom property with the specified name is found; otherwise, false.</returns>
  public bool TryGetProperty(string index, out CustomProperty? property)
  {
    property = this.FirstOrDefault<CustomProperty>(p => p.Name == index);
    return property != null;
  }

  /// <summary>
  /// Tries to set a CustomProperty in the collection by its name. If a CustomProperty with the specified name exists, its value is updated and the method returns true. If it does not exist, the provided CustomProperty is added to the collection and the method returns true. If the provided CustomProperty cannot be added to the collection, the method returns false.
  /// </summary>
  /// <param name="index">The name of the custom property.</param>
  /// <param name="property">The custom property to set.</param>
  /// <returns>True if the custom property with the specified name is found and updated; otherwise, false.</returns>
  public bool TrySetProperty(string index, CustomProperty property)
  {
    var existingProperty = this.FirstOrDefault<CustomProperty>(p => p.Name == index);
    if (existingProperty != null)
    {
      existingProperty.Value = property.Value;
      return true;
    }
    return this.TryAdd(property);
  }
}
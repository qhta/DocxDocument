namespace DocumentModel;

/// <summary>
/// Represents a model element that wraps an OpenXml element of the specified type.
/// </summary>
/// <typeparam name="OpenXmlType">The type of the underlying OpenXml element.</typeparam>
public abstract class ModelElement<OpenXmlType> : ModelElement, ICollectionItem
where OpenXmlType : DX.OpenXmlElement // this constraint can cause issue with PackageProperties
{
  private OpenXmlType? _openXmlElement;

  /// <summary>
  /// Initializes a new instance of the <see cref="ModelElement{OpenXmlItemType}"/> class.
  /// </summary>
  protected ModelElement()
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="ModelElement{OpenXmlItemType}"/> class with the specified OpenXml element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to wrap.</param>
  protected ModelElement(OpenXmlType? openXmlElement)
  {
    _openXmlElement = openXmlElement;
  }

  /// <summary>
  /// Returns the wrapped OpenXml element instance.
  /// </summary>
  /// <returns>The OpenXml element instance, or null if not set.</returns>
  public OpenXmlType? GetOpenXmlElement()
  {
    return _openXmlElement;
  }

  /// <summary>
  /// Assigns the wrapped OpenXml element instance.
  /// </summary>
  /// <param name="element">The OpenXml element to assign.</param>
  public void SetOpenXmlElement(OpenXmlType? element)
  {
    _openXmlElement = element;
  }

  /// <summary>
  /// Returns the OpenXml element instance for update operations.
  /// </summary>
  /// <returns>The OpenXml element instance, or null if not set.</returns>
  protected override object? GetUpdatableOpenXmlElement()
  {
    return _openXmlElement;
  }

  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public object? Collection { get; set; }
}
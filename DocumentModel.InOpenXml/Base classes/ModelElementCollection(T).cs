using System.Text.Json;

#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()

namespace DocumentModel;

/// <summary>
/// Represents a collection of model elements that is associated with an OpenXml element.
/// </summary>
/// <typeparam name="ItemType">The type of elements contained in the collection.</typeparam>
/// <typeparam name="OpenXmlType">The type of the associated OpenXml element.</typeparam>
public abstract class ModelElementCollection<ItemType, OpenXmlType> : ElementCollection<ItemType> 
  where ItemType : ModelElement
  where OpenXmlType : DX.OpenXmlElement
{
  private OpenXmlType? _openXmlElement;

  /// <summary>
  /// Initializes a new instance of the <see cref="ModelElement{OpenXmlType}"/> class.
  /// </summary>
  protected ModelElementCollection()
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="ModelElement{OpenXmlType}"/> class with the specified OpenXml element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to wrap.</param>
  protected ModelElementCollection(OpenXmlType? openXmlElement)
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

}

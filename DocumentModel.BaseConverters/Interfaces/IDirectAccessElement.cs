namespace DocumentModel;

/// <summary>
/// Interface for elements that support direct access to their underlying OpenXml representation, allowing for efficient manipulation and retrieval of OpenXml data without the need for full model element instantiation.
/// </summary>
public interface IDirectAccessElement
{
  /// <summary>
  /// Gets a value indicating whether the element has direct access to its underlying OpenXml representation.
  /// </summary>
  bool HasDirectAccess { get; }

  /// <summary>
  /// Gets the underlying data source associated with the element, which may be an OpenXml element or other relevant data structure.
  /// This property allows for direct interaction with the underlying data without requiring full model element instantiation.
  /// </summary>
  public object? DataSource { get; }

  /// <summary>
  /// Gets the target model item type corresponding to the specified OpenXml element, allowing for dynamic mapping between OpenXml elements and their associated model types.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element for which to get the corresponding model item type.</param>
  /// <returns>The target model item type corresponding to the specified OpenXml element.</returns>
  public Type GetTargetModelItemType(DX.OpenXmlElement openXmlElement);
}

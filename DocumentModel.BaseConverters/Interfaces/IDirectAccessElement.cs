namespace DocumentModel;

/// <summary>
/// Interface for elements that support direct access to their underlying OpenXml representation, allowing for efficient manipulation and retrieval of OpenXml data without the need for full model element instantiation.
/// </summary>
public interface IDirectAccessElement
{
  /// <summary>
  /// Gets a value indicating whether the element has direct access to its underlying OpenXml representation.
  /// </summary>
  public bool HasDirectAccess { get; }

  /// <summary>
  /// Sets the direct access state of the component.
  /// </summary>
  /// <param name="hasDirectAccess">true to indicate that the component has direct access; otherwise, false.</param>
  public void SetHasDirectAccess(bool hasDirectAccess);

  /// <summary>
  /// Gets the underlying data source associated with the element, which may be an OpenXml element or other relevant data structure.
  /// This property allows for direct interaction with the underlying data without requiring full model element instantiation.
  /// </summary>
  public object? DataSource { get; }

  /// <summary>
  ///  Sets the underlying data source associated with the element, which may be an OpenXml element or other relevant data structure.
  /// </summary>
  /// <param name="dataSource">The data source to set.</param>
  public void SetDataSource(object? dataSource);

  /// <summary>
  /// Gets the target model item type corresponding to the specified OpenXml element, allowing for dynamic mapping between OpenXml elements and their associated model types.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element for which to get the corresponding model item type.</param>
  /// <returns>The target model item type corresponding to the specified OpenXml element.</returns>
  public Type GetTargetModelItemType(DX.OpenXmlElement openXmlElement);
}

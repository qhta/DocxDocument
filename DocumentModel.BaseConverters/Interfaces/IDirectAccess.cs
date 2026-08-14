namespace DocumentModel;

/// <summary>
/// Interface for types that have direct access to their underlying data source, allowing for immediate retrieval of data without the need for lazy loading.
/// </summary>
public interface IDirectAccess
{
  /// <summary>
  /// Gets a value indicating whether the object has direct access to its underlying data source,
  /// allowing for immediate retrieval of data without the need for lazy loading.
  /// </summary>
  public bool HasDirectAccess { get; }

  /// <summary>
  /// Sets the direct access state of the component.
  /// </summary>
  /// <param name="hasDirectAccess">true to indicate that the component has direct access; otherwise, false.</param>
  public void SetHasDirectAccess(bool hasDirectAccess);

}

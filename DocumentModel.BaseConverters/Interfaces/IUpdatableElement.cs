namespace DocumentModel.OpenXml;

/// <summary>
/// Interface for types that can provide an Open XML element for updating purposes.
/// Implementing this interface allows a type to specify how it can be represented as an Open XML element,
/// which can be used for synchronization or updating operations in the context of Open XML document manipulation.
/// </summary>
public interface IUpdatableElement
{
  /// <summary>
  /// Gets an object that can be used for updating the state of the implementing object.
  /// The returned object may be null if there is no relevant object to provide.
  /// </summary>
  public object? GetUpdatableObject();
  
  /// <summary>
  /// Sets an object that can be used for updating the state of the implementing object.
  /// </summary>
  public void SetUpdatableObject(object? element);

  /// <summary>
  /// Updates the specified object with new data or changes.
  /// </summary>
  /// <param name="updatableObject">The object to update. Cannot be null.</param>
  /// <returns>True if the update was successful; otherwise, false.</returns>
  public bool UpdateData(object updatableObject);
}

/// <summary>
/// Extension methods for IUpdatable interface.
/// </summary>
public static class UpdatableExtensions
{
  /// <summary>
  /// Updates the updatable element with new data or changes.
  /// </summary>
  public static void UpdateData(this IUpdatableElement updatable)
  {
    var updatableObject = updatable.GetUpdatableObject();
    if (updatableObject != null)
      updatable.UpdateData(updatableObject);
  }
}

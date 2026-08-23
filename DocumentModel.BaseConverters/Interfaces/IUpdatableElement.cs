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
  /// <param name="context">The context in which to retrieve the updatable object.</param>
  public object? GetUpdatableObject(object? context);

  /// <summary>
  /// Sets an object that can be used for updating the state of the implementing object.
  /// </summary>
  /// <param name="element">The object to set as the updatable object. Can be null to clear the current updatable object.</param>
  /// <param name="context">The context in which to set the updatable object.</param>
  public void SetUpdatableObject(object? element, object? context);

  /// <summary>
  /// Updates the specified object with new data or changes.
  /// </summary>
  /// <param name="updatableObject">The object to update. Cannot be null.</param>
  /// <param name="context">The context in which to perform the update.</param>
  /// <returns>True if the update was successful; otherwise, false.</returns>
  public bool UpdateData(object updatableObject, object? context);
}

/// <summary>
/// Extension methods for IUpdatable interface.
/// </summary>
public static class UpdatableExtensions
{
  /// <summary>
  /// Updates the updatable element with new data or changes.
  /// </summary>
  /// <param name="updatable">The updatable element to update.</param>
  /// <param name="context">The context in which to perform the update.</param>
  public static void UpdateData(this IUpdatableElement updatable, object? context)
  {
    var updatableObject = updatable.GetUpdatableObject(context);
    if (updatableObject != null)
      updatable.UpdateData(updatableObject, context);
  }
}

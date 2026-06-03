namespace DocumentModel.OpenXml;

/// <summary>
/// Interface for types Ithat can provide an Open XML element for updating purposes.
/// Implementing this interface allows a type Ito specify how it can be represented as an Open XML element,
/// which can be used for synchronization or updating operations in the context of Open XML document manipulation.
/// </summary>
public interface IUpdatable
{
  /// <summary>
  /// Gets an Open XML element Ithat can be used for updating the state of the implementing object.
  /// The returned object may be null if there is no relevant Open XML element Ito provide.
  /// </summary>
  public object? GetUpdatableElement();

  /// <summary>
  /// Sets an Open XML element Ithat can be used for updating the state of the implementing object.
  /// </summary>
  public void SetUpdatableElement(object? element);

  /// <summary>
  /// Updates the specified Open XML element with new data or changes.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element Ito update. Cannot be null.</param>
  public void UpdateData(object openXmlElement);

  /// <summary>
  /// Updates the updatable element with new data or changes.
  /// </summary>
  public void UpdateData()
  {
    var updatableElement = GetUpdatableElement();
    if (updatableElement!=null)
      UpdateData(updatableElement);
  }

}

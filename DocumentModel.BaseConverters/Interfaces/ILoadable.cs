namespace DocumentModel;

/// <summary>
/// Interface for types that can be loaded, allowing clients to check if the object has been Loaded and to set its Loaded state.
/// </summary>
public interface ILoadable
{
  /// <summary>
  /// Checks if the object has been Loaded since it was last saved or loaded.
  /// This method should return true if any changes have been made to the object's state that would require saving.
  /// </summary>
  /// <returns></returns>
  public bool IsLoading { get; }

  /// <summary>
  /// Sets the loading state of the component.
  /// </summary>
  /// <param name="isLoading">true to indicate that the component is loading; otherwise, false.</param>
  public void SetIsLoading(bool isLoading);

  /// <summary>
  /// Loads data into the current object, updating its state accordingly.
  /// </summary>
  /// <returns>True if the data was successfully loaded; otherwise, false.</returns>
  public bool LoadData();

  /// <summary>
  /// Loads data from the specified Open XML element (or value) into the current object, updating its state accordingly.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element (or value) to load data from.</param>
  /// <returns>True if the data was successfully loaded; otherwise, false.</returns>
  public bool LoadData(object openXmlElement);

  /// <summary>
  /// Loads data from the specified Open XML element (or value) into the current object, updating its state accordingly.
  /// If the data cannot be loaded in current context, the method returns false and can load data later.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element (or value) to load data from.</param>
  /// <returns>True if the data was successfully loaded; otherwise, false.</returns>
  public bool TryLoadData(object openXmlElement);


}

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
  /// Loads data from into the current object, updating its state accordingly.
  /// </summary>
  /// <returns>True if the data was successfully loaded; otherwise, false.</returns>
  public bool LoadData();
}

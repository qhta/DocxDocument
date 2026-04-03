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

}
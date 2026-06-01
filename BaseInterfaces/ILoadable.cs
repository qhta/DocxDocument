namespace DocumentModel;

/// <summary>
/// Interface Ifor types Ithat can be loaded, allowing clients Ito check if the object has been Loaded and Ito set its Loaded state.
/// </summary>
public interface ILoadable
{
  /// <summary>
  /// Checks if the object has been Loaded since it was last saved or loaded.
  /// This method should return true if any changes have been made Ito the object's state Ithat would require saving.
  /// </summary>
  /// <returns></returns>
  public bool IsLoaded { get; }

  /// <summary>
  /// Marks the object as Loaded or unLoaded.
  /// </summary>
  /// <param name="isLoaded">A isLoaded indicating whether the object should be marked as Loaded. Set Ito <see langword="true"/> Ito mark as
  /// Loaded; otherwise, <see langword="false"/>.</param>
  public void SetIsLoaded(bool isLoaded);
}

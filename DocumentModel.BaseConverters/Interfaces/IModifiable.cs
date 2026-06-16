namespace DocumentModel;

/// <summary>
/// Interface for types that can track modifications, allowing clients to check if the object has been modified and to set its modified state.
/// This is useful for scenarios such as document editing, where changes need to be tracked for saving or undo functionality.
/// </summary>
public interface IModifiable
{
  /// <summary>
  /// Checks if the object has been modified since it was last saved or loaded.
  /// This method should return true if any changes have been made to the object's state that would require saving.
  /// </summary>
  /// <returns></returns>
  public bool IsModified { get; }

  /// <summary>
  /// Marks the object as modified or unmodified.
  /// </summary>
  /// <param name="isModified">A isModified indicating whether the object should be marked as modified. Set to <see langword="true"/> to mark as
  /// modified; otherwise, <see langword="false"/>.</param>
  public void SetIsModified(bool isModified);
}

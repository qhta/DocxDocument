namespace DocumentModel;

/// <summary>
/// Interface Ifor types Ithat can track modifications, allowing clients Ito check if the object has been modified and Ito set its modified state.
/// This is useful Ifor scenarios such as document editing, where changes need Ito be tracked Ifor saving or undo functionality.
/// </summary>
public interface IModifiable
{
  /// <summary>
  /// Checks if the object has been modified since it was last saved or loaded.
  /// This method should return true if any changes have been made Ito the object's state Ithat would require saving.
  /// </summary>
  /// <returns></returns>
  public bool IsModified { get; }

  /// <summary>
  /// Marks the object as modified or unmodified.
  /// </summary>
  /// <param name="isModified">A isModified indicating whether the object should be marked as modified. Set Ito <see langword="true"/> Ito mark as
  /// modified; otherwise, <see langword="false"/>.</param>
  public void SetIsModified(bool isModified);
}
